-- Criando o banco de dados "dbBanco"
CREATE DATABASE dbBanco;

-- Selecionando o banco de dados para uso
USE dbBanco;

-- Criando a tabela "tbBanco" para armazenar informações dos bancos
CREATE TABLE tbBanco (
    Codigo INT PRIMARY KEY, -- Identificador único do banco (chave primária)
    Nome VARCHAR(50) NOT NULL -- Nome do banco (obrigatório)
);

-- Criando a tabela "tbAgencia" para armazenar informações das agências
CREATE TABLE tbAgencia (
    CodBanco INT, -- Código do banco ao qual a agência pertence
    NumeroAgencia INT PRIMARY KEY, -- Número único da agência (chave primária)
    Endereco VARCHAR(50) NOT NULL, -- Endereço da agência (obrigatório)
    CONSTRAINT fk_CodBanco FOREIGN KEY (CodBanco) REFERENCES tbBanco(Codigo) -- Chave estrangeira referenciando tbBanco
);

-- Criando a tabela "tbTelefone" para armazenar números de telefone de clientes
CREATE TABLE tbTelefone (
    Cpf BIGINT, -- CPF do cliente
    Telefone INT PRIMARY KEY, -- Número de telefone (chave primária)
    CONSTRAINT fk_Telefone_Cpf FOREIGN KEY (Cpf) REFERENCES tbCliente(Cpf) -- Chave estrangeira referenciando tbCliente
);

-- Criando a tabela "tbCliente" para armazenar informações dos clientes
CREATE TABLE tbCliente (
    Cpf BIGINT PRIMARY KEY, -- Identificador único do cliente (chave primária)
    Nome VARCHAR(50) NOT NULL, -- Nome do cliente (obrigatório)
    Sexo CHAR(1) NOT NULL, -- Sexo do cliente ('M' ou 'F') (obrigatório)
    Endereco VARCHAR(50) NOT NULL -- Endereço do cliente (obrigatório)
);

-- Adicionando a coluna "Email" na tabela "tbCliente"
ALTER TABLE tbCliente ADD Email VARCHAR(50);

-- Criando a tabela "tbConta" para armazenar contas bancárias
CREATE TABLE tbConta (
    NumeroConta INT PRIMARY KEY, -- Número único da conta (chave primária)
    Saldo DECIMAL(7,2), -- Saldo da conta
    TipoConta SMALLINT, -- Tipo da conta (exemplo: 1 para corrente, 2 para poupança)
    NumeroAgencia INT, -- Número da agência vinculada
    CONSTRAINT fk_NumeroAgencia FOREIGN KEY (NumeroAgencia) REFERENCES tbAgencia(NumeroAgencia) -- Chave estrangeira referenciando tbAgencia
);

-- Criando a tabela "tbHistorico" para armazenar histórico de transações
CREATE TABLE tbHistorico (
    Cpf BIGINT, -- CPF do cliente
    NumeroConta INT, -- Número da conta do cliente
    DataInicio DATE, -- Data da operação
    CONSTRAINT fk_Historico_Cpf FOREIGN KEY (Cpf) REFERENCES tbCliente(Cpf), -- Chave estrangeira referenciando tbCliente
    CONSTRAINT fk_Historico_Conta FOREIGN KEY (NumeroConta) REFERENCES tbConta(NumeroConta) -- Chave estrangeira referenciando tbConta
);

-- Inserindo dados na tabela "tbBanco"
INSERT INTO tbBanco VALUES 
(1, 'Banco do Brasil'),
(104, 'Caixa Economica'),
(801, 'Banco Escola');

-- Selecionando todos os registros da tabela "tbBanco"
SELECT * FROM tbBanco;

-- Inserindo dados na tabela "tbAgencia"
INSERT INTO tbAgencia VALUES 
(1, 123, 'Av Paulista, 78'),
(104, 159, 'Rua Liberdade, 124'),
(801, 401, 'Rua Vinte e Três, 23'),
(801, 485, 'Av Marechal, 68');

-- Selecionando todos os registros da tabela "tbAgencia"
SELECT * FROM tbAgencia;

-- Inserindo dados na tabela "tbCliente"
INSERT INTO tbCliente (Cpf, Nome, Sexo, Endereco) VALUES 
(12345678910, 'Enildo', 'M', 'Rua Grande, 75'),
(12345678911, 'Astrogildo', 'M', 'Rua Pequena, 789'),
(12345678912, 'Monica', 'F', 'Rua Larga, 148'),
(12345678913, 'Cascão', 'M', 'Rua Principal, 369');

-- Selecionando todos os registros da tabela "tbCliente"
SELECT * FROM tbCliente;

-- Inserindo dados na tabela "tbConta"
INSERT INTO tbConta (NumeroConta, Saldo, TipoConta, NumeroAgencia) VALUES 
(9876, 456.05, 1, 123),
(9877, 321.00, 1, 123),
(9878, 100.00, 2, 485),
(9879, 5589.48, 1, 401);

-- Selecionando clientes com nome "Monica"
SELECT Cpf, Endereco FROM tbCliente
WHERE Nome = 'Monica';

-- Selecionando agências do banco 801
SELECT NumeroAgencia, Endereco FROM tbAgencia
WHERE CodBanco = 801;

-- Consulta alternativa usando INNER JOIN para recuperar todas as agências do banco 801
SELECT tbAgencia.NumeroAgencia, tbAgencia.Endereco 
FROM tbAgencia
INNER JOIN tbBanco ON tbBanco.Codigo = tbAgencia.CodBanco 
WHERE tbBanco.Codigo = 801;

-- Recuperando todos os clientes do sexo masculino
SELECT * FROM tbCliente
WHERE Sexo = 'M';
