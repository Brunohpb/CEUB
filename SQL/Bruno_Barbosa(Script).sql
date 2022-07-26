-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Marca`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Marca` (
  `Idt` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `Tipo` VARCHAR(45) NOT NULL,
  `Luxo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Idt`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Veiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Veiculo` (
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
    REFERENCES `mydb`.`Marca` (`Idt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
