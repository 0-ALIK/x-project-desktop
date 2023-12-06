-- Creación de Procedimiento Almacenado SP_InsertarTicket
DELIMITER $$

CREATE PROCEDURE SP_InsertarTicket (
        IN p_usuario_id INT,
        IN p_categoria_id INT, 
        IN p_prioridad_id INT,
        IN p_estado_id INT,
    	IN p_descripcion LONGTEXT,
        IN p_evidencia LONGTEXT,
        OUT p_resultado INT
)

BEGIN
	DECLARE EXIT HANDLER FOR SQLEXCEPTION
        BEGIN
            ROLLBACK;
            SET p_resultado = 0;
        END;

        START TRANSACTION;
        
        INSERT INTO tickets (usuario_id, categoria_id, prioridad_id, estado_id, descripcion, evidencia) 
        VALUES (p_usuario_id, p_categoria_id, p_prioridad_id, p_estado_id, p_descripcion, p_evidencia);
        
        SELECT ROW_COUNT() INTO p_resultado;
    	COMMIT;
END $$
 
DELIMITER ;


-- Procedimiento almacenado para obtener todas las categorias de los tickets
DELIMITER $$

CREATE PROCEDURE SP_ObtenerCategoriasTickets()
READS SQL DATA
BEGIN
    SELECT id_tickets_categoria, categoria FROM tickets_categoria;
END $$

DELIMITER ;

-- Procedimiento almacenado para obtener tickets
Delimiter $$
CREATE PROCEDURE SP_ObtenerTickets(in p_estado_id int)
Begin
	SELECT a.id_tickets, u.nombre, b.categoria, d.prioridad, c.estado, a.fecha_cambio_estado
		from tickets a
        inner join usuario u on a.usuario_id = u.id_usuario
        inner join tickets_categoria b on a.categoria_id = b.id_tickets_categoria
        inner join tickets_estado c on a.estado_id = c.id_tickets_estado
        inner join tickets_prioridad d on a.prioridad_id = d.id_tickets_prioridad
        where (p_estado_id IS NULL OR a.estado_id = p_estado_id)
        order by c.id_tickets_estado ASC,
				 d.id_tickets_prioridad DESC;
		
end $$
delimiter ;

-- Procedimiento almacenado para obtener los detalles de un ticket
DELIMITER //

CREATE PROCEDURE SP_ObtenerDetalleTicket(
    IN p_ticket_id INT
)
BEGIN
    
    SELECT descripcion
    FROM Tickets
    WHERE id_tickets = p_ticket_id;
END //

DELIMITER ;


-- Procedimiento almacenado para obtener la evidencia de un ticket
DELIMITER //

CREATE PROCEDURE SP_ObtenerEvidenciaTicket(
    IN p_ticket_id INT
)
BEGIN
    
    SELECT evidencia
    FROM tickets
    WHERE id_tickets = p_ticket_id;
END //

DELIMITER ;

-- Procedimiento almacenado para eliminar ticket
delimiter $$
CREATE PROCEDURE SP_EliminarTicket (
        IN p_ticket_id INT,
        OUT p_resultado INT
)

BEGIN
	DECLARE EXIT HANDLER FOR SQLEXCEPTION
        BEGIN
            ROLLBACK;
            SET p_resultado = 0;
        END;
        START TRANSACTION;
        Delete from tickets where id_tickets = p_ticket_id;
        SELECT ROW_COUNT() INTO p_resultado;
    	COMMIT;
END $$
 
DELIMITER ;


-- Procedimiento almacenado para obtener el estado de un ticket
DELIMITER $$

CREATE PROCEDURE SP_ObtenerEstadoTicket()
READS SQL DATA
BEGIN
    SELECT id_tickets_estado, estado FROM tickets_estado;
END $$

DELIMITER ;



-- Creación de Procedimiento Almacenado SP_ActualizarEstado
DELIMITER $$

CREATE PROCEDURE SP_ActualizarEstado (
        IN p_tickets_id INT,
        IN p_estado_id INT,
        OUT p_resultado INT
)

BEGIN
	DECLARE EXIT HANDLER FOR SQLEXCEPTION
        BEGIN
            ROLLBACK;
            SET p_resultado = 0;
        END;

        START TRANSACTION;
        
        UPDATE tickets 
    	SET estado_id = p_estado_id,
        fecha_cambio_estado = CURRENT_TIMESTAMP
    	WHERE id_tickets = p_tickets_id;
        
        SELECT ROW_COUNT() INTO p_resultado;
    	COMMIT;
END $$
 
DELIMITER ;