create database dbmaria;

use dbmaria;

create table tbProdutos(
idProd int primary key not null,
nomeProd char (50) not null,
Qtd int ,
DataValidade date not null,
Preço smallmoney not null
);

alter table tbProdutos add Peso decimal (10,2);

alter table tbProdutos add Cor char (50);

alter table tbProdutos add Maeca char (50) not null;

alter table tbProdutos drop column cor;

alter table tbProdutos alter column peso decimal (10,2) not null;

alter table tbProdutos drop column DataValidade;