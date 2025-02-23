create DataBase dbDesenvolvimento;

use dbDesenvolvimento;

create table tbProduto(
idProp int primary key not null,
NomeProd char (50) not null,
Qtd int,
DataValidade date not null,
Preço smallmoney not null
);

alter table tbProduto add Peso decimal (10,2);

alter table tbProduto add cor char (50), Marca char (50) not null;

alter table tbProduto drop column Cor;

alter table tbProduto alter column Peso decimal (10,2) not null;

/* coluna Cor ja 
apagada anteriormente.*/

create DataBAse dbLojaGrande;

alter table tbProduto add Cor  char (50),

create DataBase dbLogica;

use dbLogica;

create table tbcliente (

NomeCli char (50) not null,

CodigoCli int primary key ,

DataCadastro date not null
);

use dbLojaGrande;

create table tbFuncionarios (
NomeFunc char (50) not null ,

CodigoFunc int primary key ,

DataCAdastro datetime not null
);

use dbLogica;

drop DataBase dbLojaGrande;

use dbLogica;

alter table tbCliente add CPF bigint not null unique

                                                    