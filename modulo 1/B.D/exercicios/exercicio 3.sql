-- Criando o banco de dados chamado "dbcom�rcio"
CREATE DATABASE dbcomercio; -- Removido o acento para evitar problemas de compatibilidade

-- Selecionando o banco de dados para uso
USE dbcomercio;

-- Criando a tabela "tbcliente" para armazenar informa��es dos clientes
CREATE TABLE tbcliente (
    id INT PRIMARY KEY, -- Identificador �nico do cliente (chave prim�ria)
    NomeCliente CHAR(200) NOT NULL, -- Nome do cliente (n�o pode ser nulo)
    NumEnd INT NOT NULL, -- N�mero do endere�o do cliente (obrigat�rio)
    CompEnd CHAR(50) -- Complemento do endere�o (pode ser nulo)
);

-- Criando a tabela "tbclientePf" para armazenar informa��es de clientes pessoa f�sica
CREATE TABLE tbclientePf (
    cpf BIGINT PRIMARY KEY, -- CPF do cliente como chave prim�ria
    RG INT, -- N�mero do RG do cliente
    RgDig TINYINT, -- D�gito verificador do RG (pode ser armazenado como CHAR(1) se necess�rio)
    Nascimento DATE NOT NULL -- Data de nascimento do cliente (obrigat�ria)
);
