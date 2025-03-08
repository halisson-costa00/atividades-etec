-- Criando o banco de dados chamado "DbDeny"
CREATE DATABASE DbDeny;

-- Selecionando o banco de dados para uso
USE DbDeny;

-- Criando a tabela "tbVenda" para armazenar informações de vendas
CREATE TABLE tbVenda (
    Nf INT PRIMARY KEY IDENTITY (1,1), -- Número da nota fiscal (chave primária, autoincremento)
    DataValidade DATETIME NOT NULL -- Data de validade da venda (provavelmente um erro, veja observação abaixo)
);

-- Adicionando a coluna "Preço" à tabela "tbVenda"
ALTER TABLE tbVenda ADD Preço SMALLMONEY NOT NULL;

-- Adicionando a coluna "Qtd" para armazenar a quantidade vendida
ALTER TABLE tbVenda ADD Qtd INT;

-- Removendo a coluna "DataValidade" da tabela "tbVenda" (provavelmente não faz sentido em vendas)
ALTER TABLE tbVenda DROP COLUMN DataValidade;

-- Adicionando a coluna "DataVenda" com tipo TIMESTAMP (veja observação abaixo)
ALTER TABLE tbVenda ADD DataVenda TIMESTAMP NOT NULL;

-- Criando a tabela "tbProduto" para armazenar informações dos produtos
CREATE TABLE tbProduto (
    codigoB INT PRIMARY KEY NOT NULL, -- Código de barras do produto (chave primária)
    NomeProd CHAR(50) NOT NULL -- Nome do produto (não pode ser nulo)
);

-- Tentativa incorreta de adicionar chave estrangeira (erro corrigido abaixo)
-- ALTER TABLE tbProduto ADD FOREIGN KEY (codigoB) REFERENCES tbProduto (codigoB);
