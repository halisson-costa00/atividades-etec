-- Criando o banco de dados chamado "dbcomercio"
CREATE DATABASE dbcomercio; 

-- Selecionando o banco de dados para uso
USE dbcomercio;

-- Criando a tabela "tbcliente" para armazenar informações dos clientes
CREATE TABLE tbcliente (
    id INT AUTO_INCREMENT PRIMARY KEY, -- Identificador único do cliente com auto incremento
    nomeCliente VARCHAR(200) NOT NULL, -- Nome do cliente (não pode ser nulo)
    numEnd INT NOT NULL, -- Número do endereço do cliente (obrigatório)
    compEnd VARCHAR(50) -- Complemento do endereço (pode ser nulo)
);

-- Criando a tabela "tbclientePf" para armazenar informações de clientes pessoa física
CREATE TABLE tbclientePf (
    cpf BIGINT PRIMARY KEY, -- CPF do cliente como chave primária
    rg VARCHAR(15), -- Número do RG do cliente (permite diferentes formatos)
    rgDig CHAR(1), -- Dígito verificador do RG
    nascimento DATE NOT NULL, -- Data de nascimento do cliente (obrigatória)
    idCliente INT NOT NULL, -- Chave estrangeira para referenciar tbcliente
    FOREIGN KEY (idCliente) REFERENCES tbcliente(id) ON DELETE CASCADE
);
