USE Shop

--ALTER TABLE Orders
--ADD COLUMN NVARCHAR(50) OrderAdders NOT NULL DEFAULT '' FOREIGN KEY Table (Column)

--ALTER TABLE Orders
--DROP COLUMN OrderAddres;


------------------------------------------------------------

--//		UNION			//

--USE Univresity

--SELECT FirstName, LastName, BirthDate
--FROM Teachers
--WHERE FirstName LIKE 'J%'
--UNION
--SELECT FirstName, LastName, BirthDate
--FROM Students
--WHERE FirstName LIKE 'J%'
--ORDER BY BirthDate

--SELECT FirstName +' ' + LastName AS FullName, BirthDate
--FROM Teachers
--WHERE FirstName LIKE 'J%'
--UNION
--SELECT FirstName +' ' + LastName, BirthDate
--FROM Students
--WHERE FirstName LIKE 'J%'
--ORDER BY BirthDate


--SELECT FirstName +' ' + LastName AS FullName
--FROM Teachers
--UNION
--SELECT FirstName +' ' + LastName
--FROM Students

--SELECT FirstName +' ' + LastName AS FullName
--FROM Teachers
--UNION ALL
--SELECT FirstName +' ' + LastName
--FROM Students


--SELECT 'Sprimg' AS Season, COUNT(*) AS [Number of students]
--FROM Students
--WHERE MONTH(BirthDate) BETWEEN 3 AND 5
--UNION ALL 
--SELECT 'Summer' AS Season, COUNT(*) AS [Number of students]
--FROM Students
--WHERE MONTH(BirthDate) BETWEEN 6 AND 8
--UNION ALL
--SELECT 'Autumn' AS Season, COUNT(*) AS [Number of students]
--FROM Students
--WHERE MONTH(BirthDate) BETWEEN 8 AND 11
--UNION ALL
--SELECT 'Winter' AS Season, COUNT(*) AS [Number of students]
--FROM Students
--WHERE MONTH(BirthDate) IN (1,2,12);

--SELECT 'Teachers' AS [Group],  COUNT(*) AS Count
--FROM Teachers
--UNION ALL
--SELECT 'Students',  COUNT(*) 
--FROM Students


--USE Univresity
--SELECT COUNT (S.Id)
--FROM(
--	SELECT Id
--	FROM Students
--	UNION ALL
--	SELECT Id
--	FROM Teachers
--) AS S

--SELECT 'Teachers' AS [Group],  COUNT(*) AS Count
--FROM Teachers
--UNION ALL
--SELECT 'Students',  COUNT(*) 
--FROM Students
--UNION ALL
--SELECT 'Total',  COUNT(*) 
--FROM (
--	SELECT Id
--	FROM Teachers
--	UNION ALL
--	SELECT Id
--	FROM Students
--	) AS TS


-------------------------------------------------------------------------
	
--	//			JOIN			//


--USE Shop
--SELECT* 
--FROM ORDERS O, Customers C, OrderProducts OP
--WHERE O.CustomerID = C.CustomerID
--	AND OP.OrderID = O.OrderID
----			=
--USE Shop
--SELECT* 
--FROM ORDERS O 
--	JOIN Customers C ON O.CustomerID = C.CustomerID
--	JOIN OrderProducts OP ON OP.OrderID = O.OrderID


--USE Univresity
--SELECT FirstName, LastName, GroupName
--FROM Students S
--	JOIN Groups G ON S.GroupId = G.Id


USE HR
--SELECT C.Id			Candidate_id,
--		C.FullName	Candidate_name,
--		E.Id		Employee_Id,
--		E.FullName	Employee_name
--FROM Candidats C
--	INNER JOIN Employees E
--		ON E.FullName = C.FullName

--SELECT C.Id			Candidate_id,
--		C.FullName	Candidate_name,
--		E.Id		Employee_id,
--		E.FullName	Employee_name
--FROM Candidats C
--	RIGHT OUTER JOIN Employees E
--		ON E.FullName = C.FullName

--SELECT C.Id			Candidate_id,
--		C.FullName	Candidate_name,
--		E.Id		Employee_Id,
--		E.FullName	Employee_name
--FROM Candidats C
--	LEFT OUTER JOIN Employees E
--		ON E.FullName = C.FullName

--SELECT C.Id			Candidate_id,
--		C.FullName	Candidate_name,
--		E.Id		Employee_Id,
--		E.FullName	Employee_name
--FROM Candidats C
--	FULL OUTER JOIN Employees E
--		ON E.FullName = C.FullName

--SELECT C.Id			Candidate_id,
--		C.FullName	Candidate_name,
--		E.Id		Employee_Id,
--		E.FullName	Employee_name
--FROM Candidats C
--	FULL JOIN Employees E
--		ON E.FullName = C.FullName
--WHERE E.FullName IS NULL OR C.FullName IS NULL

USE Univresity
SELECT FirstName + ' ' + LastName AS Name, D.Name
FROM Teachers T 
	JOIN Departments D
		ON T.DepartmentId = D.Id
		
SELECT FirstName + ' ' + LastName AS Name, D.Name AS Department
FROM Teachers T 
	FULL JOIN Departments D
		ON T.DepartmentId = D.Id
WHERE T.DepartmentId IS NULL