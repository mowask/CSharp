USE Imports
--SELECT ImporterName, ProductName, Quantity, UnitPrice, Quantity* UnitPrice [Price], 
--				SUM(Quantity)[SUM Quantity], 
--				SUM(Quantity* UnitPrice) [SUM PRICE]
--FROM ProductImports PI JOIN Importers I
--	ON PI.ImporterID = I.ImporterID
--JOIN Products P ON P.ProductsID = PI.ProductID
--GROUP BY ImporterName, ProductName, Quantity, UnitPrice, Quantity* UnitPrice


--SELECT I.ImporterCountry, ProductName
--FROM ProductImports PI 
--	JOIN Products P	ON PI.ProductID = P.ProductsID
--	JOIN Importers I ON PI.ImporterID = I.ImporterID
--GROUP BY I.ImporterCountry, ProductName
--ORDER BY ImporterCountry, ProductName


--SELECT SUM(Quantity* UnitPrice)
--FROM ProductImports PI 
--	JOIN Products P ON P.ProductsID = PI.ProductID
--WHERE MONTH(ImportDate) BETWEEN 1 AND 3

SELECT MONTH(ImportDate)[MONTH], YEAR(ImportDate)[YEAR], SUM(Quantity* UnitPrice)[SUM]
FROM ProductImports PI 
	JOIN Products P ON P.ProductsID = PI.ProductID
GROUP BY MONTH(ImportDate), YEAR(ImportDate)
