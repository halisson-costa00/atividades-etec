create database dbBanco;

use dbBanco;

create table tbAgencia(

CodBanco int,

NumeroAgencia int primary key ,

Endereço varchar (50) not null

);

create table tbBanco (

Codigo int primary key,

Nome varchar (50) not null,

);

create table tbTelefone (

cpf bigint ,

Telefone int primary key 

);

create table tbCliente (

Cpf bigint primary key ,

Nome varchar (50) not null , 

Sexo char (1) not null,

Endereço varchar (50) not null 

);

create table tbConta (

NumeroConta int primary key ,

Saldo decimal(7,2) ,

TipoConta smallint ,

NumeroAgencia int foreign key references  tbAgencia (NumeroAgencia)

);


create table tbHistorico (

Cpf bigint foreign key references tbCliente (Cpf),

NumeroConta int foreign key references tbConta (NumeroConta),

DataInicio date 

);

/*INSERTS*/

select * from tbBanco;

insert into tbBanco values 

(1,'Banco do Brasil'),

(104,'Caixa Economica'),

(801,'Banco Escola');

select* from tbAgencia;

insert into tbConta
(NumeroConta,Saldo,TipoConta,NumeroAgencia)
values 
(9876,456.05,1,123),
(9877,321.00,1,123),
(9878,100.00,2,485),
(9879,5589.48,1,401);

insert into tbAgencia values 

(1,123,'Av PAulista,78'),

(104,159,'Rua Liberdade,124'),

(801,401,' Rua vinte e três,23'),

(801,485,' AV marechal,68');



select* from tbCliente;

insert into tbCliente
(Cpf, Nome, Sexo, Endereço)
values 
(12345678910,'Enildo', 'M','Rua Grande,75'),

(12345678911,'Astrogildo','M', 'Rua Pequena,789'),

(12345678912, 'Monica', 'F', 'Rua Larga,148'),

(12345678913,'Cascão','M', 'Rua Principal,369');

alter table tbCliente add Email varchar (50);

/*alter table tbCliente add Email varchar (50) default ''; */ 

select Cpf, Endereço from tbCliente
where nome = 'Monica';


select NumeroAgencia, Endereço from tbAgencia
where CodBanco = 801;

/*
SELECT tbAgencia.NumeroAgencia, tbAgencia.Endereço FROM tbAgencia
INNER JOIN  tbBanco ON tbBanco.Codigo=tbAgencia.CodBanco 
WHERE tbBanco.Codigo = 801;
*/

/*7.Recupere todos os valores de atributo de qualquer cliente que é do sexo masculino*/
select * from tbCliente
where Sexo = 'M';





