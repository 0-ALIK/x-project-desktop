-- Procedimiento almacenado para obtener todas las categorias
DELIMITER $$

CREATE PROCEDURE SP_ObtenerCategorias()
READS SQL DATA
BEGIN
    SELECT id_tickets_categoria, categoria FROM tickets_categoria;
END $$

DELIMITER ;