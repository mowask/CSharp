USE Univresity
--SELECT GroupId
--FROM (SELECT  GroupId,COUNT(*) AS [StudentCount]
--		FROM Students
--		GROUP BY GroupId) AS R
--WHERE R.StudentCount =(SELECT MAX(R.StudentCount) AS [StudentCount]
--						FROM (
--							SELECT  GroupId,COUNT(*) AS [StudentCount]
--							FROM Students
--							GROUP BY GroupId) AS R
--						)


--SELECT  GroupId,COUNT(*) AS [StudentCount]
--FROM Students
--GROUP BY GroupId
--HAVING COUNT(*) =(SELECT MAX(R.StudentCount) AS [StudentCount]
--						FROM (
--							SELECT  GroupId,COUNT(*) AS [StudentCount]
--							FROM Students
--							GROUP BY GroupId) AS R
--						)


--SELECT FirstName, LastName, Grants
--FROM Students
--WHERE Grants= (
--	SELECT MIN(Grants)
--	FROM Students S )
	

USE Imports

--SELECT ProductName, UnitPrice
--FROM Products
--WHERE UnitPrice = (
--	SELECT MAX(UnitPrice)
--	FROM Products	)

--SELECT Name
--FROM Categories C
--	JOIN Products P ON P.CategoryID = C.CategoryID
--SELECT MIN (prodCount)
--FROM (
--	SELECT COUNT (*) AS prodCount
--	FROM Products) AS minCount

--SELECT P.CategoryID, C.Name, COUNT(*) AS [ProdCount]
--FROM Products P 
--	JOIN Categories C ON C.CategoryID = P.CategoryID
--GROUP BY P.CategoryID, C.Name
--HAVING COUNT(*) = (
--	SELECT MAX (R.ProdCount)
--	FROM (
--		SELECT CategoryID, COUNT(*) AS [ProdCount]
--		FROM Products
--		GROUP BY CategoryID
--	) AS R
--)


--SELECT P.CategoryID, C.Name, COUNT(*) AS [ProdCount]
--FROM Products P 
--	JOIN Categories C ON C.CategoryID = P.CategoryID
--GROUP BY P.CategoryID, C.Name
--HAVING COUNT(*) > (
--	SELECT AVG (R.ProdCount)
--	FROM (
--		SELECT CategoryID, COUNT(*) AS [ProdCount]
--		FROM Products
--		GROUP BY CategoryID
--	) AS R
--)



