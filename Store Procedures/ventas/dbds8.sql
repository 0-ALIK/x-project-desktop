-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-12-2023 a las 15:05:21
-- Versión del servidor: 10.4.28-MariaDB
-- Versión de PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_ds8`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarInventario` (IN `producto_id_param` INT, IN `cantidad_param` INT)   BEGIN
    DECLARE cantidad_disponible INT;

    -- Obtener la cantidad disponible actual
    SELECT cantidad_cajas INTO cantidad_disponible
    FROM producto
    WHERE id_producto = producto_id_param;

    -- Verificar si hay suficientes productos disponibles
    IF cantidad_disponible >= cantidad_param THEN
        -- Actualizar la cantidad disponible restando la cantidad comprada
        UPDATE producto
        SET cantidad_cajas = cantidad_disponible - cantidad_param
        WHERE id_producto = producto_id_param;
    ELSE
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'No hay suficientes productos disponibles para la compra';
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_InsertarTicket` (IN `p_admin_id` INT, IN `p_categoria_id` INT, IN `p_prioridad_id` INT, IN `p_estado_id` INT, IN `p_descripcion` VARCHAR(255), IN `p_evidencia` VARCHAR(255), IN `p_fecha` DATETIME, IN `p_fecha_cambio_estado` DATETIME, OUT `p_resultado` INT)   BEGIN
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
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_LlenarDGVInventario` ()   BEGIN

    SELECT
        pr.nombre AS 'Producto', ca.nombre AS 'Categoria', ma.nombre AS 'Marca',
        pr.precio_unit AS 'Precio Unit', pr.cantidad_por_cajas AS 'Stock', pr.foto AS 'foto',
        CASE pr.punto_reorden
            WHEN 0 THEN 'No aplica'
            WHEN 1 THEN 'Aplica'
        END AS 'P.reorden'

    FROM
        producto AS pr
    JOIN categoria AS ca ON pr.categoria_id = ca.id_categoria
    JOIN marca AS ma ON pr.marca_id = ma.id_marca;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerCategorias` ()   BEGIN
	select  id_categoria, nombre from categoria;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerDetalleVenta` (IN `pedidoIdParam` INT)   BEGIN
    -- Variables para el detalle del pedido
    DECLARE IdPedido INT;
DECLARE IdCliente INT;
    DECLARE FechaPedido DATETIME;
    DECLARE NombreCliente VARCHAR(255);
    DECLARE CedulaCliente VARCHAR(255);
    DECLARE TelefonoCliente VARCHAR(255);
    DECLARE DetallesCliente VARCHAR(255);
    DECLARE NombreEmpresa VARCHAR(255);
    DECLARE RucEmpresa VARCHAR(255);
    DECLARE ProvinciaId INT;
    DECLARE TelefonoDireccion VARCHAR(255);
    DECLARE DetallesDireccion VARCHAR(255);
    DECLARE EstadoPedido VARCHAR(255); -- Agregada

    -- Variable para el importe total
    DECLARE importeTotal DECIMAL(10, 2);

    -- Obtener detalles del pedido
    -- Obtener detalles del pedido
SELECT
    p.id_pedido,
    p.fecha,
    c.nombre,
    c.cedula,
    c.telefono,
    c.detalles AS DetallesCliente,
    e.razon_social,
    e.ruc,
    d.provincia_id,
    d.telefono AS TelefonoDireccion,
    d.detalles AS DetallesDireccion,
    pe.estado AS EstadoPedido,
    c.id_cliente AS ClienteId -- Aquí está la corrección
INTO
    IdPedido,
    FechaPedido,
    NombreCliente,
    CedulaCliente,
    TelefonoCliente,
    DetallesCliente,
    NombreEmpresa,
    RucEmpresa,
    ProvinciaId,
    TelefonoDireccion,
    DetallesDireccion,
    EstadoPedido,
    IdCliente
FROM
    pedido p
INNER JOIN cliente c ON p.cliente_id = c.id_cliente
LEFT JOIN empresa e ON c.empresa_id = e.id_empresa
LEFT JOIN direccion d ON p.direccion_id = d.id_direccion
INNER JOIN pedido_estado pe ON p.estado_id = pe.id_pedido_estado
WHERE
    p.id_pedido = pedidoIdParam;



    -- Obtener el nombre de la provincia
    SELECT nombre INTO @NombreProvincia
    FROM provincia
    WHERE id_provincia = ProvinciaId;

    -- Obtener el importe total de la venta
    SELECT SUM(pp.cantidad * pr.precio_unit) INTO importeTotal
    FROM pedido_producto pp
    INNER JOIN producto pr ON pp.producto_id = pr.id_producto
    WHERE pp.pedido_id = pedidoIdParam;

    -- Devolver resultados
    SELECT
        IdPedido AS IdPedido,
        FechaPedido AS FechaPedido,
        NombreCliente AS NombreCliente,
        CedulaCliente AS CedulaCliente,
        TelefonoCliente AS TelefonoCliente,
        DetallesCliente AS DetallesCliente,
        NombreEmpresa AS NombreEmpresa,
        RucEmpresa AS RucEmpresa,
        @NombreProvincia AS NombreProvincia,
        TelefonoDireccion AS TelefonoDireccion,
        DetallesDireccion AS DetallesDireccion,
        EstadoPedido AS EstadoPedido, -- Agregada
        importeTotal AS ImporteTotal;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerMarcas` ()   BEGIN
    SELECT id_marca, nombre FROM marca;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerPedidos` ()   BEGIN
    SELECT 
        c.id_pedido AS IdPedido, 
        cli.nombre AS Cliente, 
        c.fecha AS FechaCompra, 
        pe.estado AS EstadoPedido, 
        e.razon_social AS Empresa,
        (pp.cantidad * p.precio_unit) AS ImporteVenta,
        COALESCE(SUM(pa.monto), 0) AS ImportePagado,
        ((pp.cantidad * p.precio_unit) - COALESCE(SUM(pa.monto), 0)) AS ImporteDebido
    FROM pedido c
    JOIN cliente cli ON c.cliente_id = cli.id_cliente
    JOIN pedido_estado pe ON c.estado_id = pe.id_pedido_estado
    JOIN cliente_direcciones cd ON c.cliente_id = cd.cliente_id
    JOIN direccion d ON cd.direccion_id = d.id_direccion
    JOIN empresa_direcciones ed ON d.id_direccion = ed.direccion_id
    JOIN empresa e ON ed.empresa_id = e.id_empresa
    JOIN pedido_producto pp ON c.id_pedido = pp.pedido_id
    JOIN producto p ON pp.producto_id = p.id_producto
    LEFT JOIN pago pa ON c.id_pedido = pa.pedido_id
    GROUP BY c.id_pedido, cli.nombre, c.fecha, pe.estado, e.razon_social, (pp.cantidad * p.precio_unit), p.cantidad_cajas;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerPedidosClientes` (IN `provincia_id_param` INT, IN `producto_id_param` INT)   BEGIN
    SELECT P.*, C.apellido AS cliente_apellido, D.*, PP.cantidad AS cantidad_producto
    FROM Pedido P
    JOIN Cliente C ON P.cliente_id = C.id_cliente
    JOIN Cliente_direcciones CD ON C.id_cliente = CD.cliente_id
    JOIN Direccion D ON CD.direccion_id = D.id_direccion
    LEFT JOIN Pedido_producto PP ON P.id_pedido = PP.pedido_id
    WHERE
        (provincia_id_param IS NULL OR D.provincia_id = provincia_id_param) AND
        (producto_id_param IS NULL OR PP.producto_id = producto_id_param);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ObtenerReporteInventario` (IN `marca_id_param` INT, IN `categoria_id_param` INT)   BEGIN
    SELECT p.*, m.nombre AS nombre_marca, c.nombre AS nombre_categoria
    FROM Producto p
    LEFT JOIN Marca m ON p.marca_id = m.id_marca
    LEFT JOIN Categoria c ON p.categoria_id = c.id_categoria
    WHERE
        (marca_id_param IS NULL OR p.marca_id = marca_id_param) AND
        (categoria_id_param IS NULL OR p.categoria_id = categoria_id_param);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_RealizarCompra` (IN `fecha_param` DATETIME, IN `cantidad_param` INT, IN `producto_param` INT, IN `cliente_param` INT, OUT `id_compra` INT)   BEGIN
    -- Insertar la compra en la tabla de pedidos
    INSERT INTO pedido (cliente_id, fecha, estado_id, detalles, direccion_id)
    VALUES (cliente_param, fecha_param, 1, 'En Proceso', (SELECT direccion_id FROM cliente_direcciones WHERE cliente_id = cliente_param LIMIT 1));

    -- Obtener el ID del pedido recién insertado
    SET id_compra = LAST_INSERT_ID();

    -- Insertar el producto en el pedido
    INSERT INTO pedido_producto (pedido_id, producto_id, cantidad)
    VALUES (id_compra, producto_param, cantidad_param);

    -- Actualizar el inventario
    CALL ActualizarInventario(producto_param, cantidad_param);

END$$

--
-- Funciones
--
CREATE DEFINER=`root`@`localhost` FUNCTION `CalcularImporteTotal` (`precioUnitario` DECIMAL(10,2), `cantidad` INT) RETURNS DECIMAL(10,2)  BEGIN
    DECLARE total DECIMAL(10,2);
    SET total = precioUnitario * cantidad;
    RETURN total;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `admin`
--

CREATE TABLE `admin` (
  `id_admin` int(11) NOT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `permisos_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE `categoria` (
  `id_categoria` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `categoria`
--

INSERT INTO `categoria` (`id_categoria`, `nombre`) VALUES
(3, 'Bebidas'),
(4, 'Calzado Deportivo'),
(5, 'Dispositivos Móviles'),
(2, 'Electrónicos'),
(6, 'Fast Food'),
(7, 'Refrescos'),
(1, 'Ropa Deportiva');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `apellido` varchar(255) DEFAULT NULL,
  `cedula` varchar(255) DEFAULT NULL,
  `empresa_id` int(11) DEFAULT NULL,
  `genero` varchar(255) DEFAULT NULL,
  `tipo` enum('minorisra','distribuidor') DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `telefono` varchar(255) DEFAULT NULL,
  `detalles` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nombre`, `apellido`, `cedula`, `empresa_id`, `genero`, `tipo`, `foto`, `telefono`, `detalles`) VALUES
(1, 'Juan', 'Pérez', '123456789', 1, 'Masculino', 'minorisra', 'foto1.jpg', '621234567', 'Detalles1'),
(2, 'María', 'Gómez', '234567890', 2, 'Femenino', 'distribuidor', 'foto2.jpg', '712345678', 'Detalles2'),
(3, 'Carlos', 'López', '345678901', 3, 'Masculino', 'minorisra', 'foto3.jpg', '823456789', 'Detalles3'),
(4, 'Ana', 'Martínez', '456789012', 4, 'Femenino', 'distribuidor', 'foto4.jpg', '934567890', 'Detalles4'),
(5, 'Luis', 'Hernández', '567890123', 5, 'Masculino', 'minorisra', 'foto5.jpg', '345678901', 'Detalles5'),
(6, 'Laura', 'Díaz', '678901234', 6, 'Femenino', 'distribuidor', 'foto6.jpg', '456789012', 'Detalles6'),
(7, 'Pedro', 'Romero', '789012345', 7, 'Masculino', 'minorisra', 'foto7.jpg', '567890123', 'Detalles7'),
(8, 'Sofía', 'Suárez', '890123456', 8, 'Femenino', 'distribuidor', 'foto8.jpg', '678901234', 'Detalles8'),
(9, 'Gabriel', 'Torres', '901234567', 9, 'Masculino', 'minorisra', 'foto9.jpg', '789012345', 'Detalles9'),
(10, 'Valeria', 'Ramírez', '012345678', 10, 'Femenino', 'distribuidor', 'foto10.jpg', '890123456', 'Detalles10'),
(11, 'Javier', 'González', '123450987', 11, 'Masculino', 'minorisra', 'foto11.jpg', '901234567', 'Detalles11'),
(12, 'Isabel', 'Sánchez', '234509876', 12, 'Femenino', 'distribuidor', 'foto12.jpg', '012345678', 'Detalles12'),
(13, 'Martín', 'Peralta', '345098765', 13, 'Masculino', 'minorisra', 'foto13.jpg', '123450987', 'Detalles13'),
(14, 'Lucía', 'Fernández', '456098754', 14, 'Femenino', 'distribuidor', 'foto14.jpg', '234509876', 'Detalles14'),
(15, 'Andrés', 'Ortega', '567098743', 15, 'Masculino', 'minorisra', 'foto15.jpg', '345098765', 'Detalles15');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente_direcciones`
--

CREATE TABLE `cliente_direcciones` (
  `cliente_id` int(11) NOT NULL,
  `direccion_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `cliente_direcciones`
--

INSERT INTO `cliente_direcciones` (`cliente_id`, `direccion_id`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE `compra` (
  `id_compra` int(11) NOT NULL,
  `admin_id` int(11) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `producto_id` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccion`
--

CREATE TABLE `direccion` (
  `id_direccion` int(11) NOT NULL,
  `provincia_id` int(11) DEFAULT NULL,
  `codigo_postal` varchar(255) DEFAULT NULL,
  `telefono` varchar(255) DEFAULT NULL,
  `detalles` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `direccion`
--

INSERT INTO `direccion` (`id_direccion`, `provincia_id`, `codigo_postal`, `telefono`, `detalles`) VALUES
(1, 1, '12345', '123456789', 'Dirección Empresa 1'),
(2, 2, '23456', '234567890', 'Dirección Empresa 2'),
(3, 3, '34567', '345678901', 'Dirección Empresa 3'),
(4, 4, '45678', '456789012', 'Dirección Empresa 4'),
(5, 5, '56789', '567890123', 'Dirección Empresa 5'),
(6, 6, '67890', '678901234', 'Dirección Empresa 6'),
(7, 7, '78901', '789012345', 'Dirección Empresa 7'),
(8, 8, '89012', '890123456', 'Dirección Empresa 8'),
(9, 9, '90123', '901234567', 'Dirección Empresa 9'),
(10, 10, '01234', '012345678', 'Dirección Empresa 10'),
(11, 11, '12345', '123456789', 'Dirección Empresa 11'),
(12, 12, '23456', '234567890', 'Dirección Empresa 12'),
(13, 13, '34567', '345678901', 'Dirección Empresa 13'),
(14, 14, '45678', '456789012', 'Dirección Empresa 14'),
(15, 15, '56789', '567890123', 'Dirección Empresa 15');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `id_empresa` int(11) NOT NULL,
  `ruc` varchar(255) DEFAULT NULL,
  `razon_social` varchar(255) DEFAULT NULL,
  `documento` varchar(255) DEFAULT NULL,
  `estado` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`id_empresa`, `ruc`, `razon_social`, `documento`, `estado`) VALUES
(1, '123456789', 'Delicias S.A.', 'RIF123', 'Activa'),
(2, '987654321', 'Sabores y Aromas C.A.', 'RIF987', 'Activa'),
(3, '234567890', 'Bebidas Refrescantes S.R.L.', 'RIF234', 'Activa'),
(4, '345678901', 'Gastronomía Exquisita Ltda.', 'RIF345', 'Activa'),
(5, '456789012', 'Cocina Creativa S.A.C.', 'RIF456', 'Activa'),
(6, '567890123', 'Comidas del Mundo E.I.R.L.', 'RIF567', 'Inactiva'),
(7, '678901234', 'Sabores del Mar C.A.', 'RIF678', 'Activa'),
(8, '789012345', 'Dulces Tentaciones S.A.', 'RIF789', 'Inactiva'),
(9, '890123456', 'Bebidas y Más C.A.', 'RIF890', 'Activa'),
(10, '901234567', 'Delicias Saludables S.R.L.', 'RIF901', 'Inactiva'),
(11, '012345678', 'Café Aromático Ltda.', 'RIF012', 'Activa'),
(12, '923456789', 'Sazón y Sabor E.I.R.L.', 'RIF123', 'Inactiva'),
(13, '234567899', 'Sabores Caseros S.A.C.', 'RIF234', 'Activa'),
(14, '345678909', 'Especias y Delicias C.A.', 'RIF345', 'Inactiva'),
(15, '456789019', 'Bocados Gourmet Ltda.', 'RIF456', 'Activa');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa_direcciones`
--

CREATE TABLE `empresa_direcciones` (
  `empresa_id` int(11) NOT NULL,
  `direccion_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empresa_direcciones`
--

INSERT INTO `empresa_direcciones` (`empresa_id`, `direccion_id`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10),
(11, 11),
(12, 12),
(13, 13),
(14, 14),
(15, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `forma_pago`
--

CREATE TABLE `forma_pago` (
  `id_forma_pago` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `forma_pago`
--

INSERT INTO `forma_pago` (`id_forma_pago`, `nombre`) VALUES
(1, 'Credito');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `id_marca` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `logo` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`id_marca`, `nombre`, `descripcion`, `logo`) VALUES
(1, 'Nike', 'Marca de ropa y calzado deportivo', 'nike_logo.jpg'),
(2, 'Samsung', 'Empresa de tecnología', 'samsung_logo.jpg'),
(3, 'Coca-Cola', 'Compañía de bebidas', 'cocacola_logo.jpg'),
(4, 'Adidas', 'Marca de ropa y calzado deportivo', 'adidas_logo.jpg'),
(5, 'Apple', 'Empresa de tecnología', 'apple_logo.jpg'),
(6, 'McDonald\'s', 'Cadena de comida rápida', 'mcdonalds_logo.jpg'),
(7, 'Pepsi', 'Compañía de bebidas', 'pepsi_logo.jpg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensaje`
--

CREATE TABLE `mensaje` (
  `id_estado` int(11) NOT NULL,
  `tickets_id` int(11) DEFAULT NULL,
  `mensaje` varchar(255) DEFAULT NULL,
  `fecha_envio` datetime DEFAULT NULL,
  `admin_id` int(11) DEFAULT NULL,
  `cliente_id` int(11) DEFAULT NULL,
  `remitente` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `notificacion`
--

CREATE TABLE `notificacion` (
  `id_notificacion` int(11) NOT NULL,
  `contenido` varchar(255) DEFAULT NULL,
  `titulo` varchar(255) DEFAULT NULL,
  `icono` varchar(255) DEFAULT NULL,
  `usuario_id` int(11) DEFAULT NULL,
  `ruta` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pago`
--

CREATE TABLE `pago` (
  `id_pago` int(11) NOT NULL,
  `pedido_id` int(11) DEFAULT NULL,
  `monto` double DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `forma_pago_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pago`
--

INSERT INTO `pago` (`id_pago`, `pedido_id`, `monto`, `fecha`, `forma_pago_id`) VALUES
(1, 2, 12, '2023-12-05 22:23:50', 1),
(2, 2, 2, '2023-12-05 22:24:30', 1),
(3, 2, 5, '2023-12-05 22:27:28', 1),
(4, 2, 2080, '2023-12-05 22:30:26', 1),
(5, 1, 4.99, '2023-12-05 22:32:23', 1),
(6, 3, 12, '2023-12-05 22:50:31', 1),
(7, 6, 2, '2023-12-05 22:55:43', 1),
(8, 5, 21, '2023-12-05 23:29:49', 1),
(9, 13, 5, '2023-12-06 00:05:40', 1),
(10, 4, 21, '2023-12-06 08:04:11', 1),
(11, 4, 10, '2023-12-06 08:04:29', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `id_pedido` int(11) NOT NULL,
  `cliente_id` int(11) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `estado_id` int(11) DEFAULT NULL,
  `fecha_cambio_estado` datetime DEFAULT NULL,
  `detalles` varchar(255) DEFAULT NULL,
  `direccion_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`id_pedido`, `cliente_id`, `fecha`, `estado_id`, `fecha_cambio_estado`, `detalles`, `direccion_id`) VALUES
(1, 7, '2023-12-05 02:12:07', 3, '2023-12-05 22:32:39', 'En Proceso', NULL),
(2, 4, '2023-12-05 02:17:44', 1, '2023-12-05 16:56:46', 'En Proceso', 4),
(3, 15, '2023-12-05 02:21:14', 1, NULL, 'En Proceso', 15),
(4, 15, '2023-12-05 02:23:03', 1, '2023-12-06 08:04:23', 'En Proceso', 15),
(5, 9, '2023-12-05 10:57:52', 2, NULL, 'En Proceso', 9),
(6, 7, '2023-12-05 11:26:33', 1, NULL, 'En Proceso', 7),
(7, 7, '2023-12-05 11:27:55', 1, NULL, 'En Proceso', 7),
(8, 1, '2023-12-05 18:06:18', 1, NULL, 'En Proceso', 1),
(9, 13, '2023-12-05 18:08:29', 1, NULL, 'En Proceso', 13),
(10, 1, '2023-12-05 19:42:26', 1, NULL, 'En Proceso', 1),
(11, 1, '2023-12-05 19:45:37', 1, '2023-12-05 19:49:25', 'En Proceso', 1),
(12, 10, '2023-12-05 21:13:05', 1, NULL, 'En Proceso', 10),
(13, 6, '2023-12-06 00:04:57', 3, '2023-12-06 00:05:50', 'En Proceso', 6),
(14, 1, '2023-12-06 08:03:38', 1, NULL, 'En Proceso', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_estado`
--

CREATE TABLE `pedido_estado` (
  `id_pedido_estado` int(11) NOT NULL,
  `estado` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedido_estado`
--

INSERT INTO `pedido_estado` (`id_pedido_estado`, `estado`) VALUES
(4, 'Cancelado'),
(3, 'Completado'),
(1, 'En Proceso'),
(2, 'Recibido');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_producto`
--

CREATE TABLE `pedido_producto` (
  `id_pedido_producto` int(11) NOT NULL,
  `pedido_id` int(11) DEFAULT NULL,
  `producto_id` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pedido_producto`
--

INSERT INTO `pedido_producto` (`id_pedido_producto`, `pedido_id`, `producto_id`, `cantidad`) VALUES
(1, 1, 6, 1),
(2, 2, 5, 3),
(3, 3, 2, 11),
(4, 4, 2, 11),
(5, 5, 1, 3),
(6, 6, 3, 2),
(7, 7, 7, 1),
(8, 8, 1, 1),
(9, 9, 2, 1),
(10, 10, 1, 1),
(11, 11, 1, 1),
(12, 12, 4, 2),
(13, 13, 6, 1),
(14, 14, 1, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permisos`
--

CREATE TABLE `permisos` (
  `id_permisos` int(11) NOT NULL,
  `gestiona_inventario` varchar(255) DEFAULT NULL,
  `gestiona_clientes` varchar(255) DEFAULT NULL,
  `gestiona_ventas` varchar(255) DEFAULT NULL,
  `gestiona_soporte` varchar(255) DEFAULT NULL,
  `gestiona_analitica` varchar(255) DEFAULT NULL,
  `gestiona_permisos` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `id_producto` int(11) NOT NULL,
  `marca_id` int(11) DEFAULT NULL,
  `categoria_id` int(11) DEFAULT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `precio_unit` decimal(10,2) DEFAULT NULL,
  `cantidad_por_cajas` int(11) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `punto_reorden` int(11) DEFAULT NULL,
  `cantidad_cajas` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto`, `marca_id`, `categoria_id`, `nombre`, `precio_unit`, `cantidad_por_cajas`, `foto`, `punto_reorden`, `cantidad_cajas`) VALUES
(1, 1, 1, 'Zapatillas Running', 99.99, 20, 'zapatillas_running.jpg', 5, 86),
(2, 2, 2, 'Smartphone Galaxy', 599.99, 10, 'samsung_galaxy.jpg', 10, 27),
(3, 3, 3, 'Coca-Cola Original', 1.99, 24, 'cocacola_original.jpg', 50, 198),
(4, 4, 1, 'Camiseta Deportiva', 29.99, 30, 'camiseta_deportiva.jpg', 15, 78),
(5, 5, 2, 'iPhone 13', 999.99, 5, 'iphone_13.jpg', 8, 27),
(6, 6, 6, 'Hamburguesa Big Mac', 4.99, 50, 'big_mac.jpg', 20, 148),
(7, 7, 3, 'Pepsi Cola', 1.49, 36, 'pepsi_cola.jpg', 30, 99);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provincia`
--

CREATE TABLE `provincia` (
  `id_provincia` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `provincia`
--

INSERT INTO `provincia` (`id_provincia`, `nombre`) VALUES
(1, 'Bocas del Toro'),
(4, 'Chiriquí'),
(2, 'Coclé'),
(3, 'Colón'),
(5, 'Darién'),
(11, 'Emberá Wounaan'),
(10, 'Guna Yala'),
(6, 'Herrera'),
(7, 'Los Santos'),
(14, 'Madugandí'),
(12, 'Ngäbe-Buglé'),
(8, 'Panamá'),
(13, 'Panamá Oeste'),
(9, 'Veraguas'),
(15, 'Wargandí');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets`
--

CREATE TABLE `tickets` (
  `id_tickets` int(11) NOT NULL,
  `admin_id` int(11) DEFAULT NULL,
  `categoria_id` int(11) DEFAULT NULL,
  `prioridad_id` int(11) DEFAULT NULL,
  `estado_id` int(11) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `evidencia` varchar(255) DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  `fecha_cambio_estado` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets_categoria`
--

CREATE TABLE `tickets_categoria` (
  `id_tickets_categoria` int(11) NOT NULL,
  `categoria` enum('PA','PF','PR','PRA','O') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets_estado`
--

CREATE TABLE `tickets_estado` (
  `id_tickets_estado` int(11) NOT NULL,
  `estado` enum('Espera','Revisado','Resuelto') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tickets_prioridad`
--

CREATE TABLE `tickets_prioridad` (
  `id_tickets_prioridad` int(11) NOT NULL,
  `prioridad` enum('1','2','3') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `nombre` varchar(255) DEFAULT NULL,
  `apellido` varchar(255) DEFAULT NULL,
  `cedula` varchar(255) DEFAULT NULL,
  `correo` varchar(255) DEFAULT NULL,
  `pass` varchar(255) DEFAULT NULL,
  `rol` enum('SAdmin','Admin','Colaborador') DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL,
  `telefono` varchar(255) DEFAULT NULL,
  `detalles` varchar(255) DEFAULT NULL,
  `genero` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id_usuario`, `nombre`, `apellido`, `cedula`, `correo`, `pass`, `rol`, `foto`, `telefono`, `detalles`, `genero`) VALUES
(1, 'Carlos', 'Gomez', '111223344', 'carlos.gomez@email.com', 'pass123', 'SAdmin', 'carlos_foto.jpg', '555-1234', 'Detalles de Carlos', 'Masculino'),
(2, 'Ana', 'Rodriguez', '222334455', 'ana.rodriguez@email.com', 'pass456', 'Colaborador', 'ana_foto.jpg', '555-5678', 'Detalles de Ana', 'Femenino'),
(3, 'Pablo', 'Diaz', '333445566', 'pablo.diaz@email.com', 'pass789', 'Colaborador', 'pablo_foto.jpg', '555-9876', 'Detalles de Pablo', 'Masculino'),
(4, 'Elena', 'Martinez', '444556677', 'elena.martinez@email.com', 'passabc', 'Colaborador', 'elena_foto.jpg', '555-4321', 'Detalles de Elena', 'Femenino'),
(5, 'Pedro', 'Lopez', '555667788', 'pedro.lopez@email.com', 'passxyz', 'Admin', 'pedro_foto.jpg', '555-8765', 'Detalles de Pedro', 'Masculino');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id_admin`),
  ADD KEY `usuario_id` (`usuario_id`),
  ADD KEY `permisos_id` (`permisos_id`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`id_categoria`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cedula` (`cedula`),
  ADD KEY `empresa_id` (`empresa_id`);

--
-- Indices de la tabla `cliente_direcciones`
--
ALTER TABLE `cliente_direcciones`
  ADD PRIMARY KEY (`cliente_id`,`direccion_id`),
  ADD KEY `direccion_id` (`direccion_id`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
  ADD PRIMARY KEY (`id_compra`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `producto_id` (`producto_id`);

--
-- Indices de la tabla `direccion`
--
ALTER TABLE `direccion`
  ADD PRIMARY KEY (`id_direccion`),
  ADD KEY `provincia_id` (`provincia_id`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`id_empresa`),
  ADD UNIQUE KEY `ruc` (`ruc`),
  ADD UNIQUE KEY `razon_social` (`razon_social`);

--
-- Indices de la tabla `empresa_direcciones`
--
ALTER TABLE `empresa_direcciones`
  ADD PRIMARY KEY (`empresa_id`,`direccion_id`),
  ADD KEY `direccion_id` (`direccion_id`);

--
-- Indices de la tabla `forma_pago`
--
ALTER TABLE `forma_pago`
  ADD PRIMARY KEY (`id_forma_pago`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`id_marca`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `mensaje`
--
ALTER TABLE `mensaje`
  ADD PRIMARY KEY (`id_estado`),
  ADD KEY `tickets_id` (`tickets_id`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `cliente_id` (`cliente_id`);

--
-- Indices de la tabla `notificacion`
--
ALTER TABLE `notificacion`
  ADD PRIMARY KEY (`id_notificacion`),
  ADD KEY `usuario_id` (`usuario_id`);

--
-- Indices de la tabla `pago`
--
ALTER TABLE `pago`
  ADD PRIMARY KEY (`id_pago`),
  ADD KEY `pedido_id` (`pedido_id`),
  ADD KEY `forma_pago_id` (`forma_pago_id`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido`),
  ADD KEY `cliente_id` (`cliente_id`),
  ADD KEY `estado_id` (`estado_id`),
  ADD KEY `direccion_id` (`direccion_id`);

--
-- Indices de la tabla `pedido_estado`
--
ALTER TABLE `pedido_estado`
  ADD PRIMARY KEY (`id_pedido_estado`),
  ADD UNIQUE KEY `estado` (`estado`);

--
-- Indices de la tabla `pedido_producto`
--
ALTER TABLE `pedido_producto`
  ADD PRIMARY KEY (`id_pedido_producto`),
  ADD KEY `pedido_id` (`pedido_id`),
  ADD KEY `producto_id` (`producto_id`);

--
-- Indices de la tabla `permisos`
--
ALTER TABLE `permisos`
  ADD PRIMARY KEY (`id_permisos`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `marca_id` (`marca_id`),
  ADD KEY `categoria_id` (`categoria_id`);

--
-- Indices de la tabla `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`id_provincia`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- Indices de la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD PRIMARY KEY (`id_tickets`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `categoria_id` (`categoria_id`),
  ADD KEY `prioridad_id` (`prioridad_id`),
  ADD KEY `estado_id` (`estado_id`);

--
-- Indices de la tabla `tickets_categoria`
--
ALTER TABLE `tickets_categoria`
  ADD PRIMARY KEY (`id_tickets_categoria`);

--
-- Indices de la tabla `tickets_estado`
--
ALTER TABLE `tickets_estado`
  ADD PRIMARY KEY (`id_tickets_estado`);

--
-- Indices de la tabla `tickets_prioridad`
--
ALTER TABLE `tickets_prioridad`
  ADD PRIMARY KEY (`id_tickets_prioridad`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `cedula` (`cedula`),
  ADD UNIQUE KEY `correo` (`correo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `admin`
--
ALTER TABLE `admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
  MODIFY `id_compra` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `direccion`
--
ALTER TABLE `direccion`
  MODIFY `id_direccion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id_empresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `forma_pago`
--
ALTER TABLE `forma_pago`
  MODIFY `id_forma_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `marca`
--
ALTER TABLE `marca`
  MODIFY `id_marca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `mensaje`
--
ALTER TABLE `mensaje`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `notificacion`
--
ALTER TABLE `notificacion`
  MODIFY `id_notificacion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pago`
--
ALTER TABLE `pago`
  MODIFY `id_pago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `pedido_estado`
--
ALTER TABLE `pedido_estado`
  MODIFY `id_pedido_estado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `pedido_producto`
--
ALTER TABLE `pedido_producto`
  MODIFY `id_pedido_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `permisos`
--
ALTER TABLE `permisos`
  MODIFY `id_permisos` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `provincia`
--
ALTER TABLE `provincia`
  MODIFY `id_provincia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de la tabla `tickets`
--
ALTER TABLE `tickets`
  MODIFY `id_tickets` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tickets_categoria`
--
ALTER TABLE `tickets_categoria`
  MODIFY `id_tickets_categoria` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tickets_estado`
--
ALTER TABLE `tickets_estado`
  MODIFY `id_tickets_estado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tickets_prioridad`
--
ALTER TABLE `tickets_prioridad`
  MODIFY `id_tickets_prioridad` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `admin_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id_usuario`),
  ADD CONSTRAINT `admin_ibfk_2` FOREIGN KEY (`permisos_id`) REFERENCES `permisos` (`id_permisos`);

--
-- Filtros para la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`empresa_id`) REFERENCES `empresa` (`id_empresa`);

--
-- Filtros para la tabla `cliente_direcciones`
--
ALTER TABLE `cliente_direcciones`
  ADD CONSTRAINT `cliente_direcciones_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `cliente_direcciones_ibfk_2` FOREIGN KEY (`direccion_id`) REFERENCES `direccion` (`id_direccion`);

--
-- Filtros para la tabla `compra`
--
ALTER TABLE `compra`
  ADD CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`id_admin`),
  ADD CONSTRAINT `compra_ibfk_2` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `direccion`
--
ALTER TABLE `direccion`
  ADD CONSTRAINT `direccion_ibfk_1` FOREIGN KEY (`provincia_id`) REFERENCES `provincia` (`id_provincia`);

--
-- Filtros para la tabla `empresa_direcciones`
--
ALTER TABLE `empresa_direcciones`
  ADD CONSTRAINT `empresa_direcciones_ibfk_1` FOREIGN KEY (`empresa_id`) REFERENCES `empresa` (`id_empresa`),
  ADD CONSTRAINT `empresa_direcciones_ibfk_2` FOREIGN KEY (`direccion_id`) REFERENCES `direccion` (`id_direccion`);

--
-- Filtros para la tabla `mensaje`
--
ALTER TABLE `mensaje`
  ADD CONSTRAINT `mensaje_ibfk_1` FOREIGN KEY (`tickets_id`) REFERENCES `tickets` (`id_tickets`),
  ADD CONSTRAINT `mensaje_ibfk_2` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`id_admin`),
  ADD CONSTRAINT `mensaje_ibfk_3` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`id_cliente`);

--
-- Filtros para la tabla `notificacion`
--
ALTER TABLE `notificacion`
  ADD CONSTRAINT `notificacion_ibfk_1` FOREIGN KEY (`usuario_id`) REFERENCES `usuario` (`id_usuario`);

--
-- Filtros para la tabla `pago`
--
ALTER TABLE `pago`
  ADD CONSTRAINT `pago_ibfk_1` FOREIGN KEY (`pedido_id`) REFERENCES `pedido` (`id_pedido`),
  ADD CONSTRAINT `pago_ibfk_2` FOREIGN KEY (`forma_pago_id`) REFERENCES `forma_pago` (`id_forma_pago`);

--
-- Filtros para la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `pedido_ibfk_2` FOREIGN KEY (`estado_id`) REFERENCES `pedido_estado` (`id_pedido_estado`),
  ADD CONSTRAINT `pedido_ibfk_3` FOREIGN KEY (`direccion_id`) REFERENCES `direccion` (`id_direccion`);

--
-- Filtros para la tabla `pedido_producto`
--
ALTER TABLE `pedido_producto`
  ADD CONSTRAINT `pedido_producto_ibfk_1` FOREIGN KEY (`pedido_id`) REFERENCES `pedido` (`id_pedido`),
  ADD CONSTRAINT `pedido_producto_ibfk_2` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`marca_id`) REFERENCES `marca` (`id_marca`),
  ADD CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`categoria_id`) REFERENCES `categoria` (`id_categoria`);

--
-- Filtros para la tabla `tickets`
--
ALTER TABLE `tickets`
  ADD CONSTRAINT `tickets_ibfk_1` FOREIGN KEY (`admin_id`) REFERENCES `admin` (`id_admin`),
  ADD CONSTRAINT `tickets_ibfk_2` FOREIGN KEY (`categoria_id`) REFERENCES `tickets_categoria` (`id_tickets_categoria`),
  ADD CONSTRAINT `tickets_ibfk_3` FOREIGN KEY (`prioridad_id`) REFERENCES `tickets_prioridad` (`id_tickets_prioridad`),
  ADD CONSTRAINT `tickets_ibfk_4` FOREIGN KEY (`estado_id`) REFERENCES `tickets_estado` (`id_tickets_estado`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
