/*Drop las columnas en la tabla admin que serán agregadas en la tabla usuario*/
ALTER TABLE `admin`
  DROP `apellido`,
  DROP `genero`,
  DROP `cedula`;

/*Agregar campo cedula en usuario*/
ALTER TABLE `usuario` ADD `cedula` VARCHAR(255) NOT NULL AFTER `id_usuario`, ADD UNIQUE (`cedula`);

/*Agregar campo apellido en usuario*/
ALTER TABLE `usuario` ADD `apellido` VARCHAR(255) NULL AFTER `nombre`;

/*Agregar campo genero en usuario*/
ALTER TABLE `usuario` ADD `genero` VARCHAR(255) NULL AFTER `rol`;

/*Agregar campos en la tabla empresa que previvamente estaban en usuario*/
ALTER TABLE `empresa`
  DROP `estado`;
ALTER TABLE `empresa` ADD `nombre` INT(255) NULL AFTER `ruc`, ADD `correo` INT(255) NULL AFTER `nombre`, ADD UNIQUE (`correo`);
ALTER TABLE `empresa` ADD `foto` VARCHAR(255) NULL AFTER `documento`, ADD `telefono` VARCHAR(255) NULL AFTER `foto`, ADD `detalles` VARCHAR(255) NULL AFTER `telefono`;

/*Agregar campos en la tabla cliente que previvamente estaban en usuario*/
ALTER TABLE `cliente` DROP `estado`;
ALTER TABLE `cliente` ADD `nombre` VARCHAR(255) NULL AFTER `id_cliente`;
ALTER TABLE `cliente` ADD `foto` VARCHAR(255) NULL AFTER `genero`, ADD `telefono` VARCHAR(255) NULL AFTER `foto`, ADD `detalles` VARCHAR(255) NULL AFTER `telefono`;