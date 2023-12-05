-- Creación del procedimiento para
DELIMITER $$
CREATE PROCEDURE SP_EliminarCategoria(IN id INT)
BEGIN

    DELETE FROM Categoria WHERE id_categoria = id;

END;
$$
DELIMITER ;
