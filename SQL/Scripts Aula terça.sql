-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Empresa
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Empresa
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Empresa` DEFAULT CHARACTER SET utf8 ;
USE `Empresa` ;

-- -----------------------------------------------------
-- Table `Empresa`.`Tb_cargo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Empresa`.`Tb_cargo` (
  `idT` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idT`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Empresa`.`Tb_regiao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Empresa`.`Tb_regiao` (
  `idT` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idT`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Empresa`.`Tb_departamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Empresa`.`Tb_departamento` (
  `idT` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `cod_regiao` INT NOT NULL,
  PRIMARY KEY (`idT`),
  INDEX `fk_Tb_departamento_Tb_regiao1_idx` (`cod_regiao` ASC) VISIBLE,
  CONSTRAINT `fk_Tb_departamento_Tb_regiao1`
    FOREIGN KEY (`cod_regiao`)
    REFERENCES `Empresa`.`Tb_regiao` (`idT`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Empresa`.`Tb_empregado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Empresa`.`Tb_empregado` (
  `idT` INT NOT NULL,
  `Indentidade` VARCHAR(15) NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Sobrenome` VARCHAR(45) NOT NULL,
  `cod_cargo` INT NOT NULL,
  `cod_departamento` INT NOT NULL,
  `cod_gerente` INT NULL,
  `data_nascimento` DATE NOT NULL,
  `dta_inicio` DATE NOT NULL,
  `genero` ENUM("M", "F") NOT NULL,
  `salario` DECIMAL(9,2) NULL,
  `pct_comissao` DECIMAL(5,1) NULL,
  PRIMARY KEY (`idT`),
  UNIQUE INDEX `Indentidade_UNIQUE` (`Indentidade` ASC) VISIBLE,
  INDEX `fk_Tb_empregado_Tb_cargo_idx` (`cod_cargo` ASC) VISIBLE,
  INDEX `fk_Tb_empregado_Tb_departamento1_idx` (`cod_departamento` ASC) VISIBLE,
  INDEX `fk_Tb_empregado_Tb_empregado1_idx` (`cod_gerente` ASC) VISIBLE,
  CONSTRAINT `fk_Tb_empregado_Tb_cargo`
    FOREIGN KEY (`cod_cargo`)
    REFERENCES `Empresa`.`Tb_cargo` (`idT`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tb_empregado_Tb_departamento1`
    FOREIGN KEY (`cod_departamento`)
    REFERENCES `Empresa`.`Tb_departamento` (`idT`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tb_empregado_Tb_empregado1`
    FOREIGN KEY (`cod_gerente`)
    REFERENCES `Empresa`.`Tb_empregado` (`idT`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
