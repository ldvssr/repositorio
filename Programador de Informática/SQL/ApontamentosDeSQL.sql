Apontamentos
SQL - Structured Query Language

SELECT; seleciona os dados
SELECT *; seleciona todos os atributos / colunas da tabela
SELECT nome, idade; seleciona os atributos indicados na tabela

SELECT * FROM users; vai buscar os dados todos da tabela "users";

//seleção com condição única
SELECT * FROM users WHERE idade = 26;
SELECT * FROM users WHERE idade < 26;
SELECT * FROM users WHERE idade > 26;
SELECT * FROM users WHERE idade <= 26;
SELECT * FROM users WHERE idade >= 26;

//seleção com múltiplas condições
SELECT * FROM users WHERE idade > 2 AND idade < 26;
SELECT * FROM users WHERE idade > 2 OR idade < 26;
SELECT * FROM users WHERE idade > 2 AND idade < 26 AND .....;

//coloca limite no número de registos que queremos consultar
SELECT * FROM users WHERE idade > 2 LIMIT 5;
SELECT * FROM users WHERE idade > 2 TOP 5;

//ordenação de tabelas em SQL
SELECT * FROM users ORDER BY age; (valor predefinido ASC)
SELECT * FROM users ORDER BY name ASC; ordena por ordem ascendente
SELECT * FROM users ORDER BY name DESC; ordena por ordem descendente

//contagem de valores numa tabela
SELECT COUNT (id) FROM users; conta quantos ids a tabela users possui
SELECT COUNT (DISTINCT id) FROM users; conta quantos ids diferentes a tabela users possui

//SQL específico, não funciona em MySQL
SELECT COUNT (*) FROM USERS; ele retornaria a contagem de registos na tabela, 
em MySQL este comando não funciona, mas os comandos referidos em cima possuem a 
mesma função / resultado

//operações matemáticas
SELECT SUM (age) FROM users; fazia a soma de todas as idades da tabela users
SELECT MAX (age) FROM users; vai retornar o valor de idade máximo que a nossa tabela contém
SELECT MIN (age) FROM users; vai retornar o valor de idade mínimo que a nossa tabela contém
SELECT AVG (age) FROM users; vai retornar o valor médio das idades que a nossa tabela contém

//filtros de igualdade / padrão
SELECT * FROM users WHERE name LIKE '%Fonseca'; seleciona todos os nomes que possuem na 
última parte da string o nome "Fonseca"

SELECT * FROM users WHERE name LIKE 'Igor%'; seleciona todos os nomes que possuem na 
primeira parte da string o nome "Igor"

SELECT * FROM users WHERE name LIKE '%Igor%'; seleciona todos os nomes que no 
meio a string "Igor"

exemplos de tabela
Name  | Idade | Morada | MFamilia
Igor  | 34    | Rua A  | Dr Joao Marinho
Paulo | 45    | Rua C  | NULL
Joao  | 23    | Rua B  | Dr Guilherme

SELECT * FROM users WHERE MFamilia IS NULL; selecionar todos os utentes SEM médico de família
SELECT * FROM users WHERE MFamilia IS NOT NULL; selecionar todos os utentes COM médico de família

Data Definition Language - DDL

CREATE DATABASE MyDatabase; cria uma base de dados nova

//cria uma tabela na base de dados com dois atributos, um sendo o id (inteiro) e outro sendo um nome (varchar) com o tamanho de 255 chars
CREATE TABLE myTable(
    id int,
    name varchar(255)
);

//retira um atributo / coluna de uma tabela
ALTER TABLE myTable DROP COLUMN name;

//adicionar um atributo à nossa tabela
ALTER TABLE myTable ADD name varchar(225);

//elimina TODO o conteúdo de uma base de dados importância de fazer backups
DROP DATABASE MyDataBase;

//elimina TODO o conteúdo de uma tabela
DROP TABLE myTable;

DML - Data Manipulation Language

//selecionar atributos / colunas
SELECT col1, col2 FROM myTable;

//apagar registo da tabela myTable onde id = 1400
DELETE FROM myTable WHERE id = 1400;

//inserir na tabela um registo
INSERT INTO myTable (id, name) VALUES (1500,"João Ribeiro");

//inserir na tabela caso haja um valor auto incrementativo (exemplo : id será AUTO incrementativo)
INSERT INTO myTable (id, name) VALUES (NULL,"João Ribeiro");

//irá atualizar o valor do nome para "João Fonseca" onde o nome for "João Ribeiro"
UPDATE myTable SET name = "João fonseca" WHERE name = 'João Ribeiro';

//irá atualizar o valor do nome para "João Fonseca" onde o id for 1500
UPDATE myTable SET name = "João fonseca" WHERE id = 1500;

