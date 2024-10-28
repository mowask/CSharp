--USE Univresity

--SELECT * 
--FROM Groups INNER JOIN Students
--ON Groups.Id = Students.GroupId


--SELECT FirstName, LastName, Name AS Subject, Assesment, GroupName
--FROM Groups AS G, Students AS S
--	ON G.Id=S.GroupId
--JOIN Achievments AS A ON S.Id = A.studentId
--JOIN SUBJECTS AS Sb ON Sb.Id = A = SubjectId


--USE Shop
--SELECT O.OrderID, OrderDate, ProductName, Quantity,Price, Quantity*Price [Full Price]
--FROM OrderProducts OP JOIN Orders O
--	ON OP.OrderID = O.OrderID
--JOIN Products P 
--	ON OP.ProductID = P.ProductID


--USE Univresity
--SELECT FirstName + ' ' + LastName AS FullName,  AVG(Assesment)[Average]
--FROM Students AS S LEFT JOIN Achievements AS A
--	ON S.Id = A.StudentId
--GROUP BY S.FirstName, LastName
--ORDER BY [Average] DESC


--USE Univresity
--SELECT FirstName + ' ' + LastName AS FullName, Assesment
--FROM Students AS S LEFT JOIN Achievements AS A
--	ON S.Id = A.StudentId
--WHERE Assesment IS NOT NULL


--SELECT FirstName, LastName, GroupName
--FROM Students AS S FULL JOIN Groups AS G
--	ON G.Id = S.Id
--ORDER BY FirstName


SELECT T.Id, FirstName + ' ' + LastName [Full Name], Name [SubjectName], AVG(Assesment)
FROM TeachersSubjects TS JOIN Teachers T
	ON T.Id = TS.TeacherId
JOIN Subjects S ON S.Id = TS.SubjectId
JOIN Achievements A ON A.SubjectId = S.Id
GROUP BY  FirstName + ' ' + LastName, T.Id, Name
