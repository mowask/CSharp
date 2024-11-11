USE SportsShop
GO


---------------------- 1  Пользовательская функция возвращает количество уникальных покупателей

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


---------------------- 2 Пользовательская функция возвращает среднюю цену товара конкретного вида

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


---------------------- 3 Пользовательская функция возвращает среднюю ценупродажи по каждой дате, когда осуществлялись продажи

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

SELECT SaleDate , dbo.getAvgSalesByDate ()
FROM Sales
GROUP BY SaleDate