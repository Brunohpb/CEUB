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
-- Table `mydb`.`Tb_vendedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tb_vendedor` (
  `Idt` INT NOT NULL,
  `Nome` VARCHAR(45) NOT NULL,
  `data_venda` DATE NOT NULL,
  `comissao` DECIMAL(5,1) NULL,
  PRIMARY KEY (`Idt`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tb_veiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tb_veiculo` (
  `Codico_marca` INT NOT NULL,
  `Quilometragem` VARCHAR(45) NOT NULL,
  `Preço_veiculo` FLOAT NOT NULL,
  `Placa_veiculo` INT NOT NULL,
  `data_fabricacao` DATE NULL,
  `Cod_vendedor` INT NOT NULL,
  PRIMARY KEY (`Codico_marca`),
  INDEX `fk_Tb_veiculo_Tb_vendedor_idx` (`Cod_vendedor` ASC) VISIBLE,
  CONSTRAINT `fk_Tb_veiculo_Tb_vendedor`
    FOREIGN KEY (`Cod_vendedor`)
    REFERENCES `mydb`.`Tb_vendedor` (`Idt`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
