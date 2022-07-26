show databases;

select database();

show tables;

use empresa;

-- Contar --
select count(*) as 'Quantidade de Funcionarios'
	, count(Indentidade) 'Quantidade de Funcionarios'
from tb_empregado
;

-- max e min --

select max(salario) as "Maior Salário"
	, min(salario) "Menor salário"
from tb_empregado
;

-- Count, Max/Min, média e soma --
select count(*) as Quantidade
	, max(salario) "Maior Salário"
	, min(salario) "Menor salário"
    , sum(salario) 'Folha de pagamento'
    , avg(salario) as Média
    , truncate(avg(salario), 2) Média
from tb_empregado
;

-- count + where --

select cod_departamento as Departamento
	, max(salario) "Maior Salario"
from tb_empregado
where cod_departamento = 4
;

-- Count + inner join + where --

select cod_cargo as Cargo
	, count(*) Quantidade
    , truncate(avg(salario), 2) Média
from tb_empregado e join tb_cargo c
	on e.cod_cargo = c.idT
where c.idT = 3
;

-- Count + distinc --

select count(distinct sobrenome) as "Sobrenomes"
from tb_empregado
;
 -- ------------------------ --
 Select max(salario) "Maior Salário"
	, min(salario) "Menor salário"
    , max(salario) - min(salario) "Diferença Salarial"
from tb_empregado
;

-- Ordem Alfabética --
select min(nome), max(nome), count(nome)
from tb_empregado
;

-- Com group by 
SELECT distinct Sobrenome
, count(*) "Quantas Repetições"
FROM tb_empregado
group by Sobrenome
order by Sobrenome desc
;

select cod_departamento as Departamento
	, truncate(avg(salario), 2) "Média por departamento"
from tb_empregado
GROUP BY cod_departamento 
order by cod_departamento
;