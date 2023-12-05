-- Creación del procedimiento para
DELIMITER $$
CREATE PROCEDURE SP_VerCategorias()
BEGIN
	SELECT *FROM categoria;
END $$
DELIMITER ;