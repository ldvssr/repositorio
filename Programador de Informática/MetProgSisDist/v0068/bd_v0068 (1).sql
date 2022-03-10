-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 10-Mar-2022 às 14:23
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
-- Banco de dados: `bd_v0068`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `t_artigo`
--

CREATE TABLE `t_artigo` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `cat` int(11) NOT NULL,
  `subcat` int(11) NOT NULL,
  `titulo` varchar(50) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `preco` float NOT NULL,
  `estado` int(11) NOT NULL,
  `foto1` varchar(50) NOT NULL,
  `foto2` varchar(50) NOT NULL,
  `foto3` varchar(50) NOT NULL,
  `vendido` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `t_categorias`
--

CREATE TABLE `t_categorias` (
  `id` int(11) NOT NULL,
  `categoria` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `t_categorias`
--

INSERT INTO `t_categorias` (`id`, `categoria`) VALUES
(1, 'Mulher'),
(2, 'Homem'),
(3, 'Criança'),
(4, 'Casa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `t_subcat`
--

CREATE TABLE `t_subcat` (
  `id` int(11) NOT NULL,
  `categoria` int(11) NOT NULL,
  `subcat` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `t_subcat`
--

INSERT INTO `t_subcat` (`id`, `categoria`, `subcat`) VALUES
(1, 1, 'Roupa'),
(2, 1, 'Sapatos'),
(3, 1, 'Malas'),
(4, 1, 'Acessórios'),
(5, 1, 'Beleza'),
(6, 2, 'Roupa'),
(7, 2, 'Sapatos'),
(8, 2, 'Acessórios'),
(9, 2, 'Cuidados Pessoais'),
(10, 3, 'Vestuário para rapariga'),
(11, 3, 'Vestuário para rapaz'),
(12, 3, 'Brinquedos e jogos'),
(13, 3, 'Cuidados de bebé'),
(14, 3, 'Carrinhos de bebé'),
(15, 3, 'Veículos de brincar'),
(16, 3, 'Assentos e cadeiras auto'),
(17, 3, 'Móveis'),
(18, 3, 'Material escolar'),
(19, 3, 'Outros'),
(20, 4, 'Têxteis'),
(21, 4, 'Acessórios para casa'),
(22, 4, 'Artigos de mesa'),
(23, 4, 'Livros');

-- --------------------------------------------------------

--
-- Estrutura da tabela `t_user`
--

CREATE TABLE `t_user` (
  `id` int(11) NOT NULL,
  `nick` varchar(20) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `data_nasc` varchar(10) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `foto` varchar(50) NOT NULL,
  `apagado` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `t_user`
--

INSERT INTO `t_user` (`id`, `nick`, `nome`, `email`, `data_nasc`, `senha`, `foto`, `apagado`) VALUES
(5, 'abc', 'abc', 'abc', '2022-02-28', '$2y$10$7Y1F8LVURPrgqPqD0Ob86uMKCXEihqguFOgcGekts6xcPcB7pp.Ga', 'bifes4.jpg', 0);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `t_artigo`
--
ALTER TABLE `t_artigo`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `t_categorias`
--
ALTER TABLE `t_categorias`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `t_subcat`
--
ALTER TABLE `t_subcat`
  ADD PRIMARY KEY (`id`);

--
-- Índices para tabela `t_user`
--
ALTER TABLE `t_user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `t_artigo`
--
ALTER TABLE `t_artigo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `t_categorias`
--
ALTER TABLE `t_categorias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `t_subcat`
--
ALTER TABLE `t_subcat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT de tabela `t_user`
--
ALTER TABLE `t_user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
