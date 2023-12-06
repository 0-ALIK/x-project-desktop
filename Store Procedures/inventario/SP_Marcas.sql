-- Procedimiento para Ver Marcas
DELIMITER $$
CREATE PROCEDURE SP_VerMarcas()
BEGIN

    SELECT * FROM marca;

END $$
DELIMITER ;


-- Procedimiento para Insertar Marcas
DELIMITER $$
CREATE PROCEDURE SP_InsertarMarcas(
    IN nombre VARCHAR(255),
    IN descripcion VARCHAR(255),
    IN logo VARCHAR(255)
)
BEGIN

    INSERT INTO marca (nombre, descripcion, logo)
    VALUES (nombre, descripcion, logo);

END $$
DELIMITER ;


-- Procedimiento para Eliminar Marcas
DELIMITER $$
CREATE PROCEDURE SP_EliminarMarca(
    IN id INT
)
BEGIN

    DELETE FROM marca WHERE id_marca = id;

END $$
DELIMITER ;

--Procedimiento para Ver Productos Asociados a las Marcas

DELIMITER $$
CREATE PROCEDURE SP_TieneProductosAsociados(
    IN idMarca INT,
    OUT tieneProductos BIT
)
BEGIN

    SELECT COUNT(*) INTO tieneProductos FROM producto WHERE marca_id = idMarca;

END $$
DELIMITER ;


-- Procedimiento para Actualizar Marcas
DELIMITER $$

CREATE PROCEDURE SP_ActualizarMarcas(
    IN p_id_marca INT,
    IN p_nombre VARCHAR(255),
    IN p_descripcion VARCHAR(255),
    IN p_logo LONGTEXT
)
BEGIN

    UPDATE marca
    SET nombre = p_nombre, descripcion = p_descripcion, logo = p_logo
    WHERE id_marca = p_id_marca;

END $$

DELIMITER ;


-- Creación del procedimiento para obtener una marca en especifico
DELIMITER $$
CREATE PROCEDURE SP_ObtenerMarca(
	IN marca_id INT
)

BEGIN

    SELECT * FROM marca
    	WHERE id_marca = marca_id;

END $$
DELIMITER ;