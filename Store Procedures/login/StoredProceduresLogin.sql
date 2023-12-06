DELIMITER $$
CREATE PROCEDURE `SP_IngresarUsuario`(
    IN p_nombre VARCHAR(50),
    IN p_correo VARCHAR(100),
    IN p_contrasena VARCHAR(50),
    out p_resultado INT 
)
BEGIN
	DECLARE EXIT HANDLER FOR SQLEXCEPTION
	BEGIN
        ROLLBACK;
        SET p_resultado = 0;
    END;
	START TRANSACTION;

    
        INSERT INTO usuario (nombre, correo, pass)
        VALUES (p_nombre, p_correo, p_contrasena);
    SELECT Row_COUNT() INTO p_resultado;
    COMMIT;
END$$
DELIMITER ;