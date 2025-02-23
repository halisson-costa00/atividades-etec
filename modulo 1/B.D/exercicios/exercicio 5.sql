Create DataBase DbDeny;

use DbDeny;

create table tbVenda (
Nf int primary key identity (1,1),
DataValidade datetime not null ,
);

alter table tbVenda add Preço smallmoney not null;

alter table tbvenda add Qtd int ;

alter table tbVenda drop column DataValidade;

alter table tbVenda add DataVenda timestamp not null;

create table tbProduto (
codigoB int Primary key not null,
NomeProd char (50) not null
);

alter table tbProduto add foreign key (codigoB) references tbProduto (codigoB);