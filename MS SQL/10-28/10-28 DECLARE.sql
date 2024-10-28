
--DECLARE @MyCounter INT

--DECLARE @name NVARCHAR(20), @age INT;
--SET @name = 'John';
--SET @age = 18;
--SELECT @name AS [Name], @age AS [Age]


--PRINT @name;


--DECLARE @product NVARCHAR(30), @price MONEY
--SET @product = 'Chocolate';
--SET @price = 99;
--SELECT @product product , @price price


--USE Shop
--DECLARE @count INT,
--		@maxPrice DECIMAL(10,2),
--		@minPrice DECIMAL (10,2);

--SELECT @count = COUNT (*),
--		@maxPrice = MAX(Price),
--		@minPrice = MIN(Price)
--FROM Products

--	SELECT 'There are ' + CONVERT(NVARCHAR, @count) + ' products'
--UNION ALL
--SELECT 'Price range from ' + CONVERT(NVARCHAR, @minPrice) + ' to ' + CONVERT(NVARCHAR, @maxPrice);


USE Univresity
DECLARE @count INT,
		@avg DECIMAL(10,2),
		@sum DECIMAL (10,2);

SELECT @count = COUNT (*),
		@avg = AVG(Grants),
		@sum = SUM(Grants)
FROM Students

SELECT CONVERT(NVARCHAR, @count)
UNION ALL
SELECT  CONVERT(NVARCHAR, @sum)
UNION ALL
SELECT  CONVERT(NVARCHAR, @avg)

SELECT @count, @sum,@avg


