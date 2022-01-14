-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 14-Jan-2022 às 17:37
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `biblioteca`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `manuais`
--

CREATE TABLE `manuais` (
  `id` int(11) NOT NULL,
  `titulo` varchar(40) NOT NULL,
  `numpag` varchar(11) DEFAULT '0',
  `textdescr` mediumtext DEFAULT NULL,
  `pesokb` varchar(6) NOT NULL DEFAULT '0',
  `autor` varchar(20) DEFAULT 'Desconhecido'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `manuais`
--

INSERT INTO `manuais` (`id`, `titulo`, `numpag`, `textdescr`, `pesokb`, `autor`) VALUES
(1, 'Organização estruturada de computadores', '626', 'Título original: Structured computer organization. 6 ed.', '29,1MB', 'Tanenbaum, Andrew S.'),
(2, 'Arquitetura de Computadores', '144', '3ª edição Fortaleza - Ceará', '5,97MB', 'Marcial Porto Fernan');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `manuais`
--
ALTER TABLE `manuais`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `manuais`
--
ALTER TABLE `manuais`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
