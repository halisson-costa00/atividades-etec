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

 create table tbEnde�o (
 
 CEP int not null primary key ,

 Logradouro char (250) not null,

 IdUF tinyint 

 );

alter table tbCliente add constraint fk_CEP_tbCliente foreign key (CEP) references tbEnde�o (CEP);

exec sp_rename 'tbende�o', 'tbEndere�o';

sp_help tbCliente;

/* lembra os c�digos de cabe�a
l�gica de programa��o
memorizar as sintaxex*/

sp_DataBases;

drop DataBase dbEmpresa;










