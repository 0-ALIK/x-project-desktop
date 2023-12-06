-- Procedimiento para Ver Productos
DELIMITER $$
CREATE PROCEDURE SP_VerProductos()
BEGIN
    SELECT
        pr.id_producto AS 'id',
        pr.nombre AS 'Producto', 
        ca.nombre AS 'Categoria', 
        ma.nombre AS 'Marca',
        pr.precio_unit AS 'Precio Unit', 
        pr.cantidad_por_cajas AS 'Stock', 
        pr.foto AS 'foto',
    CASE 
        WHEN pr.punto_reorden < 20 THEN 'Aplica'
        ELSE 'No aplica'
    END AS 'P.reorden'
    FROM
        producto AS pr
    JOIN categoria AS ca ON pr.categoria_id = ca.id_categoria
    JOIN marca AS ma ON pr.marca_id = ma.id_marca;
END $$
DELIMITER ;


-- Procedimiento para Insertar Productos
DELIMITER $$
CREATE PROCEDURE SP_InsertarProductos(
    IN p_nombre VARCHAR(255),
    IN p_precio_unit DECIMAL(10, 2),
    IN p_cantidad_por_cajas INT,
    IN p_punto_reorden INT,
    IN p_cantidad_cajas INT,
    IN p_marca_id INT,
    IN p_categoria_id INT,
    IN p_imagen LONGTEXT
)
BEGIN
   
    INSERT INTO Producto (nombre, precio_unit, cantidad_por_cajas, punto_reorden, cantidad_cajas, marca_id, categoria_id, foto)
    VALUES (p_nombre, p_precio_unit, p_cantidad_por_cajas, p_punto_reorden, p_cantidad_cajas, p_marca_id, p_categoria_id, p_imagen);    

END $$
DELIMITER ;


-- Procedimiento para Eliminar Productos
DELIMITER $$
CREATE PROCEDURE SP_EliminarProductos(
    IN id INT
)
BEGIN

    DELETE FROM producto WHERE id_producto = id;

END $$
DELIMITER ;


-- Procedimiento para Actualizar Productos
DELIMITER $$
CREATE PROCEDURE SP_ActualizarProductos()
BEGIN

END $$
DELIMITER ;