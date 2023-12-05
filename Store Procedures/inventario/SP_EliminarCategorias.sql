-- Creación del procedimiento para
DELIMITER $$
CREATE PROCEDURE SP_EliminarCategorias()
BEGIN
DELETE FROM Categoria WHERE id_categoria = id;
END $$
DELIMITER;