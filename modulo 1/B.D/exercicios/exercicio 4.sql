-- Criando o banco de dados chamado "dbmaria"
CREATE DATABASE dbmaria;

-- Selecionando o banco de dados para uso
USE dbmaria;

-- Criando a tabela "tbProdutos" para armazenar informa��es dos produtos
CREATE TABLE tbProdutos (
    idProd INT PRIMARY KEY NOT NULL, -- Identificador �nico do produto (chave prim�ria)
    nomeProd CHAR(50) NOT NULL, -- Nome do produto (n�o pode ser nulo)
    Qtd INT, -- Quantidade do produto (pode ser nula)
    DataValidade DATE NOT NULL, -- Data de validade do produto (obrigat�ria)
    Pre�o SMALLMONEY NOT NULL -- Pre�o do produto (obrigat�rio)
);

-- Adicionando a coluna "Peso" � tabela, com at� 10 d�gitos e 2 casas decimais
ALTER TABLE tbProdutos ADD Peso DECIMAL(10,2);

-- Adicionando a coluna "Cor" � tabela (que ser� removida depois)
ALTER TABLE tbProdutos ADD Cor CHAR(50);

-- Adicionando a coluna "Maeca" (provavelmente um erro de digita��o, deveria ser "Marca")
ALTER TABLE tbProdutos ADD Maeca CHAR(50) NOT NULL;

-- Removendo a coluna "Cor" da tabela
ALTER TABLE tbProdutos DROP COLUMN Cor;

-- Alterando a coluna "Peso" para que n�o aceite valores nulos
ALTER TABLE tbProdutos ALTER COLUMN Peso DECIMAL(10,2) NOT NULL;

-- Removendo a coluna "DataValidade" da tabela
ALTER TABLE tbProdutos DROP COLUMN DataValidade;
