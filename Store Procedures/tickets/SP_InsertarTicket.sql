-- Creación de Procedimiento Almacenado SP_InsertarTicket
DELIMITER $$

CREATE PROCEDURE SP_InsertarTicket (
        IN p_admin_id INT,
        IN p_categoria_id INT, 
        IN p_prioridad_id INT,
        IN p_estado_id INT,
    	IN p_descripcion VARCHAR(255),
        IN p_evidencia VARCHAR(255),
        IN p_fecha DATETIME,
        IN p_fecha_cambio_estado DATETIME,
        OUT p_resultado INT
)

BEGIN
	DECLARE EXIT HANDLER FOR SQLEXCEPTION
        BEGIN
            ROLLBACK;
            SET p_resultado = 0;
        END;

        START TRANSACTION;
        
        INSERT INTO tickets (admin_id, categoria_id, prioridad_id, estado_id, descripcion, evidencia, fecha, fecha_cambio_estado) 
        VALUES (p_admin_id, p_categoria_id, p_prioridad_id, p_estado_id, p_descripcion, p_evidencia, p_fecha, p_fecha_cambio_estado);
        
        SELECT ROW_COUNT() INTO p_resultado;
    	COMMIT;
END $$
 
DELIMITER ;
