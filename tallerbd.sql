-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 22-11-2023 a las 19:53:38
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
-- Base de datos: `tallerbd`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `id_Clientes` int(11) NOT NULL,
  `Nomb_Cli` varchar(255) NOT NULL,
  `Ape_Cli` varchar(255) NOT NULL,
  `Dni_Cli` int(11) NOT NULL,
  `Sexo_Cli` varchar(255) NOT NULL,
  `FechaNac_Cli` date NOT NULL,
  `Tel_Cli` int(11) NOT NULL,
  `Direcc_Cli` varchar(255) NOT NULL,
  `Estado_Cli` varchar(255) NOT NULL,
  `FechaReg_Cli` date NOT NULL,
  `HoraReg_Cli` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`id_Clientes`, `Nomb_Cli`, `Ape_Cli`, `Dni_Cli`, `Sexo_Cli`, `FechaNac_Cli`, `Tel_Cli`, `Direcc_Cli`, `Estado_Cli`, `FechaReg_Cli`, `HoraReg_Cli`) VALUES
(1, 'Josue', 'Rodriguez', 123, 'Masculino', '2023-11-03', 222222, 'sdsdsd', 'Activo', '2023-11-09', '00:00:00'),
(3, 'Javier', 'Gonzalez', 1233, 'Masculino', '2002-03-07', 123, '123', 'Activo', '2023-11-20', '00:00:00'),
(6, 'ddadsa', 'ddffd', 2223, 'Femenino', '2001-03-14', 2223, 'ddd', 'Activo', '2023-11-20', '17:17:45'),
(8, 'dfdee', 'dfdee', 22232, 'Femenino', '2000-11-20', 22, 'dfd', 'Activo', '2023-11-20', '18:02:48');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id_Usuario` int(11) NOT NULL,
  `Usuario` varchar(255) NOT NULL,
  `Contrasenia` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_Usuario`, `Usuario`, `Contrasenia`) VALUES
(1, 'Admin', '123');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`id_Clientes`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_Usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `clientes`
--
ALTER TABLE `clientes`
  MODIFY `id_Clientes` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_Usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
