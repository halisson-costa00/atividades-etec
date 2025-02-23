create database dbhalisson;

use dbhalisson;

create table tbusuario(
clienteID int primary key,
nomeusuario char(45),
datanascimnto date 
);
create table tbestado(
estado int primary key,
uf char(2)
);

create table tbclientes(
codigocliente int primary key ,
nome char(50),
endereco char (60)
);

create table tbprodutos(
barras char(13) primary key ,
valor decimal(10,4),
descricao text
);

sp_help tbprodutos;

select table_name from INFORMATION_SCHEMA.TABLES;

sp_databases;

alter table tbclientes alter column nome char(58);

alter table tbprodutos add qtd int;

drop table tbestado;

alter table tbusuario drop column  datanascimnto ;

