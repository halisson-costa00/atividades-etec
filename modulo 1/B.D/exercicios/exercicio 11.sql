-- Criação do banco de dados dbDistribuidora
create database dbDistribuidora;

-- Seleciona o banco de dados dbDistribuidora para que as operações sejam feitas nesse banco
use dbDistribuidora;

-- Criação da tabela tbCliente_pf (Pessoa Física) para armazenar dados de clientes PF
create table tbCliente_pf (
    Cpf decimal (11,0) primary key,   -- CPF como chave primária
    Rg decimal (9,0) not null,         -- RG do cliente, não pode ser nulo
    Rg_Dig char(1) not null,           -- Dígito do RG, não pode ser nulo
    NAscim date not null,              -- Data de nascimento, não pode ser nula
    Id int                             -- ID de identificação adicional
);

-- Criação da tabela tbCliente_pj (Pessoa Jurídica) para armazenar dados de clientes PJ
create table tbCliente_pj (
    Cnpj decimal (14,0) primary key,   -- CNPJ como chave primária
    Ie decimal (11,0),                 -- Inscrição Estadual
    Id int                             -- ID de identificação adicional
);

-- Criação da tabela tbBairro para armazenar informações de bairros
create table tbBairro (
    BairroId int primary key,          -- ID do bairro como chave primária
    Bairro varchar(200) not null       -- Nome do bairro, não pode ser nulo
);

-- Criação da tabela tbCidade para armazenar informações de cidades
create table tbCidade (
    CidadeId int primary key,          -- ID da cidade como chave primária
    Cidade varchar(200) not null       -- Nome da cidade, não pode ser nulo
);

-- Criação da tabela tbEstado para armazenar informações de estados
create table tbEstado (
    UfId int primary key,              -- ID do estado como chave primária
    Uf char (2) not null               -- Sigla do estado, não pode ser nulo
);

-- Criação da tabela tbEndereco para armazenar dados de endereços
create table tbEndereco (
    Logradouro varchar (200) not null, -- Logradouro do endereço, não pode ser nulo
    Cep decimal (8,0) primary key,     -- CEP como chave primária
    BairroId int foreign key references tbBairro(BairroId), -- Relaciona com a tabela tbBairro
    CIdadeId int foreign key references tbCidade( CidadeId), -- Relaciona com a tabela tbCidade
    UfId int foreign key references tbEstado (UfId)  -- Relaciona com a tabela tbEstado
);

-- Criação da tabela tbCliente para armazenar dados dos clientes com endereço
create table tbCliente (
    Id int primary key,                -- ID do cliente como chave primária
    NomeCli varchar (200) not null,    -- Nome do cliente, não pode ser nulo
    NumEnd decimal (6,0) not null,     -- Número do endereço, não pode ser nulo
    CompEnd varchar (50),              -- Complemento do endereço
    CepCli decimal (8,0) foreign key references tbEndereco (Cep)  -- Relaciona o cliente com o endereço via CEP
);

-- Criação da tabela tbNota_fiscal para armazenar dados de notas fiscais
create table tbNota_fiscal (
    Nf int primary key,                -- Número da nota fiscal como chave primária
    TotalNota decimal (8,2) not null,  -- Total da nota fiscal, não pode ser nulo
    DataEmissao date not null          -- Data de emissão da nota fiscal, não pode ser nula
);

-- Criação da tabela tbVenda para armazenar dados das vendas
create table tbVenda (
    NumeroVenda int primary key,       -- Número da venda como chave primária
    DataVenda date not null,           -- Data da venda, não pode ser nula
    TotalVenda decimal (8,2) not null, -- Total da venda, não pode ser nula
    ID_Cli int foreign key references tbCliente(Id), -- Relaciona a venda com o cliente
    Nf int foreign key references tbNota_fiscal (NF)  -- Relaciona a venda com a nota fiscal
);

-- Criação da tabela tbFornecedor para armazenar dados dos fornecedores
create table tbFornecedor (
    Codigo int primary key,            -- Código do fornecedor como chave primária
    Cnpj decimal (14,0),               -- CNPJ do fornecedor
    Nome varchar (200) not null,       -- Nome do fornecedor, não pode ser nulo
    telefone decimal (11,0)            -- Telefone do fornecedor
);

-- Criação da tabela tbCompra para armazenar dados de compras
create table tbCompra (
    NotaFiscal int primary key,        -- Número da nota fiscal de compra como chave primária
    DataCompra date not null,          -- Data da compra, não pode ser nula
    ValorTotal decimal (8,2) not null, -- Valor total da compra, não pode ser nulo
    QtdTotal int not null,             -- Quantidade total de itens na compra
    Codigo int foreign key references tbFornecedor (Codigo) -- Relaciona com o fornecedor
);

-- Criação da tabela tbProduto para armazenar dados dos produtos
create table tbProduto (
    CodigoBarras decimal (14,0) primary key, -- Código de barras como chave primária
    Nome varchar (200) not null,             -- Nome do produto, não pode ser nulo
    Valor decimal (8,2) not null,            -- Valor do produto, não pode ser nulo
    Qtd int                                  -- Quantidade disponível do produto
);

-- Consulta para listar todas as tabelas no banco de dados
select table_name from INFORMATION_SCHEMA.TABLES; 

-- Criação da tabela tbItemCompra para armazenar os itens das compras
create table tbItemCompra (
    NotaFiscal int foreign key references tbCompra (NotaFiscal),  -- Relaciona com a tabela tbCompra
    CodigoBarras decimal (14,0) foreign key references tbProduto (CodigoBarras),  -- Relaciona com a tabela tbProduto
    ValorItem decimal (8,2) not null,    -- Valor do item na compra, não pode ser nulo
    Qtd int not null,                    -- Quantidade do item na compra
    primary key (NotaFiscal, CodigoBarras)  -- Chave primária composta por NotaFiscal e CodigoBarras
);

-- Criação da tabela tbItemVenda para armazenar os itens das vendas
create table tbItemVenda (
    NumeroVenda int foreign key references tbVenda(NumeroVenda),  -- Relaciona com a tabela tbVenda
    CodigoBarras decimal (14,0) foreign key references tbProduto (CodigoBarras),  -- Relaciona com a tabela tbProduto
    ValorItem decimal (8,2) not null,    -- Valor do item na venda, não pode ser nulo
    Qtd int not null                     -- Quantidade do item na venda
);
