-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema prova
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema prova
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `prova` DEFAULT CHARACTER SET utf8 ;
USE `prova` ;

-- -----------------------------------------------------
-- Table `prova`.`tb_veiculos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `prova`.`tb_veiculos` (
  `idt` INT NOT NULL AUTO_INCREMENT,
  `placa` VARCHAR(10) NOT NULL,
  `preco` FLOAT NOT NULL,
  `dta_aquisicao` DATE NOT NULL,
  `dta_fabricacao` DATE NOT NULL,
  `modelo` VARCHAR(20) NOT NULL,
  `cor` VARCHAR(15) NULL,
  `classe` VARCHAR(20) NULL,
  PRIMARY KEY (`idt`),
  UNIQUE INDEX `idt_UNIQUE` (`idt` ASC) VISIBLE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
