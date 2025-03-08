-- Criando um banco de dados chamado "dbluis"
CREATE DATABASE dbluis;

-- Selecionando o banco de dados para uso
USE dbluis;

-- Criando a tabela "tbproduto" para armazenar informações sobre produtos
CREATE TABLE tbproduto (
    idProp INT PRIMARY KEY, -- Identificador único do produto (chave primária)
    nomeProd CHAR(50) NOT NULL, -- Nome do produto (não pode ser nulo)
    Qtd INT, -- Quantidade do produto (pode ser nula)
    DataValidade DATE NOT NULL, -- Data de validade do produto (obrigatória)
    Preço DECIMAL(10,2) -- Preço do produto com 10 dígitos no total e 2 casas decimais
);

-- Criando a tabela "tbcliente" para armazenar informações dos clientes
CREATE TABLE tbcliente (
    Código INT PRIMARY KEY, -- Identificador único do cliente (chave primária)
    NomeCLi CHAR(50) NOT NULL, -- Nome do cliente (não pode ser nulo)
    DataNascimento DATE -- Data de nascimento do cliente (pode ser nula)
);
