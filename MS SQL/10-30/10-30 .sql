USE SportShop

--DECLARE @avgNetPrice DECIMAL(7,2),
--		@avgSellPrice DECIMAL(7,2)

--SELECT @avgNetPrice = AVG(NetPrice), 
--		@avgSellPrice = AVG(SellPrice)
--FROM Products

--SELECT 'NetPrice', @avgNetPrice
--UNION ALL
--SELECT 'SellPrice', @avgSellPrice
--UNION ALL
--SELECT 'Margin' , @avgSellPrice - @avgNetPrice



--DECLARE @count INT
--SET @count = 10
--IF @count >10
--	BEGIN
--		SELECT 'count is more then 10'
--	END
--ELSE
--	BEGIN
--		SELECT 'count is less than 10'
--	END



DECLARE @count INT = 0
DECLARE @sum INT = 0

--WHILE @count <=5
--	BEGIN
--		SET @sum = @sum + @count
--		SET @count = @count +1
--	END
--SELECT 'SUM of numbers of 1 to 5 is ' + CONVERT(NVARCHAR, @sum)

WHILE @count <= 100	
	BEGIN	
		SET @sum = @sum + @count
		SET @count = @count +2
	END
SELECT 'SUM of odd numbers of 0 to 100 is ' + CONVERT(NVARCHAR, @sum)


