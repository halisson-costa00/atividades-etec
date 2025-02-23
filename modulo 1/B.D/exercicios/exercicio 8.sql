use dbEscola;

 create table tBest(
 
 idUf tinyint primary key,

NomeUfs char (2) not null,

NomeEstado char (40) not null,

 );

alter table tbEndereço add constraint fk_idUfs_tbEndereço foreign key (idUF) references tbBest (idUf);

sp_rename'tbest','tbEstado';

sp_rename 'NomeUfs','NomeUf';

create table tbCidade(

idCid int primary key,

NomeCidade char (50) not null

);

alter table tbEndereço add idCid int;	

alter table tbCidade alter column NomeCidade char (250);

alter table tbEndereço add constraint fk_idCid_tbEndereço foreign key (idCid) references tbCidade (idCid);

select* from tbCidade;



