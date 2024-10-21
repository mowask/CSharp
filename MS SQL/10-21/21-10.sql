--USE Univresity
--SELECT  FirstName+' '+LastName AS Name, Grants
--FROM Students S
--	WHERE Grants > (
--		SELECT AVG(Grants)
--		FROM Students
--		)


--USE Shop
--SELECT ProductName, Price
--FROM Products
--WHERE Price < ( 
--		SELECT AVG(Price)
--		FROM Products)	


--USE Shop
--SELECT  FirstName+' '+LastName AS Name
--FROM Customers C
--WHERE C.CustomerID IN ( 
--	SELECT CustomerID
--	FROM Orders O
--	WHERE OrderID IN (
--		SELECT OrderID
--		FROM OrderProducts OP
--		WHERE OP.OrderID IN (
--			SELECT ProductID
--			FROM Products
--			WHERE Price >800
--			)
--		)
--	)


--USE Shop
--SELECT  FirstName+' '+LastName AS Name
--FROM Customers C
--WHERE C.CustomerID IN ( 
--	SELECT CustomerID
--	FROM Orders 
--	WHERE MONTH(OrderDate) = 4
--		)	

--USE Shop
--SELECT  FirstName+' '+LastName AS Name
--FROM Customers C
--WHERE C.CustomerID IN ( 
--	SELECT CustomerID
--	FROM Orders 
--	WHERE OrderDate= (
--		SELECT MAX(OrderDate)
--		FROM Orders
--		)	
--	)
			
		
--USE Shop
--SELECT OrderID, OrderDate
--FROM Orders
--WHERE OrderID IN(
--	SELECT OrderID
--	FROM OrderProducts
--	WHERE ProductID IN (
--		SELECT ProductID
--		FROM OrderProducts
--		GROUP BY ProductID
--		HAVING COUNT(*) >= 3
--		)
--	)


--SELECT P.ProductName, (
--	SELECT MAX(OP.Quantity)
--	FROM OrderProducts OP
--	WHERE P.ProductID = OP.ProductID ) AS MaximumQuantity
--FROM Products P


--USE Univresity
--SELECT S.FirstName, S.LastName, (
--	SELECT AVG(Grants)
--	FROM Students S2
--	WHERE S2.GroupId = S.GroupId
--	)
--FROM Students S


--USE Univresity
--SELECT S.FirstName, S.LastName, (
--	SELECT GroupName
--	FROM Groups G
--	WHERE G.Id = S.GroupId
--	) AS GroupName
--FROM Students S