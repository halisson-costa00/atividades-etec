-- Criando o banco de dados chamado "dbcomércio"
CREATE DATABASE dbcomercio; -- Removido o acento para evitar problemas de compatibilidade

-- Selecionando o banco de dados para uso
USE dbcomercio;

-- Criando a tabela "tbcliente" para armazenar informações dos clientes
CREATE TABLE tbcliente (
    id INT PRIMARY KEY, -- Identificador único do cliente (chave primária)
    NomeCliente CHAR(200) NOT NULL, -- Nome do cliente (não pode ser nulo)
    NumEnd INT NOT NULL, -- Número do endereço do cliente (obrigatório)
    CompEnd CHAR(50) -- Complemento do endereço (pode ser nulo)
);

-- Criando a tabela "tbclientePf" para armazenar informações de clientes pessoa física
CREATE TABLE tbclientePf (
    cpf BIGINT PRIMARY KEY, -- CPF do cliente como chave primária
    RG INT, -- Número do RG do cliente
    RgDig TINYINT, -- Dígito verificador do RG (pode ser armazenado como CHAR(1) se necessário)
    Nascimento DATE NOT NULL -- Data de nascimento do cliente (obrigatória)
);
