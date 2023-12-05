-- Creación del procedimiento para
DELIMITER $$
CREATE PROCEDURE SP_InsertarCategorias(IN nombre VARCHAR(255))
BEGIN
    INSERT INTO categoria (nombre) VALUES (nombre);
END $$
DELIMITER ;