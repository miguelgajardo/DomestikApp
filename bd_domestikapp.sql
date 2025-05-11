-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-05-2025 a las 23:44:49
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_domestikapp`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_pasajeros`
--

CREATE TABLE `tbl_pasajeros` (
  `rut` varchar(10) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido` varchar(20) NOT NULL,
  `tipo` varchar(10) NOT NULL,
  `puntaje` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_pasajeros`
--

INSERT INTO `tbl_pasajeros` (`rut`, `nombre`, `apellido`, `tipo`, `puntaje`) VALUES
('171112223', 'MG', 'MGDOS', 'Normal', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_reservas`
--

CREATE TABLE `tbl_reservas` (
  `codigo` varchar(10) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `valor` double NOT NULL,
  `numvlo` varchar(10) NOT NULL,
  `rut` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_reservas`
--

INSERT INTO `tbl_reservas` (`codigo`, `tipo`, `valor`, `numvlo`, `rut`) VALUES
('black', 'Economica', 35500, 'seis', '171112223');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbl_vuelos`
--

CREATE TABLE `tbl_vuelos` (
  `numvlo` varchar(10) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `destino` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tbl_vuelos`
--

INSERT INTO `tbl_vuelos` (`numvlo`, `fecha`, `hora`, `destino`) VALUES
('dos', '0000-00-00', '16:03:58', ''),
('seis', '2025-05-11', '16:23:00', ''),
('tres', '2025-05-22', '16:05:15', ''),
('uno', '0000-00-00', '16:00:57', 'uno');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbl_pasajeros`
--
ALTER TABLE `tbl_pasajeros`
  ADD PRIMARY KEY (`rut`(9));

--
-- Indices de la tabla `tbl_reservas`
--
ALTER TABLE `tbl_reservas`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `numvlo` (`numvlo`);

--
-- Indices de la tabla `tbl_vuelos`
--
ALTER TABLE `tbl_vuelos`
  ADD PRIMARY KEY (`numvlo`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tbl_reservas`
--
ALTER TABLE `tbl_reservas`
  ADD CONSTRAINT `tbl_reservas_ibfk_1` FOREIGN KEY (`numvlo`) REFERENCES `tbl_vuelos` (`numvlo`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
