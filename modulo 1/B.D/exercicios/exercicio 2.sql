-- Criando um banco de dados chamado "dbluis"
CREATE DATABASE dbluis;

-- Selecionando o banco de dados para uso
USE dbluis;

-- Criando a tabela "tbproduto" para armazenar informa��es sobre produtos
CREATE TABLE tbproduto (
    idProp INT PRIMARY KEY, -- Identificador �nico do produto (chave prim�ria)
    nomeProd CHAR(50) NOT NULL, -- Nome do produto (n�o pode ser nulo)
    Qtd INT, -- Quantidade do produto (pode ser nula)
    DataValidade DATE NOT NULL, -- Data de validade do produto (obrigat�ria)
    Pre�o DECIMAL(10,2) -- Pre�o do produto com 10 d�gitos no total e 2 casas decimais
);

-- Criando a tabela "tbcliente" para armazenar informa��es dos clientes
CREATE TABLE tbcliente (
    C�digo INT PRIMARY KEY, -- Identificador �nico do cliente (chave prim�ria)
    NomeCLi CHAR(50) NOT NULL, -- Nome do cliente (n�o pode ser nulo)
    DataNascimento DATE -- Data de nascimento do cliente (pode ser nula)
);
