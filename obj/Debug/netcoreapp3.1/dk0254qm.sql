  IF EXISTS(SELECT 1 FROM information_schema.tables 
  WHERE table_name = '
'__EFMigrationsHistory'' AND table_schema = DATABASE()) 
BEGIN
CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

END;

CREATE DATABASE IF NOT EXISTS `CompanyDb`
CREATE TABLE `CompanyDb`.`Building` (
    `BuildingId` int NOT NULL AUTO_INCREMENT,
    `BuildingName` varchar(20) NOT NULL,
    `BuildingAddress` varchar(20) NULL,
    `BuildingOwner` varchar(20) NULL,
    PRIMARY KEY (`BuildingId`)
);

CREATE TABLE `CompanyDb`.`Department` (
    `DepartmentId` int NOT NULL AUTO_INCREMENT,
    `DepartmentName` varchar(20) NOT NULL,
    `DepartmentAddress` varchar(100) NULL,
    `DepartmentManagerName` varchar(100) NULL,
    PRIMARY KEY (`DepartmentId`)
);

CREATE TABLE `CompanyDb`.`Employee` (
    `EmployeeId` int NOT NULL AUTO_INCREMENT,
    `EmployeeName` varchar(20) NOT NULL,
    `EmployeeCnic` varchar(20) NULL,
    `EmployeeContactNumber` varchar(20) NULL,
    `EmployeeAddress` varchar(20) NULL,
    PRIMARY KEY (`EmployeeId`)
);

CREATE TABLE `CompanyDb`.`Project` (
    `ProjectId` int NOT NULL AUTO_INCREMENT,
    `ProjectName` varchar(20) NOT NULL,
    `ProjectDescription` varchar(20) NULL,
    `ProjectDuration` varchar(20) NOT NULL,
    PRIMARY KEY (`ProjectId`)
);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200727004537_MyProject1.CompanyDataContext', '3.1.6');

