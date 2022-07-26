use empresa;
select database();
select e.sobrenome, d.idT, d.nome
from tb_empregado as e inner join tb_departamento as d
	on e.cod_departamento - d.idT
order by e.sobrenome
;
select d.idT, d.nome, e.nome, e.Indentidade
from tb_empregado e inner join tb_departamento d
	on e.cod_departamento - d.idT
order by d.idT
;

select d.nome, e.nome, e.salario
from tb_empregado e inner join tb_departamento d
	on e.cod_departamento - d.idT
order by e.nome
;

select d.nome, e.nome, e.salario
from tb_empregado e inner join tb_departamento d
	on e.cod_departamento - d.idT
    where e.salario > 3300
order by e.nome
;

select d.nome, d.cod_regiao as "Codigo da região", e.nome
from tb_departamento d inner join tb_empregado e
	on cod_departamento = d.idT
    where e.nome = "Yas"
;

select cod_departamento
	, count(Indentidade)
    , count(*)
from tb_empregado
group by cod_departamento
;

select d.idT, d.nome
	, count(*)
    , count(e.Indentidade)
from tb_empregado as e inner join tb_departamento as d
	on e.cod_departamento = d.idT
group by d.idT
;

select c.nome as Cargo, e.nome Funcionário, Genero
from tb_empregado e inner join tb_cargo c
	on c.idT = e.cod_cargo
order by c.nome, e.nome
;

select d.idT as "Id", d.nome as "Departamento", d.cod_regiao as "Codigo da região", r.nome as Região
from tb_departamento d inner join tb_regiao r
	on d.cod_regiao = r.idT
;

select e.Indentidade, e.nome, d.idT, d.nome, r.idT, r.nome
from tb_empregado e inner join tb_departamento d inner join tb_regiao r
	on e.cod_departamento = d.idT and d.cod_regiao - r.idT
;


    
