-- Procedimiento para Ver Categorias
DELIMITER $$
CREATE PROCEDURE SP_VerCategorias()
BEGIN

	SELECT * FROM categoria;

END $$
DELIMITER ;


-- Procedimiento para Insertar Categorias
DELIMITER $$
CREATE PROCEDURE SP_InsertarCategorias(
	IN nombre VARCHAR(255)
)
BEGIN

    INSERT INTO categoria (nombre) VALUES (nombre);

END $$
DELIMITER ;


-- Procedimiento para Eliminar Categorias
DELIMITER $$
CREATE PROCEDURE SP_EliminarCategorias(
	IN id INT
)
BEGIN

	DELETE FROM Categoria WHERE id_categoria = id;

END $$
DELIMITER ;