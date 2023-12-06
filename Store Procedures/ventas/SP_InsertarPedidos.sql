DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarInventario`(
    IN producto_id_param INT,
    IN cantidad_param INT
)
BEGIN
    DECLARE cantidad_disponible INT;

    -- Obtener la cantidad disponible actual
    SELECT cantidad_cajas INTO cantidad_disponible
    FROM producto
    WHERE id_producto = producto_id_param;

    -- Verificar si hay suficientes productos disponibles
    IF cantidad_disponible >= cantidad_param THEN
        -- Actualizar la cantidad disponible restando la cantidad comprada
        UPDATE producto
        SET cantidad_cajas = cantidad_disponible - cantidad_param
        WHERE id_producto = producto_id_param;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'No hay suficientes productos disponibles para la compra';
    END IF;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerCategorias`()
BEGIN
	select  id_categoria, nombre from categoria;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerDetalleVenta`(IN `pedidoIdParam` INT)
BEGIN
    -- Variables para el detalle del pedido
    DECLARE IdPedido INT;
DECLARE IdCliente INT;
    DECLARE FechaPedido DATETIME;
    DECLARE NombreCliente VARCHAR(255);
    DECLARE CedulaCliente VARCHAR(255);
    DECLARE TelefonoCliente VARCHAR(255);
    DECLARE DetallesCliente VARCHAR(255);
    DECLARE NombreEmpresa VARCHAR(255);
    DECLARE RucEmpresa VARCHAR(255);
    DECLARE ProvinciaId INT;
    DECLARE TelefonoDireccion VARCHAR(255);
    DECLARE DetallesDireccion VARCHAR(255);
    DECLARE EstadoPedido VARCHAR(255); -- Agregada

    -- Variable para el importe total
    DECLARE importeTotal DECIMAL(10, 2);

    -- Obtener detalles del pedido
    -- Obtener detalles del pedido
SELECT
    p.id_pedido,
    p.fecha,
    c.nombre,
    c.cedula,
    c.telefono,
    c.detalles AS DetallesCliente,
    e.razon_social,
    e.ruc,
    d.provincia_id,
    d.telefono AS TelefonoDireccion,
    d.detalles AS DetallesDireccion,
    pe.estado AS EstadoPedido,
    c.id_cliente AS ClienteId -- Aquí está la corrección
INTO
    IdPedido,
    FechaPedido,
    NombreCliente,
    CedulaCliente,
    TelefonoCliente,
    DetallesCliente,
    NombreEmpresa,
    RucEmpresa,
    ProvinciaId,
    TelefonoDireccion,
    DetallesDireccion,
    EstadoPedido,
    IdCliente
FROM
    pedido p
INNER JOIN cliente c ON p.cliente_id = c.id_cliente
LEFT JOIN empresa e ON c.empresa_id = e.id_empresa
LEFT JOIN direccion d ON p.direccion_id = d.id_direccion
INNER JOIN pedido_estado pe ON p.estado_id = pe.id_pedido_estado
WHERE
    p.id_pedido = pedidoIdParam;



    -- Obtener el nombre de la provincia
    SELECT nombre INTO @NombreProvincia
    FROM provincia
    WHERE id_provincia = ProvinciaId;

    -- Obtener el importe total de la venta
    SELECT SUM(pp.cantidad * pr.precio_unit) INTO importeTotal
    FROM pedido_producto pp
    INNER JOIN producto pr ON pp.producto_id = pr.id_producto
    WHERE pp.pedido_id = pedidoIdParam;

    -- Devolver resultados
    SELECT
        IdPedido AS IdPedido,
        FechaPedido AS FechaPedido,
        NombreCliente AS NombreCliente,
        CedulaCliente AS CedulaCliente,
        TelefonoCliente AS TelefonoCliente,
        DetallesCliente AS DetallesCliente,
        NombreEmpresa AS NombreEmpresa,
        RucEmpresa AS RucEmpresa,
        @NombreProvincia AS NombreProvincia,
        TelefonoDireccion AS TelefonoDireccion,
        DetallesDireccion AS DetallesDireccion,
        EstadoPedido AS EstadoPedido, -- Agregada
        importeTotal AS ImporteTotal;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerMarcas`()
BEGIN
    SELECT id_marca, nombre FROM marca;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerPedidos`()
BEGIN
    SELECT 
        c.id_pedido AS IdPedido, 
        cli.nombre AS Cliente, 
        c.fecha AS FechaCompra, 
        pe.estado AS EstadoPedido, 
        e.razon_social AS Empresa,
        (pp.cantidad * p.precio_unit) AS ImporteVenta,
        COALESCE(SUM(pa.monto), 0) AS ImportePagado,
        ((pp.cantidad * p.precio_unit) - COALESCE(SUM(pa.monto), 0)) AS ImporteDebido
    FROM pedido c
    JOIN cliente cli ON c.cliente_id = cli.id_cliente
    JOIN pedido_estado pe ON c.estado_id = pe.id_pedido_estado
    JOIN cliente_direcciones cd ON c.cliente_id = cd.cliente_id
    JOIN direccion d ON cd.direccion_id = d.id_direccion
    JOIN empresa_direcciones ed ON d.id_direccion = ed.direccion_id
    JOIN empresa e ON ed.empresa_id = e.id_empresa
    JOIN pedido_producto pp ON c.id_pedido = pp.pedido_id
    JOIN producto p ON pp.producto_id = p.id_producto
    LEFT JOIN pago pa ON c.id_pedido = pa.pedido_id
    GROUP BY c.id_pedido, cli.nombre, c.fecha, pe.estado, e.razon_social, (pp.cantidad * p.precio_unit), p.cantidad_cajas;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerPedidosClientes`(
    IN provincia_id_param INT,
    IN producto_id_param INT
)
BEGIN
    SELECT P.*, C.apellido AS cliente_apellido, D.*, PP.cantidad AS cantidad_producto
    FROM Pedido P
    JOIN Cliente C ON P.cliente_id = C.id_cliente
    JOIN Cliente_direcciones CD ON C.id_cliente = CD.cliente_id
    JOIN Direccion D ON CD.direccion_id = D.id_direccion
    LEFT JOIN Pedido_producto PP ON P.id_pedido = PP.pedido_id
    WHERE
        (provincia_id_param IS NULL OR D.provincia_id = provincia_id_param) AND
        (producto_id_param IS NULL OR PP.producto_id = producto_id_param);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_RealizarCompra`(IN `fecha_param` DATETIME, IN `cantidad_param` INT, IN `producto_param` INT, IN `cliente_param` INT, OUT `id_compra` INT)
BEGIN
    -- Insertar la compra en la tabla de pedidos
    INSERT INTO pedido (cliente_id, fecha, estado_id, detalles, direccion_id)
    VALUES (cliente_param, fecha_param, 1, 'En Proceso', (SELECT direccion_id FROM cliente_direcciones WHERE cliente_id = cliente_param LIMIT 1));

    -- Obtener el ID del pedido recién insertado
    SET id_compra = LAST_INSERT_ID();

    -- Insertar el producto en el pedido
    INSERT INTO pedido_producto (pedido_id, producto_id, cantidad)
    VALUES (id_compra, producto_param, cantidad_param);

    -- Actualizar el inventario
    CALL ActualizarInventario(producto_param, cantidad_param);

END$$
DELIMITER ;
