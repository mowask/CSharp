---- Insert data into Departments table
--INSERT INTO Departments (Name, Phone) VALUES
--('Department A', '555-1234'),
--('Department B', '555-5678'),
--('Department C', '555-9012');

---- Insert data into Subjects table
--INSERT INTO Subjects (Name) VALUES
--('Math'),
--('Science'),
--('History'),
--('English'),
--('Art');

---- Insert data into Teachers table
--INSERT INTO Teachers (LastName, FirstName, BirthDate, DepartmentId) VALUES
--('Smith', 'John', '1980-01-01', 1),
--('Doe', 'Jane', '1990-02-02', 2),
--('Johnson', 'Mike', '1975-03-03', 3),
--('Williams', 'Emily', '1995-04-04', 1),
--('Brown', 'David', '1985-05-05', 2),
--('Jones', 'Sarah', '1992-06-06', 3),
--('Miller', 'Thomas', '1978-07-07', 1),
--('Davis', 'Jennifer', '1998-08-08', 2),
--('Wilson', 'Michael', '1983-09-09', 3),
--('Taylor', 'Ashley', '1993-10-10', 1);

---- Insert data into TeachersSubject table
--INSERT INTO TeachersSubjects(TeacherId, SubjectId) VALUES
--(1, 1),
--(1, 2),
--(2, 2),
--(2, 3),
--(3, 3),
--(3, 4),
--(4, 4),
--(4, 5),
--(5, 5),
--(5, 1),
--(6, 1),
--(6, 2),
--(7, 2),
--(7, 3),
--(8, 3),
--(8, 4),
--(9, 4),
--(9, 5),
--(10, 5),
--(10, 1);

--INSERT INTO TeachersSubjects VALUES (50,50)


--USE Univresity
--SELECT FirstName + ' ' + LastName AS FullName, Name, D.Id AS Departments
--FROM Departments AS D, Teachers AS T
--WHERE T.DepartmentId = D.Id

--USE Univresity
--SELECT FirstName + ' ' + LastName AS FullName, S.Name AS Subjects
--FROM Subjects AS S, Teachers AS T, TeachersSubjects AS TS
--WHERE S.Id = TS.SubjectId AND TS.TeacherId = T.Id

--USE Univresity
--SELECT TeacherId AS Id, FirstName + ' ' + LastName AS FullName, S.Name AS Subjects, D.Name AS Departments
--FROM Subjects AS S, Teachers AS T, TeachersSubjects AS TS, Departments AS D
--WHERE TS.TeacherId = T.Id AND S.Id = TS.SubjectId And D.Id = T.DepartmentId

--	--//Счетчик Уникальные значения//
--SELECT COUNT(DISTINCT FirstName) AS [Uniq of Name]
--FROM Students

--	--//среднее значение//
--SELECT AVG(Grants) AS [Average grants]
--FROM Students

--	--//текущая дата//
--SELECT GETDATE ()

----//разница между датами//
--SELECT DATEDIFF(Year, '1980-01-01', GETDATE())


--SELECT FirstName + ' ' + LastName AS FullName, DATEDIFF(Year, BirthDate, GETDATE()) AS Age
--FROM Students

--SELECT AVG( DATEDIFF(Year, BirthDate, GETDATE())) AS 'Average Age'
--FROM Students

--SELECT AVG( DATEDIFF(DAY, BirthDate, GETDATE())/362.25) AS 'Average Age'
--FROM Students

--SELECT SUM(Grants) AS [Sum grants]
--FROM Students

--SELECT MIN(BirthDate) AS [Min date of Bith]
--FROM Students

--SELECT MAx(LastName) AS [Max Last Name]
--FROM Students

----// Кол-во студентов Имя который начинается на J
--SELECT COUNT(*) AS [Number of students]
--FROM Students
--WHERE FirstName LIKE 'J%';


--SELECT COUNT(*) AS Count, AVG(Grants) AS [Average Grants]
--FROM Students
--WHERE LastName LIKE '[TM]%'; 

----------------------------------------
--//СЧЕТЧИК С РАЗБИВКОЙ ПО ГРУППАМ //
--SELECT  GroupName, COUNT(S.GroupId) AS [Number of students]
--FROM Students S, Groups G
--WHERE S.GroupId = G.Id
--GROUP BY GroupName;


--SELECT  D.Name, COUNT(*) AS [Count D]
--FROM Departments D, Teachers T
--WHERE D.Id = T.DepartmentId
--GROUP BY D.Name; 

--SELECT  S.Name, COUNT(*) AS [Count S]
--FROM Subjects S, Teachers T, TeachersSubjects TS
--WHERE T.Id = TS.SubjectId AND S.Id = TS.SubjectId
--GROUP BY S.Name; 


SELECT GroupName, COUNT(*) AS [Number of strudents]
FROM Groups G, Students S
WHERE G.Id = S.GroupId
GROUP BY GroupName
HAVING COUNT(*) >5;
