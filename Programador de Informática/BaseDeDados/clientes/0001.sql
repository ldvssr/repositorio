-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 07-Jan-2022 às 19:59
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
-- Banco de dados: `0001`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `t_cliente`
--

CREATE TABLE `t_cliente` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `morada` varchar(100) NOT NULL,
  `zona` varchar(30) NOT NULL DEFAULT 'VN Gaia',
  `nif` varchar(9) NOT NULL,
  `vol_fatur` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `t_cliente`
--

INSERT INTO `t_cliente` (`id`, `nome`, `morada`, `zona`, `nif`, `vol_fatur`) VALUES
(1, 'Rui Monteiro', 'Rua ABC 123', 'Porto', '220164099', 10000),
(2, 'Carlos Azevedo', 'R. Xyz, 456', 'Maia', '225415584', 150000),
(3, 'Paulo Borges', 'R Def, 789', 'Maia', '254125415', 16000),
(5, 'Aurora Joaquina', 'R. da fontinha 23', 'Porto', '222222211', 50),
(6, 'Fernando Costa', 'Ruas das estrelas 123', 'Rio Tinto', '123123123', 25000),
(10, 'Alberta Joaquina II', 'Rua Torta 1', 'Venda das Raparigas', '582349176', 8460);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `t_cliente`
--
ALTER TABLE `t_cliente`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `t_cliente`
--
ALTER TABLE `t_cliente`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
