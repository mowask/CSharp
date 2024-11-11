USE SportsShop
GO

---------------- 1

--CREATE TRIGGER InsertProductTrigger
--ON Products
--INSTEAD OF INSERT
--AS
--BEGIN
--IF EXISTS (SELECT P.ProductName 
--               FROM Products P
--               JOIN inserted I ON P.ProductName = I.ProductName
--               ) 
--	BEGIN
--	UPDATE Products
--    SET Products.AvailableQuantity = P.AvailableQuantity + I.AvailableQuantity
--    FROM Products P
--    INNER JOIN inserted I ON P.ProductName = I.ProductName
--	END
--ELSE
--BEGIN
--	INSERT INTO Products(ProductName, CategoryID, AvailableQuantity, NetPrice,SellPrice, MakerID)
--	SELECT ProductName, CategoryID, AvailableQuantity, NetPrice,SellPrice, MakerID
--	FROM inserted I
--END
--END;

--INSERT INTO Products(ProductName, CategoryID, AvailableQuantity, NetPrice,SellPrice, MakerID) VALUES ('Ball' , 1, 10, 50, 100, 1)
--INSERT INTO Products(ProductName, CategoryID, AvailableQuantity, NetPrice,SellPrice, MakerID) VALUES ('Bottle' , 1, 5, 30, 90, 1)


---------------- 2 
--CREATE TABLE ArchiveEmployees (
--						Id INT PRIMARY KEY IDENTITY, 
--						FirstName NVARCHAR(50),
--						LastName NVARCHAR(50),
--						MiddleName NVARCHAR(50), 
--						PositionId INT FOREIGN KEY REFERENCES Positions (PositionId),
--						HireDate DATE,
--						DateLaidOff DATE,
--						Gender CHAR(1),
--						Salary DECIMAL(7,2))
--GO

--CREATE TRIGGER InsertArchiveEmployeesTrigger
--ON Employees
--AFTER DELETE
--AS
--BEGIN
--INSERT INTO ArchiveEmployees (FirstName,LastName,MiddleName,PositionId,HireDate,DateLaidOff,Gender,Salary )
--	SELECT E.FirstName,E.LastName, E.MiddleName, E.PositionId, E.HireDate, GETDATE(), E.Gender, E.Salary
--	FROM Deleted D
--	JOIN Employees E ON E.EmployeeID = D.EmployeeID;
--END;

---------------- 3

--ALTER TRIGGER BanInsertSellerTrigger
--ON Employees
--INSTEAD OF INSERT
--AS
--BEGIN
--	DECLARE @position int
--	SELECT @position = PositionID 
--	FROM Inserted I
--	DECLARE @count INT
--	SELECT @count = COUNT(*)
--	FROM Employees E
--	JOIN Positions P ON P.PositionID = E.PositionID
--	WHERE P.PositionName = 'Seller'

--IF @count > 6 AND @position = 5
--	SELECT 'Cannot be more Sellers'
--ELSE 
--BEGIN
--	INSERT INTO Employees (FirstName,LastName,MiddleName,PositionId,HireDate,Gender,Salary)
--	SELECT FirstName,LastName,MiddleName,PositionId,HireDate,Gender,Salary
--	FROM inserted I
--	END
--END;

--INSERT INTO Employees VALUES ('IVAN','IVANOVICH','PETROV', 5, '2020-11-11', 'M', 10000)



	
	



