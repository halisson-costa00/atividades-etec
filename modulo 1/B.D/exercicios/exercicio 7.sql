-- Criando o banco de dados "dbEscola"
CREATE DATABASE dbEscola;

-- Selecionando o banco de dados para uso
USE dbEscola;

-- Criando a tabela "tbCliente" para armazenar informações dos clientes
CREATE TABLE tbCliente (
    IdCli INT PRIMARY KEY NOT NULL, -- Identificador único do cliente (chave primária)
    NomeCliente CHAR(50) NOT NULL, -- Nome do cliente (obrigatório)
    NumEnd INT, -- Número do endereço do cliente (pode ser nulo)
    DataCadastro DATETIME DEFAULT CURRENT_TIMESTAMP -- Data de cadastro, preenchida automaticamente
);

-- Adicionando a coluna "CPF" na tabela "tbCliente" com restrição de unicidade
ALTER TABLE tbCliente ADD CPF BIGINT UNIQUE NOT NULL;

-- Adicionando a coluna "CEP" na tabela "tbCliente"
ALTER TABLE tbCliente ADD CEP INT;

-- Criando o banco de dados "dbEmpresa"
CREATE DATABASE dbEmpresa;

-- Voltando para o banco "dbEscola"
USE dbEscola;

-- Criando a tabela "tbEndereço" para armazenar os endereços
CREATE TABLE tbEndereco ( -- Corrigido o nome da tabela para evitar erros futuros
    CEP INT NOT NULL PRIMARY KEY, -- CEP como identificador único (chave primária)
    Logradouro CHAR(250) NOT NULL, -- Nome da rua, avenida, etc. (obrigatório)
    IdUF TINYINT -- Código do estado (pode ser nulo)
);

-- Criando a chave estrangeira ligando "tbCliente" à "tbEndereco" através do CEP
ALTER TABLE tbCliente ADD CONSTRAINT fk_CEP_tbCliente FOREIGN KEY (CEP) REFERENCES tbEndereco (CEP);

-- Renomeando a tabela "tbEndeço" para "tbEndereço" (corrigindo erro de digitação)
EXEC sp_rename 'tbEndeço', 'tbEndereco';

-- Exibindo a estrutura da tabela "tbCliente"
SP_HELP tbCliente;

-- Exibindo os bancos de dados disponíveis
SP_DATABASES;

-- Removendo o banco de dados "dbEmpresa" (CUIDADO: isso apagará todas as tabelas dentro dele)
DROP DATABASE dbEmpresa;
