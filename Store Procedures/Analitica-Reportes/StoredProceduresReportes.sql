DELIMITER //

CREATE PROCEDURE SP_ObtenerReporteInventario (
    IN marca_id_param INT,
    IN categoria_id_param INT
)
BEGIN
    SELECT p.*, m.nombre AS nombre_marca, c.nombre AS nombre_categoria
    FROM Producto p
    LEFT JOIN Marca m ON p.marca_id = m.id_marca
    LEFT JOIN Categoria c ON p.categoria_id = c.id_categoria
    WHERE
        (marca_id_param IS NULL OR p.marca_id = marca_id_param) AND
        (categoria_id_param IS NULL OR p.categoria_id = categoria_id_param);
END //

DELIMITER ;
CALL SP_ObtenerReporteInventario(NULL, NULL);


DELIMITER //

CREATE PROCEDURE SP_ObtenerPedidosClientes (
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
END //

DELIMITER ;

DELIMITER $$
CREATE PROCEDURE SP_ObtenerMarcas()
BEGIN
    SELECT id_marca, nombre FROM marca;
END;
$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE SP_ObtenerCategorias()
BEGIN
	select  id_categoria, nombre from categoria;
END;
$$
DELIMITER ;


DELIMITER //

DELIMITER //

CREATE PROCEDURE SP_ObtenerClientesYCompras(
    IN provincia_id INT,
    IN producto_id INT
)
BEGIN
    -- Temporal para almacenar resultados
    CREATE TEMPORARY TABLE TempResultados (
        pedido_id INT,
        fecha_pedido DATETIME,
        cliente_id INT,
        cliente_nombre VARCHAR(255),
        empresa_nombre VARCHAR(255),
        provincia_nombre VARCHAR(255),
        producto_nombre VARCHAR(255),
        estado_pedido VARCHAR(255),
        total_compras INT
    );

    -- Consulta principal para obtener clientes, empresas, provincias, productos y estados más comprados
    INSERT INTO TempResultados
    SELECT
        PE.id_pedido,
        PE.fecha,
        C.id_cliente,
        C.nombre AS cliente_nombre,
        E.nombre AS empresa_nombre,
        P.nombre AS provincia_nombre,
        PR.nombre AS producto_nombre,
        PEstado.estado AS estado_pedido,
        SUM(COMP.cantidad) AS total_compras
    FROM Cliente C
    JOIN Empresa E ON C.empresa_id = E.id_empresa
    JOIN Cliente_direcciones CD ON C.id_cliente = CD.cliente_id
    JOIN Direccion D ON CD.direccion_id = D.id_direccion
    JOIN Provincia P ON D.provincia_id = P.id_provincia
    JOIN Pedido PE ON C.id_cliente = PE.cliente_id
    JOIN Pedido_producto COMP ON PE.id_pedido = COMP.pedido_id
    JOIN Producto PR ON COMP.producto_id = PR.id_producto
    JOIN Pedido_estado PEstado ON PE.estado_id = PEstado.id_pedido_estado
    WHERE (provincia_id IS NULL OR P.id_provincia = provincia_id)
        AND (producto_id IS NULL OR PR.id_producto = producto_id)
    GROUP BY PE.id_pedido, PE.fecha, C.id_cliente, E.nombre, P.id_provincia, PR.id_producto, PEstado.estado
    ORDER BY total_compras DESC;

    -- Selección final
    SELECT *
    FROM TempResultados;

    -- Eliminar la tabla temporal
    DROP TEMPORARY TABLE IF EXISTS TempResultados;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE SP_ObtenerProvincias()
BEGIN
	SELECT id_provincia, nombre from provincia;
END //

DELIMITER ;

DELIMITER //

CREATE PROCEDURE SP_ObtenerProductos()
BEGIN
	SELECT id_producto, nombre from producto;
END //

DELIMITER ;