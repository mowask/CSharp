--USE Academy

--1
--SELECT Name
--FROM Departments
--ORDER BY Name DESC

--2
--SELECT Name [Group Name], Rating [Group Rating]
--FROM Groups

--3
--SELECT Surname, Salary, Premium
--FROM Teachers

--4
--SELECT  CONCAT('The dean of ', Name, ' is dean ', Dean) 
--FROM Faculties

--5
--SELECT Surname
--FROM Teachers
--WHERE IsProfessor=1 AND Salary>1050

--6
--SELECT Name
--FROM Departments
--WHERE Financing<11000 OR Financing>25000

--7
--SELECT Name
--FROM Faculties
--WHERE Name NOT LIKE 'Computer Science'

--8
--SELECT Surname, Position
--FROM Teachers
--WHERE IsProfessor=0

--9
--SELECT Surname, Position, Salary, Premium
--FROM Teachers
--WHERE IsAssistant=1 AND Premium>=160 AND Premium <550

--10
--SELECT Surname, Salary
--FROM Teachers
--WHERE IsAssistant=1

--11
--SELECT Surname, Position
--FROM Teachers
--WHERE Year(EmploymentDate)>2000

--12
--SELECT Name AS [Name of Department]
--FROM Departments
--WHERE Name < 'Software Develolopment'
--ORDER BY Name ASC

--13
--SELECT Surname
--FROM Teachers
--WHERE IsAssistant=1 AND Premium+Salary<=1200

--14
--SELECT Name
--FROM Groups
--WHERE Year=5 
--AND Rating>=2 AND Rating<=4

--15
SELECT Surname
FROM Teachers
WHERE IsAssistant=1 
AND Salary<=550 OR Premium<200
