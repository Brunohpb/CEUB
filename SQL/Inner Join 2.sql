select d.nome 'Departamento'
	, e.nome 'Funcionário'
    , e.genero as Gênero
    , c.nome Cargo
from tb_empregado as e
	join tb_cargo c on e.cod_cargo = c.idT
    join tb_departamento d on e.cod_departamento = d.idT
order by d.nome, e.nome
;

select f.idt "Id Func"
	, f.nome "Func"
    , f.sobrenome "Sobrenome"
    , g.idT "Id gerente"
    , g.nome "Nome gerente"
from tb_empregado f join tb_empregado g
	on f.cod_gerente = g.idT
;

select f.nome as "Nome Funcionário"
	, f.salario as "Salário do Funcionário"
    , g.nome as "Nome do Gerente"
    , g.sobrenome as "Sobrenome Gerente"
    , g.salario as "Salário do Gerente"
from tb_empregado as f join tb_empregado g
	on f.cod_gerente = g.idT
order by f.nome
;