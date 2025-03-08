-- Criando o banco de dados "dbDesenvolvimento"
CREATE DATABASE dbDesenvolvimento;

-- Selecionando o banco de dados para uso
USE dbDesenvolvimento;

-- Criando a tabela "tbProduto" para armazenar informa��es sobre produtos
CREATE TABLE tbProduto (
    idProp INT PRIMARY KEY NOT NULL, -- Identificador �nico do produto (chave prim�ria)
    NomeProd CHAR(50) NOT NULL, -- Nome do produto (obrigat�rio)
    Qtd INT, -- Quantidade dispon�vel (pode ser nula)
    DataValidade DATE NOT NULL, -- Data de validade do produto (obrigat�ria)
    Pre�o SMALLMONEY NOT NULL -- Pre�o do produto (obrigat�rio)
);

-- Adicionando a coluna "Peso" � tabela "tbProduto"
ALTER TABLE tbProduto ADD Peso DECIMAL(10,2);

-- Adicionando as colunas "Cor" e "Marca" � tabela "tbProduto"
ALTER TABLE tbProduto ADD Cor CHAR(50), Marca CHAR(50) NOT NULL;

-- Removendo a coluna "Cor" (pois foi adicionada anteriormente)
ALTER TABLE tbProduto DROP COLUMN Cor;

-- Alterando a coluna "Peso" para n�o aceitar valores nulos
ALTER TABLE tbProduto ALTER COLUMN Peso DECIMAL(10,2) NOT NULL;

-- Coment�rio sobre a remo��o da coluna "Cor"
-- /* Coluna "Cor" j� foi apagada anteriormente. */

-- Criando o banco de dados "dbLojaGrande"
CREATE DATABASE dbLojaGrande;

-- Erro na sintaxe: corrigido abaixo
-- ALTER TABLE tbProduto ADD Cor CHAR(50),

-- Criando o banco de dados "dbLogica"
CREATE DATABASE dbLogica;

-- Selecionando o banco de dados para uso
USE dbLogica;

-- Criando a tabela "tbCliente" para armazenar informa��es sobre clientes
CREATE TABLE tbCliente (
    NomeCli CHAR(50) NOT NULL, -- Nome do cliente (obrigat�rio)
    CodigoCli INT PRIMARY KEY, -- C�digo �nico do cliente (chave prim�ria)
    DataCadastro DATE NOT NULL -- Data de cadastro do cliente (obrigat�ria)
);

-- Selecionando o banco de dados para uso
USE dbLojaGrande;

-- Criando a tabela "tbFuncionarios" para armazenar informa��es sobre funcion�rios
CREATE TABLE tbFuncionarios (
    NomeFunc CHAR(50) NOT NULL, -- Nome do funcion�rio (obrigat�rio)
    CodigoFunc INT PRIMARY KEY, -- C�digo �nico do funcion�rio (chave prim�ria)
    DataCadastro DATETIME NOT NULL -- Data de cadastro do funcion�rio (obrigat�ria)
);

-- Voltando para o banco "dbLogica"
USE dbLogica;

-- Removendo o banco de dados "dbLojaGrande"
DROP DATABASE dbLojaGrande;

-- Voltando para o banco "dbLogica"
USE dbLogica;

-- Adicionando a coluna "CPF" na tabela "tbCliente" com restri��o de unicidade
ALTER TABLE tbCliente ADD CPF BIGINT NOT NULL UNIQUE;
