-- Criando um banco de dados chamado "dbluis"
CREATE DATABASE dbluis;

-- Selecionando o banco de dados para uso
USE dbluis;

-- Criando a tabela "tbproduto" para armazenar informações sobre produtos
CREATE TABLE tbproduto (
    idProduto INT AUTO_INCREMENT PRIMARY KEY, -- Chave primária com auto incremento
    nomeProduto VARCHAR(50) NOT NULL,         -- Nome do produto (não pode ser nulo)
    quantidade INT DEFAULT 0,                 -- Quantidade do produto (valor padrão 0 para evitar NULL)
    dataValidade DATE NOT NULL,               -- Data de validade do produto (obrigatória)
    preco DECIMAL(10,2) NOT NULL              -- Preço do produto com 2 casas decimais
);

-- Criando a tabela "tbcliente" para armazenar informações dos clientes
CREATE TABLE tbcliente (
    idCliente INT AUTO_INCREMENT PRIMARY KEY, -- Chave primária com auto incremento
    nomeCliente VARCHAR(50) NOT NULL,         -- Nome do cliente (não pode ser nulo)
    dataNascimento DATE                       -- Data de nascimento do cliente (pode ser nula)
);
