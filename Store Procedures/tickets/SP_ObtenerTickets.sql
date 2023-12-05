Delimiter $$
CREATE PROCEDURE `SP_ObtenerTickets`()
Begin
	SELECT a.id_tickets, b.categoria, d.prioridad, c.estado, a.fecha
		from tickets a
        inner join tickets_categoria b on a.categoria_id = b.id_tickets_categoria
        inner join tickets_estado c on a.estado_id = c.id_tickets_estado
        inner join tickets_prioridad d on a.prioridad_id = d.id_tickets_prioridad
        order by c.id_tickets_estado ASC,
				 d.id_tickets_prioridad DESC;
end $$
delimiter ;