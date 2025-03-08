-- Criando o banco de dados "dbDesenvolvimento"
CREATE DATABASE dbDesenvolvimento;

-- Selecionando o banco de dados para uso
USE dbDesenvolvimento;

-- Criando a tabela "tbProduto" para armazenar informações sobre produtos
CREATE TABLE tbProduto (
    idProp INT PRIMARY KEY NOT NULL, -- Identificador único do produto (chave primária)
    NomeProd CHAR(50) NOT NULL, -- Nome do produto (obrigatório)
    Qtd INT, -- Quantidade disponível (pode ser nula)
    DataValidade DATE NOT NULL, -- Data de validade do produto (obrigatória)
    Preço SMALLMONEY NOT NULL -- Preço do produto (obrigatório)
);

-- Adicionando a coluna "Peso" à tabela "tbProduto"
ALTER TABLE tbProduto ADD Peso DECIMAL(10,2);

-- Adicionando as colunas "Cor" e "Marca" à tabela "tbProduto"
ALTER TABLE tbProduto ADD Cor CHAR(50), Marca CHAR(50) NOT NULL;

-- Removendo a coluna "Cor" (pois foi adicionada anteriormente)
ALTER TABLE tbProduto DROP COLUMN Cor;

-- Alterando a coluna "Peso" para não aceitar valores nulos
ALTER TABLE tbProduto ALTER COLUMN Peso DECIMAL(10,2) NOT NULL;

-- Comentário sobre a remoção da coluna "Cor"
-- /* Coluna "Cor" já foi apagada anteriormente. */

-- Criando o banco de dados "dbLojaGrande"
CREATE DATABASE dbLojaGrande;

-- Erro na sintaxe: corrigido abaixo
-- ALTER TABLE tbProduto ADD Cor CHAR(50),

-- Criando o banco de dados "dbLogica"
CREATE DATABASE dbLogica;

-- Selecionando o banco de dados para uso
USE dbLogica;

-- Criando a tabela "tbCliente" para armazenar informações sobre clientes
CREATE TABLE tbCliente (
    NomeCli CHAR(50) NOT NULL, -- Nome do cliente (obrigatório)
    CodigoCli INT PRIMARY KEY, -- Código único do cliente (chave primária)
    DataCadastro DATE NOT NULL -- Data de cadastro do cliente (obrigatória)
);

-- Selecionando o banco de dados para uso
USE dbLojaGrande;

-- Criando a tabela "tbFuncionarios" para armazenar informações sobre funcionários
CREATE TABLE tbFuncionarios (
    NomeFunc CHAR(50) NOT NULL, -- Nome do funcionário (obrigatório)
    CodigoFunc INT PRIMARY KEY, -- Código único do funcionário (chave primária)
    DataCadastro DATETIME NOT NULL -- Data de cadastro do funcionário (obrigatória)
);

-- Voltando para o banco "dbLogica"
USE dbLogica;

-- Removendo o banco de dados "dbLojaGrande"
DROP DATABASE dbLojaGrande;

-- Voltando para o banco "dbLogica"
USE dbLogica;

-- Adicionando a coluna "CPF" na tabela "tbCliente" com restrição de unicidade
ALTER TABLE tbCliente ADD CPF BIGINT NOT NULL UNIQUE;
