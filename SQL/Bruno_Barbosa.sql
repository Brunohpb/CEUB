-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Prova1
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema prova1
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `prova1` DEFAULT CHARACTER SET utf8 ;
USE `prova1` ;

-- -----------------------------------------------------
-- Table `prova1`.`Marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `prova1`.`Marca` (
  `Idt` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Tipo` VARCHAR(45) NOT NULL,
  `Luxo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Idt`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `prova1`.`Veiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `prova1`.`Veiculo` (
  `Idt` INT NOT NULL,
  `Placa` VARCHAR(45) NOT NULL,
  `Preço` FLOAT NOT NULL,
  `Data_fabricacao` DATE NOT NULL,
  `data_compra` DATE NULL,
  `Marca_Idt` INT NOT NULL,
  PRIMARY KEY (`Idt`),
  INDEX `fk_Veiculo_Marca_idx` (`Marca_Idt` ASC) VISIBLE,
  CONSTRAINT `fk_Veiculo_Marca`
    FOREIGN KEY (`Marca_Idt`)
    REFERENCES `prova1`.`Marca` (`Idt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


show databases;

select database();

show tables;

use prova1;
-- Questão 1 --
-- Inserindo Marcas --
# SELECT *
# FROM marca;
#insert into marca
# (Idt, Nome, Tipo, Luxo)
#values (3, "Peugeot", "Hatch", "B")
#;


-- Inserindo Veiculos --
# SELECT * 
# FROM veiculo;

# insert into veiculo
# (Idt, Placa, Preço, Data_fabricacao, Data_compra, Marca_Idt)
# values (6, "SAD-2014", "25000","2020-10-5", "2021-4-28", 3)
#;

-- Questão 2 --
 Select *
 FROM veiculo 
	where Preço between '40000' and '90000'
order by preço desc
;

-- Questão 3 --
select Marca_Idt as Marcas
    , truncate(avg(Preço), 2) "Média por Marca"
    , count(*) "Quantidade de Carros"
from veiculo
GROUP BY Marca_Idt
order by Marca_Idt
;

select m.Idt 'Marca',  v.preço 'Preço', m.nome 'Nome', truncate(avg(V.Preço), 2) "Média por Marca"
from veiculo v join marca m
	on V.Marca_Idt = M.Idt
;

-- Questão 4 --

SELECT v.Idt "Código", v.Placa, v.Marca_Idt "Marca", m.Nome
FROM veiculo v join marca m
	on v.Marca_Idt = m.Idt
where v.Marca_Idt in (select Marca_Idt
					from veiculo
                    where Luxo = "A")
