-- Criação do banco de dados dbDistribuidora
CREATE DATABASE dbDistribuidora;

-- Seleciona o banco de dados dbDistribuidora para que as operações sejam feitas nesse banco
USE dbDistribuidora;

-- Criação da tabela tbCliente_pf (Pessoa Física) para armazenar dados de clientes PF
CREATE TABLE tbCliente_pf (
    Cpf CHAR(11) PRIMARY KEY,    -- CPF como chave primária
    Rg CHAR(9) NOT NULL,         -- RG do cliente, não pode ser nulo
    Rg_Dig CHAR(1) NOT NULL,     -- Dígito do RG, não pode ser nulo
    NAscim DATE NOT NULL,        -- Data de nascimento, não pode ser nula
    Id INT                         -- ID de identificação adicional
);

-- Criação da tabela tbCliente_pj (Pessoa Jurídica) para armazenar dados de clientes PJ
CREATE TABLE tbCliente_pj (
    Cnpj CHAR(14) PRIMARY KEY,   -- CNPJ como chave primária
    Ie CHAR(11),                 -- Inscrição Estadual
    Id INT                        -- ID de identificação adicional
);

-- Criação da tabela tbBairro para armazenar informações de bairros
CREATE TABLE tbBairro (
    BairroId INT PRIMARY KEY,    -- ID do bairro como chave primária
    Bairro VARCHAR(200) NOT NULL -- Nome do bairro, não pode ser nulo
);

-- Criação da tabela tbCidade para armazenar informações de cidades
CREATE TABLE tbCidade (
    CidadeId INT PRIMARY KEY,    -- ID da cidade como chave primária
    Cidade VARCHAR(200) NOT NULL -- Nome da cidade, não pode ser nulo
);

-- Criação da tabela tbEstado para armazenar informações de estados
CREATE TABLE tbEstado (
    UfId INT PRIMARY KEY,        -- ID do estado como chave primária
    Uf CHAR(2) NOT NULL           -- Sigla do estado, não pode ser nulo
);

-- Criação da tabela tbEndereco para armazenar dados de endereços
CREATE TABLE tbEndereco (
    Logradouro VARCHAR(200) NOT NULL,  -- Logradouro do endereço, não pode ser nulo
    Cep CHAR(8) PRIMARY KEY,           -- CEP como chave primária
    BairroId INT,                      -- Relaciona com a tabela tbBairro
    CidadeId INT,                      -- Relaciona com a tabela tbCidade
    UfId INT,                          -- Relaciona com a tabela tbEstado
    FOREIGN KEY (BairroId) REFERENCES tbBairro(BairroId),
    FOREIGN KEY (CidadeId) REFERENCES tbCidade(CidadeId),
    FOREIGN KEY (UfId) REFERENCES tbEstado(UfId)
);

-- Criação da tabela tbCliente para armazenar dados dos clientes com endereço
CREATE TABLE tbCliente (
    Id INT PRIMARY KEY,               -- ID do cliente como chave primária
    NomeCli VARCHAR(200) NOT NULL,     -- Nome do cliente, não pode ser nulo
    NumEnd CHAR(6) NOT NULL,           -- Número do endereço, não pode ser nulo
    CompEnd VARCHAR(50),               -- Complemento do endereço
    CepCli CHAR(8),                    -- Relaciona o cliente com o endereço via CEP
    FOREIGN KEY (CepCli) REFERENCES tbEndereco(Cep)
);

-- Criação da tabela tbNota_fiscal para armazenar dados de notas fiscais
CREATE TABLE tbNota_fiscal (
    Nf INT PRIMARY KEY,               -- Número da nota fiscal como chave primária
    TotalNota DECIMAL(8,2) NOT NULL,  -- Total da nota fiscal, não pode ser nulo
    DataEmissao DATE NOT NULL         -- Data de emissão da nota fiscal, não pode ser nula
);

-- Criação da tabela tbVenda para armazenar dados das vendas
CREATE TABLE tbVenda (
    NumeroVenda INT PRIMARY KEY,      -- Número da venda como chave primária
    DataVenda DATE NOT NULL,          -- Data da venda, não pode ser nula
    TotalVenda DECIMAL(8,2) NOT NULL, -- Total da venda, não pode ser nula
    ID_Cli INT,                       -- Relaciona a venda com o cliente
    Nf INT,                           -- Relaciona a venda com a nota fiscal
    FOREIGN KEY (ID_Cli) REFERENCES tbCliente(Id),
    FOREIGN KEY (Nf) REFERENCES tbNota_fiscal(Nf)
);

-- Criação da tabela tbFornecedor para armazenar dados dos fornecedores
CREATE TABLE tbFornecedor (
    Codigo INT PRIMARY KEY,           -- Código do fornecedor como chave primária
    Cnpj CHAR(14),                    -- CNPJ do fornecedor
    Nome VARCHAR(200) NOT NULL,       -- Nome do fornecedor, não pode ser nulo
    telefone CHAR(11)                 -- Telefone do fornecedor
);

-- Criação da tabela tbCompra para armazenar dados de compras
CREATE TABLE tbCompra (
    NotaFiscal INT PRIMARY KEY,       -- Número da nota fiscal de compra como chave primária
    DataCompra DATE NOT NULL,         -- Data da compra, não pode ser nula
    ValorTotal DECIMAL(8,2) NOT NULL, -- Valor total da compra, não pode ser nulo
    QtdTotal INT NOT NULL,            -- Quantidade total de itens na compra
    Codigo INT,                       -- Relaciona com o fornecedor
    FOREIGN KEY (Codigo) REFERENCES tbFornecedor(Codigo)
);

-- Criação da tabela tbProduto para armazenar dados dos produtos
CREATE TABLE tbProduto (
    CodigoBarras CHAR(14) PRIMARY KEY, -- Código de barras como chave primária
    Nome VARCHAR(200) NOT NULL,        -- Nome do produto, não pode ser nulo
    Valor DECIMAL(8,2) NOT NULL,       -- Valor do produto, não pode ser nulo
    Qtd INT                            -- Quantidade disponível do produto
);

-- Criação da tabela tbItemCompra para armazenar os itens das compras
CREATE TABLE tbItemCompra (
    NotaFiscal INT,                   -- Relaciona com a tabela tbCompra
    CodigoBarras CHAR(14),             -- Relaciona com a tabela tbProduto
    ValorItem DECIMAL(8,2) NOT NULL,   -- Valor do item na compra, não pode ser nulo
    Qtd INT NOT NULL,                  -- Quantidade do item na compra
    PRIMARY KEY (NotaFiscal, CodigoBarras),
    FOREIGN KEY (NotaFiscal) REFERENCES tbCompra(NotaFiscal),
    FOREIGN KEY (CodigoBarras) REFERENCES tbProduto(CodigoBarras)
);

-- Criação da tabela tbItemVenda para armazenar os itens das vendas
CREATE TABLE tbItemVenda (
    NumeroVenda INT,                  -- Relaciona com a tabela tbVenda
    CodigoBarras CHAR(14),             -- Relaciona com a tabela tbProduto
    ValorItem DECIMAL(8,2) NOT NULL,   -- Valor do item na venda, não pode ser nulo
    Qtd INT NOT NULL,                  -- Quantidade do item na venda
    FOREIGN KEY (NumeroVenda) REFERENCES tbVenda(NumeroVenda),
    FOREIGN KEY (CodigoBarras) REFERENCES tbProduto(CodigoBarras)
);

-- Consulta para listar todas as tabelas no banco de dados
SELECT table_name FROM INFORMATION_SCHEMA.TABLES;
