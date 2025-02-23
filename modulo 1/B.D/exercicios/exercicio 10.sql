use dbBanco;

--1.Exclua o registro do telefone do cliente com Cpf número 12345678911.

delete from tbCliente
where Cpf = 12345678911;

select * from tbCliente;

-- 2.Altere o tipo da conta de número 9879 para 2.
update tbConta  set 
TipoConta=2
where NumeroConta=9879;

select * from tbConta;

--3.Insira o e-mail Astro@Escola.com no registro da “Monica”.

update tbCliente set
Email='Astro@Escola.com'
where Cpf=12345678912;

select * from tbCliente;

--4.Conceda à conta 9876 um aumento de 10 por cento no saldo.

update tbConta set 
Saldo = Saldo + ((Saldo/100)*10)
where NumeroConta=9876;

select * from tbConta;

--5.Selecione o registro da cliente Monica, mostrando somente o nome, e_mail e endereço.

select Nome, email, Endereço from  tbCliente
where Cpf=12345678912;

--Atualize o registro do cliente Enildo, o nome para Enildo Candido e insira o e_mail enildo@escola.com

update tbCliente set 

nome='Enildo Candido', 
email='enildo@escola.com'
where Cpf=12345678910;

select * from tbCliente;

--7.Retire 30 reais de todas as contas. Obs.: Você deve realizar todas as mudanças em um único comando

update tbConta set 
Saldo = Saldo - 30.00;

select * from tbConta;

--8.Exclua a conta 9878

delete from tbConta
where NumeroConta=9878;

select * from tbConta;