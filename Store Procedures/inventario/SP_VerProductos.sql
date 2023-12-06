-- Creación del procedimiento para
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