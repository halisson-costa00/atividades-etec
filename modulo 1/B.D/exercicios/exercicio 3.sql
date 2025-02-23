create database  dbcomércio

use dbcomércio

create table tbcliente(
id int primary key,
NomeCliente char(200) not null,
NumEnd int not null,
CompEnd char(50)
);

create table tbclientePf(
cpf bigint primary key,
RG int,
RgDig  tinyint,
Nascimento date not null
);
