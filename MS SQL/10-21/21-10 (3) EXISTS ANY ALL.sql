
--////////   EXISTS  

--SELECT S.FirstName
--FROM Students S
--WHERE EXISTS (
--	SELECT *
--	FROM Achievements A
--	WHERE A.StudentId = S.Id
--	)


--SELECT FirstName, LastName, BirthDate, Email
--FROM Students
--WHERE NOT EXISTS (SELECT *
--		FROM Achievements
--		WHERE Achievements.StudentId = Students.Id)


---------------------------------------------------

--////////   ANY 

--SELECT FirstName, LastName, BirthDate, Email
--FROM Students
--WHERE Id = ANY (SELECT StudentId
--		FROM Achievements
--		WHERE Assesment = 10);


--USE Shop
--SELECT DISTINCT OrderID
--FROM OrderProducts
--WHERE ProductID = ANY (SELECT ProductID
--			FROM Products
--			WHERE Price >500)


--USE Univresity
--SELECT COUNT(*) AS [COUNT]
--FROM Students
--WHERE BirthDate < ANY (SELECT BirthDate FROM Teachers)


--////////   ALL 

--USE Univresity
--SELECT COUNT(*) AS [COUNT]
--FROM Students
--WHERE BirthDate < ALL (SELECT BirthDate FROM Teachers)


--SELECT FirstName, LastName, Assesment, SubjectId
--FROM Students S, Achievements A
--WHERE A.StudentId = S.Id AND Assesment> ALL (
--			SELECT AVG(Assesment)
--			FROM Achievements
--			GROUP BY StudentId);


--SELECT S.Name, AVG(A.Assesment) Average
--FROM Subjects S, Achievements A
--WHERE S.Id = A.SubjectId 	
--GROUP BY S.Name

----SELECT S.Name, T.LastName, AVG(A.Assesment) Average
----FROM Subjects S, Achievements A, Teachers T, TeachersSubjects TS
----WHERE S.Id = A.SubjectId AND 
----		T.Id = TS.TeacherId AND 
----		S.Id = TS.SubjectId
----GROUP BY S.Name, T.LastName