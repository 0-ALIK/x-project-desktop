-- Creación del procedimiento para
DELIMITER $$
CREATE PROCEDURE SP_EliminarProductos()
BEGIN
    DELETE FROM producto WHERE id_producto = id;
END; $$
DELIMITER ;