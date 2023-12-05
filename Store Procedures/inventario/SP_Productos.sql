﻿-- Procedimiento para ver Productos
DELIMITER $$
CREATE PROCEDURE SP_VerProductos()
BEGIN

 SELECT
        pr.nombre AS 'Producto', ca.nombre AS 'Categoria', ma.nombre AS 'Marca',
        pr.precio_unit AS 'Precio Unit', pr.cantidad_por_cajas AS 'Stock', pr.foto AS 'foto',
        CASE pr.punto_reorden
            WHEN 0 THEN 'No aplica'
            WHEN 1 THEN 'Aplica'
        END AS 'P.reorden'

    FROM
        producto AS pr
    JOIN categoria AS ca ON pr.categoria_id = ca.id_categoria
    JOIN marca AS ma ON pr.marca_id = ma.id_marca;

END $$
DELIMITER ;


-- Procedimiento para insertar Productos
DELIMITER $$
CREATE PROCEDURE SP_InsertarProductos(IN p_nombre VARCHAR(255),
    IN p_precio_unit DECIMAL(10, 2),
    IN p_cantidad_por_cajas INT,
    IN p_punto_reorden INT,
    IN p_cantidad_cajas INT,
    IN p_marca_id INT,
    IN p_categoria_id INT
)
BEGIN
   
    INSERT INTO Producto (nombre, precio_unit, cantidad_por_cajas, punto_reorden, cantidad_cajas, marca_id, categoria_id)
    VALUES (p_nombre, p_precio_unit, p_cantidad_por_cajas, p_punto_reorden, p_cantidad_cajas, p_marca_id, p_categoria_id);
    
END $$
DELIMITER ;



-- Procedimiento para eliminar Productos
DELIMITER $$
CREATE PROCEDURE SP_EliminarProductos()
BEGIN

END $$
DELIMITER ;


-- Procedimiento para actualizar Productos
DELIMITER $$
CREATE PROCEDURE SP_ActualizarProductos()
BEGIN

END $$
DELIMITER ;