-- Inserts para la tabla `provincia`
INSERT INTO `provincia` VALUES (1, 'Panamá');
INSERT INTO `provincia` VALUES (2, 'Colón');
INSERT INTO `provincia` VALUES (3, 'Chiriquí');

-- Inserts para la tabla `direccion`
INSERT INTO `direccion` VALUES (1, 1, '12345', '987-6543210', 'Detalles Dirección 1');
INSERT INTO `direccion` VALUES (2, 2, '54321', '123-4567890', 'Detalles Dirección 2');
INSERT INTO `direccion` VALUES (3, 3, '67890', '456-7890123', 'Detalles Dirección 3');

-- Inserts para la tabla `empresa`
INSERT INTO `empresa` VALUES (1, '123456789', 'Empresa A', 'correo@empresaA.com', 'Razón Social A', '123ABC', 'foto_empresaA.jpg', '123-4567890', 'Detalles Empresa A');
INSERT INTO `empresa` VALUES (2, '987654321', 'Empresa B', 'correo@empresaB.com', 'Razón Social B', '456DEF', 'foto_empresaB.jpg', '987-6543210', 'Detalles Empresa B');
INSERT INTO `empresa` VALUES (3, '456789012', 'Empresa C', 'correo@empresaC.com', 'Razón Social C', '789GHI', 'foto_empresaC.jpg', '456-7890123', 'Detalles Empresa C');

-- Inserts para la tabla `empresa_direcciones`
INSERT INTO `empresa_direcciones` VALUES (1, 1);
INSERT INTO `empresa_direcciones` VALUES (2, 2);
INSERT INTO `empresa_direcciones` VALUES (3, 3);

-- Inserts para la tabla `cliente`
INSERT INTO `cliente` VALUES (1, 'Cliente A', 'Apellido A', '123456789', 1, 'Masculino', 'foto_clienteA.jpg', '123-4567890', 'Detalles Cliente A', 'minorista');
INSERT INTO `cliente` VALUES (2, 'Cliente B', 'Apellido B', '987654321', 2, 'Femenino', 'foto_clienteB.jpg', '987-6543210', 'Detalles Cliente B', 'distribuidor');
INSERT INTO `cliente` VALUES (3, 'Cliente C', 'Apellido C', '456789012', 3, 'Masculino', 'foto_clienteC.jpg', '456-7890123', 'Detalles Cliente C', 'minorista');

-- Inserts para la tabla `cliente_direcciones`
INSERT INTO `cliente_direcciones` VALUES (1, 1);
INSERT INTO `cliente_direcciones` VALUES (2, 2);
INSERT INTO `cliente_direcciones` VALUES (3, 3);




-- Inserts para la tabla `permisos`
INSERT INTO `permisos` VALUES (1, 'Sí', 'Sí', 'Sí', 'Sí', 'Sí', 'Sí');
INSERT INTO `permisos` VALUES (2, 'No', 'Sí', 'No', 'Sí', 'No', 'No');


-- Inserts para la tabla `usuario`
INSERT INTO `usuario` VALUES (1, '123456789', 'Usuario A', 'Apellido A', 'usuarioA@correo.com', 'contraseñaA', 'SAdmin', 'Masculino', 'foto_usuarioA.jpg', '987-6543210', 'Detalles Usuario A');
INSERT INTO `usuario` VALUES (2, '987654321', 'Usuario B', 'Apellido B', 'usuarioB@correo.com', 'contraseñaB', 'Admin', 'Femenino', 'foto_usuarioB.jpg', '987-6543210', 'Detalles Usuario B');
INSERT INTO `usuario` VALUES (3, '456789012', 'Usuario C', 'Apellido C', 'usuarioC@correo.com', 'contraseñaC', 'Colaborador', 'Masculino', 'foto_usuarioC.jpg', '456-7890123', 'Detalles Usuario C');

-- Inserts para la tabla `admin`
INSERT INTO `admin` VALUES (1, 1, 1);
INSERT INTO `admin` VALUES (2, 2, 2);

