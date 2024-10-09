--SELECT LastName, FirstName, BirthDate, Grants, Email
--FROM Students

--SELECT *
--FROM Students

--SELECT LastName AS Name
--FROM Students

--SELECT FirstName +' ' + LastName AS FullName, BirthDate, Grants, Email
--FROM Students

--SELECT FirstName +' ' + LastName AS FullName, Grants, Grants*1.2 AS [Plus 20 percent]
--FROM Students


--SELECT 'Student ' + LastName, +'receives' + CAST(Grants AS nvarchar(10))
--FROM Students

--SELECT 'Student ' + LastName, +'receives ' + CONVERT(nvarchar(10), Grants)
--FROM Students


--SELECT TOP 2 LastName, FirstName, BirthDate
--FROM Students

--SELECT TOP 5 FirstName+ ' ' + LastName + ' was born ' + CONVERT (nvarchar, BirthDate) [History], Email
--FROM Students

--SELECT DISTINCT FirstName
--FROM Students

--SELECT LastName, Grants
--FROM Students
--WHERE Grants != 0

--SELECT *
--FROM Students
--WHERE LEN(FirstNAme) <=4

--SELECT *
--FROM Students
--WHERE MONTH(BirthDate) >= 4
--AND MONTH(BirthDate) <= 11

--SELECT TOP 4 LastName, YEAR(BirthDate)
--FROM Students
--WHERE YEAR(BirthDate) >= 1980
--AND YEAR(BirthDate) <= 2000

--SELECT FirstNAme +' '+ LastName, BirthDate
--FROM Students
--WHERE YEAR(BirthDate)%2 = 0
--OR DAY(BirthDate)%2 != 0

--SELECT FirstNAme +' '+ LastName, Grants
--FROM Students
--WHERE Grants IS NULL

--SELECT FirstNAme +' '+ LastName, Grants
--FROM Students
--WHERE Grants IS NOT NULL

--SELECT *
--FROM Students
--WHERE NOT LastName= 'Doe'


--SELECT LastName, FirstName, BirthDate
--FROM Students
--ORDER BY BirthDate

--SELECT LastName, FirstName, BirthDate
--FROM Students
--ORDER BY FirstName DESC, LastName ASC


--SELECT *
--FROM Students
--WHERE FirstName IN ('JOHN','David','Jack')


--SELECT *
--FROM Students
--WHERE BirthDate BETWEEN '1997-01-01' 
--AND '1998-12-31'

--SELECT *
--FROM Students
--WHERE FirstName BETWEEN 'A' 
--AND 'D'

--===============================================================

--1 FirstNAme LIKE 'J%'			// Jack, Jane, John ...
--2 FirstNAme LIKE '%[ck]'		// Book, Booc,		// кончается на любую из скобок
--3 FirstNAme LIKE '[ABCDEF]%'	//  = 4
--4 FirstNAme LIKE '[A-F]%'		// Начиная с любой из диапозона
--5 FirstNAme LIKE 'S%a'		// Sveta, Sa,		// перывая S последняя а
--6 FirstNAme LIKE '[^J]%'		// = FirstNAme NOT LIKE 'J%'	Не начинаются с J
--7 FirstNAme LIKE '_a%'		//	первая любая, вторая а, дальше неважно
--8 FirstNAme LIKE '%[Jj]%'		//	все где есть буква J j	

--=================================================================

--SELECT *
--FROM Students
--WHERE FirstName LIKE '%[j]%'


--INSERT INTO Students(BirthDate, FirstName, LastName)
--VALUES ('1998-05-25', 'Lily', 'Wilson');

INSERT INTO Students
VALUES ( 'Evans', 'Grace', '1998-05-25', NULL, 'eg@net.eu');
