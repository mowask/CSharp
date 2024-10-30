--CREATE DATABASE SportShop
--GO

--USE SportShop

--CREATE TABLE Categories ( CategoryId INT PRIMARY KEY IDENTITY, 
--						CategoryName NVARCHAR(50) NOT NULL	
--						)


--CREATE TABLE Makers ( MakerId INT PRIMARY KEY IDENTITY, 
--						MakerName NVARCHAR(100),
--						MakerCountry NVARCHAR(50)
--						)						


--CREATE TABLE Products ( ProductId INT PRIMARY KEY IDENTITY, 
--						ProductName NVARCHAR(100) NOT NULL,
--						CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryId),
--						Quntity INT, 						
--						NetPrice DECIMAL(7,2),
--						SellPrice DECIMAL(7,2)	,	
--						MakerId INT FOREIGN KEY REFERENCES Makers(MakerId)
--						)


--CREATE TABLE Clients ( ClientId INT PRIMARY KEY IDENTITY, 
--						FirstName NVARCHAR(50),
--						LastName NVARCHAR(50),
--						MidleName NVARCHAR(50), 
--						Phone NVARCHAR(50),
--						Email NVARCHAR(50), 
--						Discount DECIMAL(2,2) CHECK (Discount >= 0),
--						IsSubscribed BIT	
--						)


--CREATE TABLE Positions ( PositionId INT PRIMARY KEY IDENTITY, 
--						PositionName NVARCHAR(50)				
--						)


--CREATE TABLE Employees ( EmployeeId INT PRIMARY KEY IDENTITY, 
--						FirstName NVARCHAR(50),
--						LastName NVARCHAR(50),
--						MidleName NVARCHAR(50), 
--						PositionId INT FOREIGN KEY REFERENCES Positions (PositionId),
--						HireDate DATE,
--						Gender CHAR(1),
--						Salary DECIMAL(7,2)		
--						)
						

--CREATE TABLE Sales (SaleId INT PRIMARY KEY IDENTITY, 
--						ClientId  INT FOREIGN KEY REFERENCES Clients(ClientId),
--						EmployeeId  INT FOREIGN KEY REFERENCES Employees(EmployeeId),
--						SaleDate DATE		
--						)
												

--CREATE TABLE SelesProducts (
--						SaleId INT FOREIGN KEY REFERENCES Sales(SaleId) ,
--						ProductId INT FOREIGN KEY REFERENCES Products(ProductId),
--						SaleQuantity INT,
--						PRIMARY KEY(SaleId, ProductId)
--						)

