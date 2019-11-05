/* Crear la Base de Datos Recreación */
USE MASTER
GO
/****** Object:  Database [RECREACION]    ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'SUPERMERCADO')
BEGIN
	CREATE DATABASE SUPERMERCADO
END
go
/* Poner en uso la Base de Datos */
use SUPERMERCADO
go

/* Crear la Tabla Categoria*/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categoria]') AND type in (N'U'))
BEGIN
CREATE TABLE Categoria(
CodCat Int IDENTITY(1,1) PRIMARY KEY,
NomCat varchar(30) NOT NULL);
END
GO
/* Crear la Tabla Producto */
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Producto]') AND type in (N'U'))
BEGIN
CREATE TABLE Producto(
CodProd Int IDENTITY(1,1) PRIMARY KEY,
NomProd varchar(30) NOT NULL,
CodCat Int NOT NULL);
END
/* Datos para la tabla Categoria */
INSERT INTO Categoria(NomCat) VALUES('Lacteos');
INSERT INTO Categoria(NomCat) VALUES('Granos');
INSERT INTO Categoria(NomCat) VALUES('Carnes');
INSERT INTO Categoria(NomCat) VALUES('Bebidas');
INSERT INTO Categoria(NomCat) VALUES('Aseo');


/*Datos para la tabla Producto */
INSERT INTO Producto(NomProd,CodCat) VALUES('Leche',1);
INSERT INTO Producto(NomProd,CodCat) VALUES('Arroz',2);
INSERT INTO Producto(NomProd,CodCat) VALUES('Queso',1);
INSERT INTO Producto(NomProd,CodCat) VALUES('Pollo',3);
INSERT INTO Producto(NomProd,CodCat) VALUES('Gaseosa',4);
INSERT INTO Producto(NomProd,CodCat) VALUES('Jabón',5);
INSERT INTO Producto(NomProd,CodCat) VALUES('Frijol',2);
INSERT INTO Producto(NomProd,CodCat) VALUES('Crema dental',5);
INSERT INTO Producto(NomProd,CodCat) VALUES('Jamón',3);
INSERT INTO Producto(NomProd,CodCat) VALUES('Tequila',4);
INSERT INTO Producto(NomProd,CodCat) VALUES('Kumis',1);




select *from Producto