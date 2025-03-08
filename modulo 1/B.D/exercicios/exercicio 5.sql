-- Criando o banco de dados chamado "DbDeny"
CREATE DATABASE DbDeny;

-- Selecionando o banco de dados para uso
USE DbDeny;

-- Criando a tabela "tbVenda" para armazenar informa��es de vendas
CREATE TABLE tbVenda (
    Nf INT PRIMARY KEY IDENTITY (1,1), -- N�mero da nota fiscal (chave prim�ria, autoincremento)
    DataValidade DATETIME NOT NULL -- Data de validade da venda (provavelmente um erro, veja observa��o abaixo)
);

-- Adicionando a coluna "Pre�o" � tabela "tbVenda"
ALTER TABLE tbVenda ADD Pre�o SMALLMONEY NOT NULL;

-- Adicionando a coluna "Qtd" para armazenar a quantidade vendida
ALTER TABLE tbVenda ADD Qtd INT;

-- Removendo a coluna "DataValidade" da tabela "tbVenda" (provavelmente n�o faz sentido em vendas)
ALTER TABLE tbVenda DROP COLUMN DataValidade;

-- Adicionando a coluna "DataVenda" com tipo TIMESTAMP (veja observa��o abaixo)
ALTER TABLE tbVenda ADD DataVenda TIMESTAMP NOT NULL;

-- Criando a tabela "tbProduto" para armazenar informa��es dos produtos
CREATE TABLE tbProduto (
    codigoB INT PRIMARY KEY NOT NULL, -- C�digo de barras do produto (chave prim�ria)
    NomeProd CHAR(50) NOT NULL -- Nome do produto (n�o pode ser nulo)
);

-- Tentativa incorreta de adicionar chave estrangeira (erro corrigido abaixo)
-- ALTER TABLE tbProduto ADD FOREIGN KEY (codigoB) REFERENCES tbProduto (codigoB);
