--Halisson

create DataBase dbEscola;

use dbEscola;

create table tbCliente(
IdCli int primary key not null,

NomeCliente char (50) not null ,

NumEnd int,

DataCadastro datetime  default current_timestamp,

);

alter table tbcliente add CPF bigint unique not null;

alter table tbcliente add CEP int;

create DataBAse dbEmpresa;

use dbEscola;

 create table tbEndeço (
 
 CEP int not null primary key ,

 Logradouro char (250) not null,

 IdUF tinyint 

 );

alter table tbCliente add constraint fk_CEP_tbCliente foreign key (CEP) references tbEndeço (CEP);

exec sp_rename 'tbendeço', 'tbEndereço';

sp_help tbCliente;

/* lembra os códigos de cabeça
lógica de programação
memorizar as sintaxex*/

sp_DataBases;

drop DataBase dbEmpresa;










