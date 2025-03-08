-- Cria��o do banco de dados dbDistribuidora
create database dbDistribuidora;

-- Seleciona o banco de dados dbDistribuidora para que as opera��es sejam feitas nesse banco
use dbDistribuidora;

-- Cria��o da tabela tbCliente_pf (Pessoa F�sica) para armazenar dados de clientes PF
create table tbCliente_pf (
    Cpf decimal (11,0) primary key,   -- CPF como chave prim�ria
    Rg decimal (9,0) not null,         -- RG do cliente, n�o pode ser nulo
    Rg_Dig char(1) not null,           -- D�gito do RG, n�o pode ser nulo
    NAscim date not null,              -- Data de nascimento, n�o pode ser nula
    Id int                             -- ID de identifica��o adicional
);

-- Cria��o da tabela tbCliente_pj (Pessoa Jur�dica) para armazenar dados de clientes PJ
create table tbCliente_pj (
    Cnpj decimal (14,0) primary key,   -- CNPJ como chave prim�ria
    Ie decimal (11,0),                 -- Inscri��o Estadual
    Id int                             -- ID de identifica��o adicional
);

-- Cria��o da tabela tbBairro para armazenar informa��es de bairros
create table tbBairro (
    BairroId int primary key,          -- ID do bairro como chave prim�ria
    Bairro varchar(200) not null       -- Nome do bairro, n�o pode ser nulo
);

-- Cria��o da tabela tbCidade para armazenar informa��es de cidades
create table tbCidade (
    CidadeId int primary key,          -- ID da cidade como chave prim�ria
    Cidade varchar(200) not null       -- Nome da cidade, n�o pode ser nulo
);

-- Cria��o da tabela tbEstado para armazenar informa��es de estados
create table tbEstado (
    UfId int primary key,              -- ID do estado como chave prim�ria
    Uf char (2) not null               -- Sigla do estado, n�o pode ser nulo
);

-- Cria��o da tabela tbEndereco para armazenar dados de endere�os
create table tbEndereco (
    Logradouro varchar (200) not null, -- Logradouro do endere�o, n�o pode ser nulo
    Cep decimal (8,0) primary key,     -- CEP como chave prim�ria
    BairroId int foreign key references tbBairro(BairroId), -- Relaciona com a tabela tbBairro
    CIdadeId int foreign key references tbCidade( CidadeId), -- Relaciona com a tabela tbCidade
    UfId int foreign key references tbEstado (UfId)  -- Relaciona com a tabela tbEstado
);

-- Cria��o da tabela tbCliente para armazenar dados dos clientes com endere�o
create table tbCliente (
    Id int primary key,                -- ID do cliente como chave prim�ria
    NomeCli varchar (200) not null,    -- Nome do cliente, n�o pode ser nulo
    NumEnd decimal (6,0) not null,     -- N�mero do endere�o, n�o pode ser nulo
    CompEnd varchar (50),              -- Complemento do endere�o
    CepCli decimal (8,0) foreign key references tbEndereco (Cep)  -- Relaciona o cliente com o endere�o via CEP
);

-- Cria��o da tabela tbNota_fiscal para armazenar dados de notas fiscais
create table tbNota_fiscal (
    Nf int primary key,                -- N�mero da nota fiscal como chave prim�ria
    TotalNota decimal (8,2) not null,  -- Total da nota fiscal, n�o pode ser nulo
    DataEmissao date not null          -- Data de emiss�o da nota fiscal, n�o pode ser nula
);

-- Cria��o da tabela tbVenda para armazenar dados das vendas
create table tbVenda (
    NumeroVenda int primary key,       -- N�mero da venda como chave prim�ria
    DataVenda date not null,           -- Data da venda, n�o pode ser nula
    TotalVenda decimal (8,2) not null, -- Total da venda, n�o pode ser nula
    ID_Cli int foreign key references tbCliente(Id), -- Relaciona a venda com o cliente
    Nf int foreign key references tbNota_fiscal (NF)  -- Relaciona a venda com a nota fiscal
);

-- Cria��o da tabela tbFornecedor para armazenar dados dos fornecedores
create table tbFornecedor (
    Codigo int primary key,            -- C�digo do fornecedor como chave prim�ria
    Cnpj decimal (14,0),               -- CNPJ do fornecedor
    Nome varchar (200) not null,       -- Nome do fornecedor, n�o pode ser nulo
    telefone decimal (11,0)            -- Telefone do fornecedor
);

-- Cria��o da tabela tbCompra para armazenar dados de compras
create table tbCompra (
    NotaFiscal int primary key,        -- N�mero da nota fiscal de compra como chave prim�ria
    DataCompra date not null,          -- Data da compra, n�o pode ser nula
    ValorTotal decimal (8,2) not null, -- Valor total da compra, n�o pode ser nulo
    QtdTotal int not null,             -- Quantidade total de itens na compra
    Codigo int foreign key references tbFornecedor (Codigo) -- Relaciona com o fornecedor
);

-- Cria��o da tabela tbProduto para armazenar dados dos produtos
create table tbProduto (
    CodigoBarras decimal (14,0) primary key, -- C�digo de barras como chave prim�ria
    Nome varchar (200) not null,             -- Nome do produto, n�o pode ser nulo
    Valor decimal (8,2) not null,            -- Valor do produto, n�o pode ser nulo
    Qtd int                                  -- Quantidade dispon�vel do produto
);

-- Consulta para listar todas as tabelas no banco de dados
select table_name from INFORMATION_SCHEMA.TABLES; 

-- Cria��o da tabela tbItemCompra para armazenar os itens das compras
create table tbItemCompra (
    NotaFiscal int foreign key references tbCompra (NotaFiscal),  -- Relaciona com a tabela tbCompra
    CodigoBarras decimal (14,0) foreign key references tbProduto (CodigoBarras),  -- Relaciona com a tabela tbProduto
    ValorItem decimal (8,2) not null,    -- Valor do item na compra, n�o pode ser nulo
    Qtd int not null,                    -- Quantidade do item na compra
    primary key (NotaFiscal, CodigoBarras)  -- Chave prim�ria composta por NotaFiscal e CodigoBarras
);

-- Cria��o da tabela tbItemVenda para armazenar os itens das vendas
create table tbItemVenda (
    NumeroVenda int foreign key references tbVenda(NumeroVenda),  -- Relaciona com a tabela tbVenda
    CodigoBarras decimal (14,0) foreign key references tbProduto (CodigoBarras),  -- Relaciona com a tabela tbProduto
    ValorItem decimal (8,2) not null,    -- Valor do item na venda, n�o pode ser nulo
    Qtd int not null                     -- Quantidade do item na venda
);
