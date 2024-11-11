USE SportsShop
GO


---------------------- 1  ���������������� ������� ���������� ���������� ���������� �����������

--ALTER FUNCTION GetCount ()
--RETURNS INT
--AS
--BEGIN 
--	DECLARE @count INT 
--	SELECT @count = COUNT(*) 
--	FROM Clients
--RETURN @count
--END;

--SELECT dbo.GetCount()


---------------------- 2 ���������������� ������� ���������� ������� ���� ������ ����������� ����

--ALTER FUNCTION getAvgPrice (@category INT)
--RETURNS DECIMAL(7,2)
--AS
--BEGIN
--    DECLARE @avgPrice DECIMAL(7, 2);
    
--    SELECT @avgPrice =  AVG(SellPrice) 
--    FROM Products
--    WHERE @category = CategoryID;
    
--    RETURN @avgPrice;
--END;

--SELECT dbo.getAvgPrice(2)


---------------------- 3 ���������������� ������� ���������� ������� ����������� �� ������ ����, ����� �������������� �������

--CREATE FUNCTION getAvgSales ()
--RETURNS DECIMAL(7,2)
--AS
--BEGIN
--    DECLARE @avgSale DECIMAL(7, 2);
    
--    SELECT @avgSale =  AVG(SellPrice) 
--    FROM Products  
--    RETURN @avgPrice;
--END;

--ALTER FUNCTION getAvgSalesByDate ()
--RETURNS DECIMAL(7,2)
--BEGIN
--    RETURN (
--        SELECT AVG(SP.SaleQuantity * P.SellPrice) AS AvgSalePrice
--        FROM SalersProducts SP
--        JOIN Products P ON P.ProductID = SP.ProductID
--        JOIN Sales S ON S.SaleID = SP.SaleID        
--    );
--END;


---------------------- 4  

--CREATE FUNCTION getLastSoldProduct()
--RETURNS @result TABLE (
--    ProductID INT,
--    ProductName VARCHAR(100),    
--    SellPrice DECIMAL(7,2),
--	SaleDate DATE
--) AS 
--BEGIN
--    INSERT INTO @Result
--        SELECT  P.ProductID, ProductName, SellPrice, SaleDate          
--        FROM Products P
--		JOIN SalersProducts SP ON SP.ProductID = P.ProductID
--		JOIN Sales S ON S.SaleID = SP.SaleID
--    WHERE SaleDate = (SELECT MIN(SaleDate)
--					FROM Sales	)
--	RETURN
--END


---------------------- 5  

--CREATE FUNCTION getFirstSoldProduct()
--RETURNS @result TABLE (
--    ProductID INT,
--    ProductName VARCHAR(100),    
--    SellPrice DECIMAL(7,2),
--	SaleDate DATE
--) AS 
--BEGIN
--    INSERT INTO @Result
--        SELECT  P.ProductID, ProductName, SellPrice, SaleDate          
--        FROM Products P
--		JOIN SalersProducts SP ON SP.ProductID = P.ProductID
--		JOIN Sales S ON S.SaleID = SP.SaleID
--    WHERE SaleDate = (SELECT MIN(SaleDate)
--					FROM Sales	)
--	RETURN
--END
    

---------------------- 6  

--CREATE PROCEDURE GetProductsByCategory (@Category varchar(50))
--AS
--BEGIN
--    SELECT *
--    FROM Products P
--	JOIN Categories C ON C.CategoryID = P.CategoryID
--    WHERE CategoryName = @Category;
--END


---------------------- 7  

--	Clients don't have BirthDate  
