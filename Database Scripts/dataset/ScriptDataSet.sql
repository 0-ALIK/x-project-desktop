-- Insert de marcas
INSERT INTO Marca (nombre, descripcion) VALUES
('Coca-Cola', 'Refresco carbonatado'),
('Pepsi', 'Refresco carbonatado'),
('Sprite', 'Refresco lima-limón'),
('Fanta', 'Refresco de naranja'),
('Red Bull', 'Bebida energética'),
('Mountain Dew', 'Refresco con sabor a citricos'),
('Gatorade', 'Bebida deportiva'),
('Snapple', 'Té y bebidas de frutas'),
('Dr. Pepper', 'Refresco de sabores'),
('7UP', 'Refresco lima-limón'),
('Monster Energy', 'Bebida energética'),
('Aquafina', 'Agua purificada'),
('Lipton', 'Té embotellado'),
('Tropicana', 'Jugo de naranja'),
('Powerade', 'Bebida deportiva'),
('Pocari Sweat', 'Bebida isotónica'),
('Honest Tea', 'Té orgánico'),
('Vitaminwater', 'Agua enriquecida con vitaminas'),
('San Pellegrino', 'Agua mineral con gas'),
('Ocean Spray', 'Jugo de arándano');


-- Inserts para la tabla Categoria
INSERT INTO Categoria (nombre) VALUES
('Refrescos'),
('Bebidas Energéticas'),
('Agua'),
('Té'),
('Jugos'),
('Bebidas Deportivas'),
('Bebidas Orgánicas'),
('Agua Mineral'),
('Té Embotellado'),
('Bebidas con Gas');

-- Inserts para la tabla Producto
INSERT INTO Producto (marca_id, categoria_id, nombre, precio_unit, cantidad_por_cajas, punto_reorden, cantidad_cajas) VALUES
(1, 1, 'Coca-Cola Regular', 1.50, 24, 10, 100),
(2, 1, 'Pepsi Regular', 1.40, 24, 12, 80),
(3, 6, 'Gatorade Fruit Punch', 2.00, 12, 8, 50),
(4, 5, 'Tropicana Pure Premium', 2.50, 12, 15, 75),
(5, 2, 'Red Bull Energy Drink', 3.00, 12, 20, 60),
(6, 3, 'Aquafina Bottled Water', 1.00, 24, 30, 120),
(7, 9, 'Lipton Green Tea', 1.75, 12, 18, 90),
(8, 4, 'Snapple Peach Tea', 2.25, 12, 15, 70),
(9, 8, 'San Pellegrino Sparkling Water', 2.50, 12, 25, 40),
(10, 7, 'Honest Tea Organic Lemon Tea', 2.00, 12, 12, 60),
(11, 5, 'Ocean Spray Cranberry Juice', 2.20, 12, 15, 80),
(12, 2, 'Monster Energy Drink', 2.75, 12, 22, 50),
(13, 10, '7UP', 1.25, 24, 15, 100),
(14, 4, 'Vitaminwater XXX', 2.25, 12, 20, 60),
(15, 6, 'Powerade Berry Blast', 1.75, 12, 10, 70),
(16, 3, 'Dasani Bottled Water', 1.20, 24, 25, 150),
(17, 9, 'Perrier Sparkling Water', 2.75, 12, 20, 30),
(18, 8, 'Pocari Sweat', 2.00, 12, 15, 80),
(19, 1, 'Sprite', 1.30, 24, 12, 90),
(20, 10, 'Fanta Orange', 1.40, 24, 15, 80);


-- Inserts para la tabla Provincia (Panamá)
INSERT INTO Provincia (nombre) VALUES
('Bocas del Toro'),
('Coclé'),
('Colón'),
('Chiriquí'),
('Darién'),
('Herrera'),
('Los Santos'),
('Panamá'),
('Panamá Oeste'),
('Veraguas');

-- Inserts para la tabla Direccion
INSERT INTO Direccion (provincia_id, codigo_postal, telefono, detalles) VALUES
(1, '0101', '111-1111', 'Calle Principal #123'),
(2, '0202', '222-2222', 'Avenida Central #456'),
(3, '0303', '333-3333', 'Boulevard Norte #789'),
(4, '0404', '444-4444', 'Calle Este #234'),
(5, '0505', '555-5555', 'Avenida Oeste #567'),
(6, '0606', '666-6666', 'Calle 1ra #890'),
(7, '0707', '777-7777', 'Avenida 2da #123'),
(8, '0808', '888-8888', 'Boulevard 3ro #456'),
(9, '0909', '999-9999', 'Calle 4ta #789'),
(10, '1010', '000-0000', 'Avenida 5ta #234'),
(1, '0111', '123-4567', 'Urbanización Bella Vista #567'),
(2, '0222', '987-6543', 'Residencial Los Pinos #890'),
(3, '0333', '555-7890', 'Conjunto Residencial La Colina #123'),
(4, '0444', '111-2222', 'Barriada El Carmen #456'),
(5, '0555', '333-4444', 'Villa de las Flores #789'),
(6, '0666', '555-1111', 'Condominio Los Alamos #234'),
(7, '0777', '777-2222', 'Barriada San Francisco #567'),
(8, '0888', '888-3333', 'Residencial Altos de Panamá #890'),
(9, '0999', '999-4444', 'Vista Hermosa #123'),
(10, '1010', '000-5555', 'Costa del Este #456');

-- Insert para la tabla tickets_categoria
INSERT INTO tickets_categoria(categoria) VALUES
('PA'),
('PF'),
('PR'),
('PRA'),
('O');
 
 -- Insert para la tabla tickets_prioridad
INSERT INTO tickets_prioridad(prioridad) VALUES
('1'),
('2'),
('3');
 
  -- Insert para la tabla tickets_estado
INSERT INTO tickets_estado(estado) VALUES
('Espera'),
('Revisado'),
('Resuelto');

-- Inserts para la tabla `direccion`
INSERT INTO direccion (provincia_id, codigo_postal, telefono, detalles) VALUES (1, '12345', '987-6543210', 'Detalles Dirección 1');
INSERT INTO direccion (provincia_id, codigo_postal, telefono, detalles) VALUES (2, '54321', '123-4567890', 'Detalles Dirección 2');
INSERT INTO direccion (provincia_id, codigo_postal, telefono, detalles) VALUES (3, '67890', '456-7890123', 'Detalles Dirección 3');

-- Inserts para la tabla `empresa`
INSERT INTO empresa (ruc,nombre,correo, razon_social, documento, foto, telefono, detalles) VALUES
	('123456789', 'Empresa A', 'correo@empresaA.com', 'Razón Social A', 'Documento Empresa A', 'foto_empresaA.jpg', '123-4567890', 'Detalles Empresa A');
INSERT INTO empresa (ruc,nombre,razon_social, documento, correo, foto, telefono, detalles) VALUES 
	('987654326', 'Empresa B', 'Razón Social B', 'Documento Empresa B', 'empresaB@gmail.com', 'foto_empresaB.jpg', '333-4444', 'Detalles Empresa B'),
	('555555555', 'Empresa C', 'Razón Social C', 'Documento Empresa C', 'empresaC@gmail.com', 'foto_empresaC.jpg', '666-7777', 'Detalles Empresa C'),
	('222222222', 'Empresa D', 'Razón Social D', 'Documento Empresa D', 'empresaD@gmail.com', 'foto_empresaD.jpg', '999-0000', 'Detalles Empresa D'),
	('333333333', 'Empresa E', 'Razón Social E', 'Documento Empresa E', 'empresaE@gmail.com', 'foto_empresaE.jpg', '111-2222', 'Detalles Empresa E'),
	('444444444', 'Empresa F', 'Razón Social F', 'Documento Empresa F', 'empresaF@gmail.com', 'foto_empresaF.jpg', '333-4444', 'Detalles Empresa F');

-- Inserts para la tabla `empresa_direcciones`
INSERT INTO `empresa_direcciones` VALUES (1, 1);
INSERT INTO `empresa_direcciones` VALUES (2, 2);
INSERT INTO `empresa_direcciones` VALUES (3, 3);
INSERT INTO `empresa_direcciones` VALUES (4, 4), (5, 5);


-- Inserts para la tabla `cliente`
INSERT INTO cliente (nombre, apellido, cedula, empresa_id, genero, foto, telefono, detalles, tipo) VALUES ('Cliente A', 'Apellido A', '123456789', 1, 'Masculino', 'foto_clienteA.jpg', '123-4567890', 'Detalles Cliente A', 'minorista');
INSERT INTO cliente (nombre, apellido, cedula, empresa_id, genero, foto, telefono, detalles, tipo) VALUES ('Cliente B', 'Apellido B', '987654321', 2, 'Femenino', 'foto_clienteB.jpg', '987-6543210', 'Detalles Cliente B', 'distribuidor');
INSERT INTO cliente (nombre, apellido, cedula, empresa_id, genero, foto, telefono, detalles, tipo) VALUES ('Cliente C', 'Apellido C', '456789012', 3, 'Masculino', 'foto_clienteC.jpg', '456-7890123', 'Detalles Cliente C', 'minorista');
INSERT INTO cliente (nombre, apellido, cedula, empresa_id, genero, tipo, foto, telefono, detalles) VALUES
	('Maria', 'González', '0987654321', 2, 'Femenino', 'distribuidor', 'foto_maria.jpg', '222-3333', 'Detalles Maria'),
	('Pedro', 'Rodríguez', '5678901234', 3, 'Masculino', 'minorista', 'foto_pedro.jpg', '777-8888', 'Detalles Pedro'),
	('Laura', 'Martínez', '1357902468', 4, 'Femenino', 'minorista', 'foto_laura.jpg', '444-5555', 'Detalles Laura'),
	('Carlos', 'López', '9876543210', 5, 'Masculino', 'distribuidor', 'foto_carlos.jpg', '111-2222', 'Detalles Carlos'),
	('Ana', 'Gómez', '2468013579', 1, 'Femenino', 'minorista', 'foto_ana.jpg', '888-9999', 'Detalles Ana');

-- Inserts para la tabla `cliente_direcciones`
INSERT INTO `cliente_direcciones` VALUES (1, 1);
INSERT INTO `cliente_direcciones` VALUES (2, 2);
INSERT INTO `cliente_direcciones` VALUES (3, 3);
INSERT INTO `cliente_direcciones` VALUES (4, 4), (5, 5), (6, 6), (7, 7), (8, 8);
-- Inserts para la tabla `permisos`
INSERT INTO `permisos` VALUES (1, 'Sí', 'Sí', 'Sí', 'Sí', 'Sí', 'Sí');
INSERT INTO `permisos` VALUES (2, 'No', 'Sí', 'No', 'Sí', 'No', 'No');
-- Inserts para la tabla `usuario`
INSERT INTO usuario (cedula, nombre, apellido, correo, pass, rol, genero, foto, telefono, detalles) VALUES ('123456789', 'Usuario A', 'Apellido A', 'usuarioA@correo.com', 'contraseñaA', 'SAdmin', 'Masculino', 'foto_usuarioA.jpg', '987-6543210', 'Detalles Usuario A');
INSERT INTO usuario (cedula, nombre, apellido, correo, pass, rol, genero, foto, telefono, detalles) VALUES ('987654321', 'Usuario B', 'Apellido B', 'usuarioB@correo.com', 'contraseñaB', 'Admin', 'Femenino', 'foto_usuarioB.jpg', '987-6543210', 'Detalles Usuario B');
INSERT INTO usuario (cedula, nombre, apellido, correo, pass, rol, genero, foto, telefono, detalles) VALUES ('456789012', 'Usuario C', 'Apellido C', 'usuarioC@correo.com', 'contraseñaC', 'Colaborador', 'Masculino', 'foto_usuarioC.jpg', '456-7890123', 'Detalles Usuario C');
-- Inserts para la tabla `admin`
INSERT INTO `admin` VALUES (1, 1, 1);
INSERT INTO `admin` VALUES (2, 2, 2);