-- Criando o banco de dados chamado "DbDeny"
CREATE DATABASE DbDeny;

-- Selecionando o banco de dados para uso
USE DbDeny;

-- Criando a tabela "tbVenda" para armazenar informações de vendas
CREATE TABLE tbVenda (
    Nf INT AUTO_INCREMENT PRIMARY KEY, -- Número da nota fiscal (chave primária, auto incremento)
    dataVenda TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP, -- Data da venda (data e hora atuais)
    preco DECIMAL(10,2) NOT NULL, -- Preço da venda (com duas casas decimais)
    qtd INT -- Quantidade vendida
);

-- Criando a tabela "tbProduto" para armazenar informações dos produtos
CREATE TABLE tbProduto (
    codigoB INT PRIMARY KEY NOT NULL, -- Código de barras do produto (chave primária)
    nomeProd VARCHAR(50) NOT NULL -- Nome do produto (não pode ser nulo)
);

-- Criando a chave estrangeira na tabela "tbVenda" para associar o produto vendido
ALTER TABLE tbVenda ADD COLUMN codigoB INT; -- Adiciona coluna de código de barras à tabela de vendas
ALTER TABLE tbVenda ADD FOREIGN KEY (codigoB) REFERENCES tbProduto(codigoB) ON DELETE CASCADE; -- Estabelece a chave estrangeira entre tbVenda e tbProduto
