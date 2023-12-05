-- Procedimiento para Ver Categorias
DELIMITER $$
CREATE PROCEDURE SP_VerCategorias()
BEGIN

END $$
DELIMITER ;


-- Procedimiento para Insertar Categorias
DELIMITER $$
CREATE PROCEDURE SP_InsertarCategorias()
BEGIN

END $$
DELIMITER ;


-- Procedimiento para Eliminar Categorias
DELIMITER $$
CREATE PROCEDURE SP_EliminarCategorias()
BEGIN
DELETE FROM Categoria WHERE id_categoria = id;
END $$
DELIMITER ;


-- Procedimiento para Actualizar Categorias
DELIMITER $$
CREATE PROCEDURE SP_ActualizarCategoria()
BEGIN
	
END $$
DELIMITER ;