USE Shop

--SELECT OrderID, COUNT(*) , SUM(OP.Quantity * Price) AS[Total Price]
--FROM OrderProducts OP, Products P
--WHERE P.ProductID = OP.ProductID
--GROUP BY OP.OrderID

--SELECT OP.OrderID, P.ProductName, OP.Quantity, P.Price, OP.Quantity*P.Price [Total]
--FROM OrderProducts OP, Products P
--WHERE OP.ProductID = P.ProductID

--SELECT SUM(OP.Quantity*P.Price) [Total]
--FROM OrderProducts OP, Products P
--WHERE OP.ProductID = P.ProductID

--SELECT SUM(OP.Quantity*P.Price) [Total]
--FROM OrderProducts OP, Products P
--WHERE OP.ProductID = P.ProductID
--GROUP BY OP.OrderID

--SELECT P.ProductName, COUNT(OP.ProductID) AS [Order Count]
--FROM OrderProducts OP, Products P
--WHERE P.ProductID = OP.ProductID
--GROUP BY P.ProductName
--HAVING COUNT(*)>2
--ORDER BY COUNT(*)

--SELECT O.CustomerID, AVG(OP.Quantity*p.Price) AS Average
--FROM Orders O, OrderProducts OP, Products P
--WHERE O.OrderID = OP.OrderID AND P.ProductID=OP.ProductID
--GROUP BY O.CustomerID

--SELECT MONTH(O.OrderDate) AS Month , AVG(OP.Quantity*p.Price) AS Average
--FROM Orders O, OrderProducts OP, Products P
--WHERE O.OrderID = OP.ProductID AND P.ProductID=OP.ProductID
--GROUP BY MONTH(O.OrderDate)


----------------------------------------------------------------------------------
USE Univresity

--SELECT GroupName
--FROM Groups
--WHERE Id IN (SELECT GroupId
--		FROM Students
--		WHERE Grants = (
--			SELECT MAX(Grants)
--			FROM Students
--			)
--		)


--USE Shop
--SELECT CustomerID
--FROM Orders
--WHERE OrderDate = (SELECT MAX(OrderDate) FROM Orders);

USE Shop
SELECT OrderID
FROM OrderProducts 
WHERE ProductID IN (
	SELECT ProductID
	FROM OrderProducts
	GROUP BY ProductID
	HAVING COUNT(*) >3
	);

