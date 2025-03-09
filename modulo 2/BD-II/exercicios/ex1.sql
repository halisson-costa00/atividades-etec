-- Criação do banco de dados chamado dbhalisson
CREATE DATABASE IF NOT EXISTS dbhalisson;
USE dbhalisson;

-- Criação da tabela tbusuario
CREATE TABLE IF NOT EXISTS tbusuario (
    clienteID INT AUTO_INCREMENT PRIMARY KEY,  -- Gera IDs automaticamente
    nomeusuario VARCHAR(45) NOT NULL,          -- Usa VARCHAR para melhor eficiência
    datanascimento DATE                        -- Corrige erro de digitação
);

-- Criação da tabela tbestado
CREATE TABLE IF NOT EXISTS tbestado (
    id_estado INT AUTO_INCREMENT PRIMARY KEY,  -- Renomeado para melhor entendimento
    uf CHAR(2) NOT NULL UNIQUE                 -- Define UNIQUE para evitar duplicatas
);

-- Criação da tabela tbclientes
CREATE TABLE IF NOT EXISTS tbclientes (
    codigocliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(58) NOT NULL,   -- Modificado conforme alteração posterior
    endereco VARCHAR(60) NOT NULL
);

-- Criação da tabela tbprodutos
CREATE TABLE IF NOT EXISTS tbprodutos (
    barras CHAR(13) PRIMARY KEY,   -- Código de barras geralmente tem tamanho fixo
    valor DECIMAL(10,4) NOT NULL,
    descricao TEXT NOT NULL,
    qtd INT DEFAULT 0              -- Adiciona a coluna quantidade com valor padrão 0
);

-- Exibe as informações da tabela tbprodutos
DESCRIBE tbprodutos;

-- Exibe o nome das tabelas no banco de dados
SHOW TABLES;

-- Exibe a lista de bancos de dados disponíveis
SHOW DATABASES;

-- Altera a tabela tbclientes para modificar o tamanho da coluna nome
ALTER TABLE tbclientes MODIFY nome VARCHAR(58);

-- Exclui a tabela tbestado se existir
DROP TABLE IF EXISTS tbestado;

-- Remove a coluna datanascimento da tabela tbusuario, se existir
ALTER TABLE tbusuario DROP COLUMN datanascimento;
