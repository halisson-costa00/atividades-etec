-- Criando o banco de dados chamado "dbmaria"
CREATE DATABASE dbmaria;

-- Selecionando o banco de dados para uso
USE dbmaria;

-- Criando a tabela "tbProdutos" para armazenar informações dos produtos
CREATE TABLE tbProdutos (
    idProd INT PRIMARY KEY NOT NULL, -- Identificador único do produto (chave primária)
    nomeProd CHAR(50) NOT NULL, -- Nome do produto (não pode ser nulo)
    Qtd INT, -- Quantidade do produto (pode ser nula)
    DataValidade DATE NOT NULL, -- Data de validade do produto (obrigatória)
    Preço SMALLMONEY NOT NULL -- Preço do produto (obrigatório)
);

-- Adicionando a coluna "Peso" à tabela, com até 10 dígitos e 2 casas decimais
ALTER TABLE tbProdutos ADD Peso DECIMAL(10,2);

-- Adicionando a coluna "Cor" à tabela (que será removida depois)
ALTER TABLE tbProdutos ADD Cor CHAR(50);

-- Adicionando a coluna "Maeca" (provavelmente um erro de digitação, deveria ser "Marca")
ALTER TABLE tbProdutos ADD Maeca CHAR(50) NOT NULL;

-- Removendo a coluna "Cor" da tabela
ALTER TABLE tbProdutos DROP COLUMN Cor;

-- Alterando a coluna "Peso" para que não aceite valores nulos
ALTER TABLE tbProdutos ALTER COLUMN Peso DECIMAL(10,2) NOT NULL;

-- Removendo a coluna "DataValidade" da tabela
ALTER TABLE tbProdutos DROP COLUMN DataValidade;
