-- Selecionando o banco de dados "dbEscola"
USE dbEscola;

-- Criando a tabela "tbEstado" (antes chamada "tBest") para armazenar estados
CREATE TABLE tbEstado (
    idUf TINYINT PRIMARY KEY, -- Identificador único do estado (chave primária)
    NomeUf CHAR(2) NOT NULL, -- Sigla do estado (exemplo: SP, RJ)
    NomeEstado CHAR(40) NOT NULL -- Nome completo do estado
);

-- Criando a chave estrangeira na tabela "tbEndereço" para referenciar "tbEstado"
ALTER TABLE tbEndereco ADD CONSTRAINT fk_idUfs_tbEndereco FOREIGN KEY (idUF) REFERENCES tbEstado (idUf);

-- Renomeando a tabela "tBest" para "tbEstado" (caso já exista com esse nome errado)
EXEC sp_rename 'tBest', 'tbEstado';

-- Renomeando a coluna "NomeUfs" para "NomeUf" dentro da tabela "tbEstado"
EXEC sp_rename 'tbEstado.NomeUfs', 'NomeUf', 'COLUMN';

-- Criando a tabela "tbCidade" para armazenar cidades
CREATE TABLE tbCidade (
    idCid INT PRIMARY KEY, -- Identificador único da cidade (chave primária)
    NomeCidade CHAR(50) NOT NULL -- Nome da cidade (obrigatório)
);

-- Adicionando a coluna "idCid" na tabela "tbEndereco" para associá-la a uma cidade
ALTER TABLE tbEndereco ADD idCid INT;

-- Alterando a coluna "NomeCidade" da tabela "tbCidade" para aceitar 250 caracteres
ALTER TABLE tbCidade ALTER COLUMN NomeCidade CHAR(250);

-- Criando a chave estrangeira na tabela "tbEndereco" para referenciar "tbCidade"
ALTER TABLE tbEndereco ADD CONSTRAINT fk_idCid_tbEndereco FOREIGN KEY (idCid) REFERENCES tbCidade (idCid);

-- Selecionando todos os registros da tabela "tbCidade"
SELECT * FROM tbCidade;
