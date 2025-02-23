--ex11.Estudo de Caso - DISTRIBUIDORA LTDA

create database dbDistribuidora;

use dbDistribuidora;
 
 
create table tbCliente_pf (
Cpf  decimal (11,0) primary key ,
Rg decimal (9,0)not null,
Rg_Dig char(1) not null,
NAscim date not null,
Id  int 
);

 create table tbCliente_pj (
 Cnpj decimal (14,0) primary key,
 Ie decimal (11,0),
 Id  int
 );

 create table tbBairro (
 BairroId int primary key,
 Bairro varchar(200) not null
 );

 create table tbCidade (
 CidadeId int primary key,
 Cidade varchar (200) not null
 );

 create table tbEstado (
 UfId int primary key,
 Uf char (2) not null 
 );

 create table tbEndereco (
 Logradouro  varchar (200) not null ,
 Cep  decimal (8,0) primary key,
 BairroId int foreign key references tbBairro(BairroId),
 CIdadeId int foreign key references tbCidade( CidadeId),
 UfId int foreign key references tbEstado (UfId),
 );

 create table tbCliente (
 Id int primary key,
 NomeCli  varchar (200)not null,
 NumEnd  decimal (6,0) not null,
 CompEnd varchar (50),
 CepCli  decimal (8,0) foreign key references tbEndereco (Cep)
 );
  
  create table tbNota_fiscal (
  Nf int primary key,
  TotalNota decimal (8,2) not null,
  DataEmissao date not null
  );

  create table tbVenda (
  NumeroVenda int primary key ,
  DataVenda date not null,
  TotalVenda decimal (8,2) not null,
  ID_Cli int foreign key references tbCliente(Id),
  Nf int foreign key references tbNota_fiscal (NF)
  );

 create table tbFornecedor (
Codigo int primary key,
Cnpj decimal (14,0),
Nome varchar (200) not null,
telefone  decimal (11,0)
);

 create table tbCompra (
 NotaFiscal int primary key ,
 DataCompra date  not null,
 ValorTotal  decimal (8,2) not null,
 QtdTotal int not null,
 Codigo int  foreign key references tbFornecedor (Codigo)
 );
  
  create table tbProduto (
  CodigoBarras decimal  (14,0) primary key ,
  Nome varchar (200) not null,
  Valor decimal (8,2) not null,
  Qtd int 
  );

  select table_name from INFORMATION_SCHEMA.TABLES; 

  create table tbItemCompra (
  NotaFiscal int foreign key references tbCompra (NotaFiscal),
  CodigoBarras decimal (14,0) foreign key references tbProduto (CodigoBarras),
  ValorItem decimal (8,2) not null,
  Qtd int not null
  primary key (NotaFiscal,CodigoBarras) 
  );

  create table tbItemVenda (
  NumeroVenda int foreign key references tbVenda(NumeroVenda),
  CodigoBarras decimal (14,0) foreign key references tbProduto (CodigoBarras),
  ValorItem decimal (8,2) not null,
  Qtd int not null
 );
  

