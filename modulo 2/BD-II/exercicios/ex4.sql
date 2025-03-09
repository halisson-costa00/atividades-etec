-- Criando o banco de dados chamado "dbmaria"
CREATE DATABASE dbmaria;

-- Selecionando o banco de dados para uso
USE dbmaria;

-- Criando a tabela "tbProdutos" para armazenar informações dos produtos
CREATE TABLE tbProdutos (
    idProd INT AUTO_INCREMENT PRIMARY KEY, -- Identificador único do produto com auto incremento
    nomeProd VARCHAR(50) NOT NULL, -- Nome do produto (não pode ser nulo)
    qtd INT DEFAULT 0, -- Quantidade do produto (valor padrão 0 para evitar NULL)
    dataValidade DATE NOT NULL, -- Data de validade do produto (obrigatória)
    preco DECIMAL(10,2) NOT NULL -- Preço do produto (obrigatório)
);

-- Adicionando a coluna "peso" à tabela, com até 10 dígitos e 2 casas decimais
ALTER TABLE tbProdutos ADD COLUMN peso DECIMAL(10,2) NOT NULL DEFAULT 0.00;

-- Adicionando a coluna "cor" à tabela (que será removida depois)
ALTER TABLE tbProdutos ADD COLUMN cor VARCHAR(50);

-- Adicionando a coluna "marca" (corrigido o erro de digitação "Maeca")
ALTER TABLE tbProdutos ADD COLUMN marca VARCHAR(50) NOT NULL;

-- Removendo a coluna "cor" da tabela
ALTER TABLE tbProdutos DROP COLUMN cor;

-- Removendo a coluna "dataValidade" da tabela
ALTER TABLE tbProdutos DROP COLUMN dataValidade;
