-- Criando o banco de dados "dbBanco"
CREATE DATABASE dbBanco;

-- Selecionando o banco de dados para uso
USE dbBanco;

-- Criando a tabela "tbBanco" para armazenar informa��es dos bancos
CREATE TABLE tbBanco (
    Codigo INT PRIMARY KEY, -- Identificador �nico do banco (chave prim�ria)
    Nome VARCHAR(50) NOT NULL -- Nome do banco (obrigat�rio)
);

-- Criando a tabela "tbAgencia" para armazenar informa��es das ag�ncias
CREATE TABLE tbAgencia (
    CodBanco INT, -- C�digo do banco ao qual a ag�ncia pertence
    NumeroAgencia INT PRIMARY KEY, -- N�mero �nico da ag�ncia (chave prim�ria)
    Endereco VARCHAR(50) NOT NULL, -- Endere�o da ag�ncia (obrigat�rio)
    CONSTRAINT fk_CodBanco FOREIGN KEY (CodBanco) REFERENCES tbBanco(Codigo) -- Chave estrangeira referenciando tbBanco
);

-- Criando a tabela "tbTelefone" para armazenar n�meros de telefone de clientes
CREATE TABLE tbTelefone (
    Cpf BIGINT, -- CPF do cliente
    Telefone INT PRIMARY KEY, -- N�mero de telefone (chave prim�ria)
    CONSTRAINT fk_Telefone_Cpf FOREIGN KEY (Cpf) REFERENCES tbCliente(Cpf) -- Chave estrangeira referenciando tbCliente
);

-- Criando a tabela "tbCliente" para armazenar informa��es dos clientes
CREATE TABLE tbCliente (
    Cpf BIGINT PRIMARY KEY, -- Identificador �nico do cliente (chave prim�ria)
    Nome VARCHAR(50) NOT NULL, -- Nome do cliente (obrigat�rio)
    Sexo CHAR(1) NOT NULL, -- Sexo do cliente ('M' ou 'F') (obrigat�rio)
    Endereco VARCHAR(50) NOT NULL -- Endere�o do cliente (obrigat�rio)
);

-- Adicionando a coluna "Email" na tabela "tbCliente"
ALTER TABLE tbCliente ADD Email VARCHAR(50);

-- Criando a tabela "tbConta" para armazenar contas banc�rias
CREATE TABLE tbConta (
    NumeroConta INT PRIMARY KEY, -- N�mero �nico da conta (chave prim�ria)
    Saldo DECIMAL(7,2), -- Saldo da conta
    TipoConta SMALLINT, -- Tipo da conta (exemplo: 1 para corrente, 2 para poupan�a)
    NumeroAgencia INT, -- N�mero da ag�ncia vinculada
    CONSTRAINT fk_NumeroAgencia FOREIGN KEY (NumeroAgencia) REFERENCES tbAgencia(NumeroAgencia) -- Chave estrangeira referenciando tbAgencia
);

-- Criando a tabela "tbHistorico" para armazenar hist�rico de transa��es
CREATE TABLE tbHistorico (
    Cpf BIGINT, -- CPF do cliente
    NumeroConta INT, -- N�mero da conta do cliente
    DataInicio DATE, -- Data da opera��o
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
(801, 401, 'Rua Vinte e Tr�s, 23'),
(801, 485, 'Av Marechal, 68');

-- Selecionando todos os registros da tabela "tbAgencia"
SELECT * FROM tbAgencia;

-- Inserindo dados na tabela "tbCliente"
INSERT INTO tbCliente (Cpf, Nome, Sexo, Endereco) VALUES 
(12345678910, 'Enildo', 'M', 'Rua Grande, 75'),
(12345678911, 'Astrogildo', 'M', 'Rua Pequena, 789'),
(12345678912, 'Monica', 'F', 'Rua Larga, 148'),
(12345678913, 'Casc�o', 'M', 'Rua Principal, 369');

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

-- Selecionando ag�ncias do banco 801
SELECT NumeroAgencia, Endereco FROM tbAgencia
WHERE CodBanco = 801;

-- Consulta alternativa usando INNER JOIN para recuperar todas as ag�ncias do banco 801
SELECT tbAgencia.NumeroAgencia, tbAgencia.Endereco 
FROM tbAgencia
INNER JOIN tbBanco ON tbBanco.Codigo = tbAgencia.CodBanco 
WHERE tbBanco.Codigo = 801;

-- Recuperando todos os clientes do sexo masculino
SELECT * FROM tbCliente
WHERE Sexo = 'M';
