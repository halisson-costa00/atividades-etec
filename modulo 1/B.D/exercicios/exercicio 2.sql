create database  dbluis;

use dbluis

create table tbproduto (
idProp int primary key,
nomeProd char(50) not null,
Qtd int ,
DataValidade date not null,
Pre�o decimal(10,2)
);

create table tbcliente(
C�digo int primary key,
NomeCLi char(50) not null,
DataNascimento date 
);

