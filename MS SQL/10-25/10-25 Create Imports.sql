--CREATE DATABASE Imports

USE Imports

--CREATE TABLE Categories ( CategoryID INT PRIMARY KEY IDENTITY, Name Nvarchar(50) )

--CREATE TABLE Products ( ProductsID INT PRIMARY KEY IDENTITY, 
--						ProductName Nvarchar(50),
--						UnitPrice DECIMAL(10,2),
--						CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID) )

--CREATE TABLE Importers ( ImporterID INT PRIMARY KEY IDENTITY, 
--						ImporterName Nvarchar(50),
--						ImporterCountry Nvarchar(50) )

--CREATE TABLE ProductImports ( ImporterID INT , 
--						ProductID INT FOREIGN KEY REFERENCES Importers(ImporterID),
--						ImporterCountry INT FOREIGN KEY REFERENCES Products(ProductsID),
--						ImportDate DATE,
--						Quantity INT	)


----------------------------
--https://www.mockaroo.com/
----------------------------


INSERT INTO Categories VALUES
('Fruits'), ('Vegetables'), ('Drinks'), ('Cleaning'), ('Sweets')

