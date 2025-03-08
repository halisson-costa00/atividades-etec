-- Criando o banco de dados "dbEscola"
CREATE DATABASE dbEscola;

-- Selecionando o banco de dados para uso
USE dbEscola;

-- Criando a tabela "tbCliente" para armazenar informa��es dos clientes
CREATE TABLE tbCliente (
    IdCli INT PRIMARY KEY NOT NULL, -- Identificador �nico do cliente (chave prim�ria)
    NomeCliente CHAR(50) NOT NULL, -- Nome do cliente (obrigat�rio)
    NumEnd INT, -- N�mero do endere�o do cliente (pode ser nulo)
    DataCadastro DATETIME DEFAULT CURRENT_TIMESTAMP -- Data de cadastro, preenchida automaticamente
);

-- Adicionando a coluna "CPF" na tabela "tbCliente" com restri��o de unicidade
ALTER TABLE tbCliente ADD CPF BIGINT UNIQUE NOT NULL;

-- Adicionando a coluna "CEP" na tabela "tbCliente"
ALTER TABLE tbCliente ADD CEP INT;

-- Criando o banco de dados "dbEmpresa"
CREATE DATABASE dbEmpresa;

-- Voltando para o banco "dbEscola"
USE dbEscola;

-- Criando a tabela "tbEndere�o" para armazenar os endere�os
CREATE TABLE tbEndereco ( -- Corrigido o nome da tabela para evitar erros futuros
    CEP INT NOT NULL PRIMARY KEY, -- CEP como identificador �nico (chave prim�ria)
    Logradouro CHAR(250) NOT NULL, -- Nome da rua, avenida, etc. (obrigat�rio)
    IdUF TINYINT -- C�digo do estado (pode ser nulo)
);

-- Criando a chave estrangeira ligando "tbCliente" � "tbEndereco" atrav�s do CEP
ALTER TABLE tbCliente ADD CONSTRAINT fk_CEP_tbCliente FOREIGN KEY (CEP) REFERENCES tbEndereco (CEP);

-- Renomeando a tabela "tbEnde�o" para "tbEndere�o" (corrigindo erro de digita��o)
EXEC sp_rename 'tbEnde�o', 'tbEndereco';

-- Exibindo a estrutura da tabela "tbCliente"
SP_HELP tbCliente;

-- Exibindo os bancos de dados dispon�veis
SP_DATABASES;

-- Removendo o banco de dados "dbEmpresa" (CUIDADO: isso apagar� todas as tabelas dentro dele)
DROP DATABASE dbEmpresa;
