-- Cria��o do banco de dados chamado dbhalisson
create database dbhalisson;

-- Seleciona o banco de dados dbhalisson para ser usado
use dbhalisson;

-- Cria��o da tabela tbusuario com 3 colunas: clienteID (chave prim�ria), nomeusuario e datanascimnto
create table tbusuario(
    clienteID int primary key,    -- Define a coluna clienteID como chave prim�ria
    nomeusuario char(45),        -- Coluna para armazenar o nome do usu�rio (m�ximo de 45 caracteres)
    datanascimnto date           -- Coluna para armazenar a data de nascimento do usu�rio
);

-- Cria��o da tabela tbestado com 2 colunas: estado (chave prim�ria) e uf (sigla do estado)
create table tbestado(
    estado int primary key,      -- Define a coluna estado como chave prim�ria
    uf char(2)                   -- Coluna para armazenar a sigla do estado (exemplo: 'SP', 'RJ')
);

-- Cria��o da tabela tbclientes com 3 colunas: codigocliente (chave prim�ria), nome e endereco
create table tbclientes(
    codigocliente int primary key,  -- Define a coluna codigocliente como chave prim�ria
    nome char(50),                 -- Coluna para armazenar o nome do cliente (m�ximo de 50 caracteres)
    endereco char(60)              -- Coluna para armazenar o endere�o do cliente (m�ximo de 60 caracteres)
);

-- Cria��o da tabela tbprodutos com 3 colunas: barras (chave prim�ria), valor e descricao
create table tbprodutos(
    barras char(13) primary key,    -- Define a coluna barras como chave prim�ria (m�ximo de 13 caracteres)
    valor decimal(10,4),            -- Coluna para armazenar o valor do produto (10 d�gitos no total, sendo 4 ap�s a v�rgula)
    descricao text                  -- Coluna para armazenar a descri��o do produto
);

-- Exibe as informa��es sobre a tabela tbprodutos (estruturas, colunas e etc.)
sp_help tbprodutos;

-- Exibe o nome das tabelas presentes no banco de dados atual
select table_name from INFORMATION_SCHEMA.TABLES;

-- Exibe a lista de bancos de dados no servidor SQL
sp_databases;

-- Altera a tabela tbclientes para modificar o tamanho da coluna nome de 50 para 58 caracteres
alter table tbclientes alter column nome char(58);

-- Adiciona uma nova coluna 'qtd' � tabela tbprodutos para armazenar a quantidade de produtos
alter table tbprodutos add qtd int;

-- Exclui a tabela tbestado do banco de dados
drop table tbestado;

-- Remove a coluna datanascimnto da tabela tbusuario
alter table tbusuario drop column datanascimnto;
-- Cria��o do banco de dados chamado dbhalisson
create database dbhalisson;

-- Seleciona o banco de dados dbhalisson para ser usado
use dbhalisson;

-- Cria��o da tabela tbusuario com 3 colunas: clienteID (chave prim�ria), nomeusuario e datanascimnto
create table tbusuario(
    clienteID int primary key,    -- Define a coluna clienteID como chave prim�ria
    nomeusuario char(45),        -- Coluna para armazenar o nome do usu�rio (m�ximo de 45 caracteres)
    datanascimnto date           -- Coluna para armazenar a data de nascimento do usu�rio
);

-- Cria��o da tabela tbestado com 2 colunas: estado (chave prim�ria) e uf (sigla do estado)
create table tbestado(
    estado int primary key,      -- Define a coluna estado como chave prim�ria
    uf char(2)                   -- Coluna para armazenar a sigla do estado (exemplo: 'SP', 'RJ')
);

-- Cria��o da tabela tbclientes com 3 colunas: codigocliente (chave prim�ria), nome e endereco
create table tbclientes(
    codigocliente int primary key,  -- Define a coluna codigocliente como chave prim�ria
    nome char(50),                 -- Coluna para armazenar o nome do cliente (m�ximo de 50 caracteres)
    endereco char(60)              -- Coluna para armazenar o endere�o do cliente (m�ximo de 60 caracteres)
);

-- Cria��o da tabela tbprodutos com 3 colunas: barras (chave prim�ria), valor e descricao
create table tbprodutos(
    barras char(13) primary key,    -- Define a coluna barras como chave prim�ria (m�ximo de 13 caracteres)
    valor decimal(10,4),            -- Coluna para armazenar o valor do produto (10 d�gitos no total, sendo 4 ap�s a v�rgula)
    descricao text                  -- Coluna para armazenar a descri��o do produto
);

-- Exibe as informa��es sobre a tabela tbprodutos (estruturas, colunas e etc.)
sp_help tbprodutos;

-- Exibe o nome das tabelas presentes no banco de dados atual
select table_name from INFORMATION_SCHEMA.TABLES;

-- Exibe a lista de bancos de dados no servidor SQL
sp_databases;

-- Altera a tabela tbclientes para modificar o tamanho da coluna nome de 50 para 58 caracteres
alter table tbclientes alter column nome char(58);

-- Adiciona uma nova coluna 'qtd' � tabela tbprodutos para armazenar a quantidade de produtos
alter table tbprodutos add qtd int;

-- Exclui a tabela tbestado do banco de dados
drop table tbestado;

-- Remove a coluna datanascimnto da tabela tbusuario
alter table tbusuario drop column datanascimnto;
