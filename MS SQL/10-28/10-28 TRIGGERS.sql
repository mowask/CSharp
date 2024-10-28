--USE Shop

--CREATE TABLE ProductHistory (
--	ProductHistoryId INT PRIMARY KEY IDENTITY,
--	NoteDate DATETIME NOT NULL,
--	Note NVARCHAR(200) NOT NULL )

--USE Shop
--GO
--CREATE TRIGGER  Products_INSERT
--ON Products
--AFTER INSERT
--AS
--INSERT INTO ProductHistory (NoteDate, Note)
--SELECT GETDATE(),
--	'A Product with ID=' + CONVERT(NVARCHAR, ProductID)
--	+ ' , Name=' + ProductName + ' was Added'
--FROM INSERTED

--USE Shop
--INSERT INTO Products VALUES ('Milk', 150.00)


--USE Shop
--GO
--CREATE TRIGGER  Products_UPDATE
--ON Products
--AFTER UPDATE
--AS
--INSERT INTO ProductHistory (NoteDate, Note)
--SELECT GETDATE(),
--	'A Product with ID=' + CONVERT(NVARCHAR, ProductID)
--	+ ' , Name=' + ProductName + ', Price' + CONVERT(NVARCHAR, Price) + ' was Updated'
--FROM ISERTED


--USE Shop
--GO
--CREATE TRIGGER  Products_Delete
--ON Products
--AFTER DELETE
--AS
--INSERT INTO ProductHistory (NoteDate, Note)
--SELECT GETDATE(),
--	'A Product with ID=' + CONVERT(NVARCHAR, ProductID)
--	+ ' , Name=' + ProductName + ', Price' + CONVERT(NVARCHAR, Price) + ' was Deleted'
--FROM DELETED


USE Shop
GO
ALTER TRIGGER  Products_UPDATE
ON Products
AFTER UPDATE
AS
INSERT INTO ProductHistory (NoteDate, Note)
SELECT GETDATE(),
	'A Product with ID=' + CONVERT(NVARCHAR, I.ProductID)
	+ ' , Name=' + I.ProductName + ', Price changed from ' + CONVERT(NVARCHAR, D.Price)
	+ ' was Updated to ' + CONVERT(NVARCHAR, I.Price)
FROM INSERTED I
	JOIN DELETED D ON D.ProductId = I.ProductId