-- Seleciona o banco de dados "dbBanco" para realizar as opera��es
USE dbBanco;

-- 1. Excluindo o cliente com CPF 12345678911 da tabela tbCliente.
-- Isso ir� remover o registro do cliente completamente da tabela.
DELETE FROM tbCliente
WHERE Cpf = 12345678911;

-- Exibe todos os registros de clientes para verificar a exclus�o
SELECT * FROM tbCliente;

-- 2. Alterando o tipo da conta do cliente com o n�mero 9879 para 2 (provavelmente alterando o tipo da conta)
UPDATE tbConta SET 
TipoConta = 2 -- Atualiza a coluna TipoConta para o novo valor
WHERE NumeroConta = 9879; -- Aplica a mudan�a somente � conta com o n�mero 9879

-- Exibe todos os registros da tabela tbConta para verificar a altera��o do tipo de conta
SELECT * FROM tbConta;

-- 3. Atualizando o e-mail da cliente "Monica" para 'Astro@Escola.com' usando seu CPF
UPDATE tbCliente SET
Email = 'Astro@Escola.com' -- Atualiza o campo Email para o novo valor
WHERE Cpf = 12345678912; -- Filtra a cliente Monica atrav�s do CPF

-- Exibe todos os registros da tabela tbCliente para verificar a altera��o do e-mail
SELECT * FROM tbCliente;

-- 4. Concedendo um aumento de 10% no saldo da conta n�mero 9876
UPDATE tbConta SET 
Saldo = Saldo + ((Saldo / 100) * 10) -- Calcula 10% do saldo atual e adiciona ao saldo
WHERE NumeroConta = 9876; -- Aplica o aumento somente � conta com o n�mero 9876

-- Exibe todos os registros da tabela tbConta para verificar a altera��o no saldo
SELECT * FROM tbConta;

-- 5. Selecionando o registro da cliente Monica, mostrando apenas o nome, e-mail e endere�o
SELECT Nome, Email, Endereco -- Seleciona apenas as colunas Nome, Email e Endereco
FROM tbCliente
WHERE Cpf = 12345678912; -- Filtra o registro da cliente Monica pelo CPF

-- 6. Atualizando o nome de Enildo para "Enildo Candido" e inserindo seu e-mail "enildo@escola.com"
UPDATE tbCliente SET 
Nome = 'Enildo Candido', -- Atualiza o nome do cliente
Email = 'enildo@escola.com' -- Atualiza o e-mail do cliente
WHERE Cpf = 12345678910; -- Filtra o cliente Enildo pelo CPF

-- Exibe todos os registros da tabela tbCliente para verificar a altera��o do nome e e-mail
SELECT * FROM tbCliente;

-- 7. Retirando 30 reais de todas as contas no banco de dados
UPDATE tbConta SET 
Saldo = Saldo - 30.00; -- Subtrai 30 reais do saldo de todas as contas

-- Exibe todos os registros da tabela tbConta para verificar a altera��o nos saldos
SELECT * FROM tbConta;

-- 8. Excluindo a conta de n�mero 9878 da tabela tbConta
DELETE FROM tbConta
WHERE NumeroConta = 9878; -- Filtra a conta n�mero 9878 para exclus�o

-- Exibe todos os registros da tabela tbConta para verificar a exclus�o
SELECT * FROM tbConta;
