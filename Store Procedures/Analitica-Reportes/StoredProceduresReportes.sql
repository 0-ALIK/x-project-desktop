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
