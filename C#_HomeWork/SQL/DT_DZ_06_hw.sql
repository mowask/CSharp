--USE Academy6

----1. Вывести номера корпусов, если суммарный фонд финансирования расположенных в них кафедр превышает 100000.

--SELECT Building, SUM (Financing)
--FROM Departments
--GROUP BY Building
--HAVING SUM(Financing) >100000;


----2. Группы 5 курса кафедры "Software Development", которые имеют более 10 пар в первую неделю.

--SELECT Name, COUNT (*)
--FROM Groups G
--	JOIN GroupsLectures GL ON GL.GroupId = G.Id
--GROUP BY Name
--HAVING COUNT(*) > 10


----3. Вывести названия групп, имеющих рейтинг (средний рейтинг всех студентов группы) больше, чем рейтинг группы “D221”.

--SELECT G.Name, AVG(Rating)
--FROM Groups G
--	JOIN GroupsStudents GS ON GS.GroupId = G.Id
--	JOIN Students S ON S.Id = GS.StudentId
--GROUP BY G.Name
--HAVING AVG(Rating) > (SELECT AVG (Rating)
--		FROM Groups G
--			JOIN GroupsStudents GS ON GS.GroupId = G.Id
--			JOIN Students S ON S.Id = GS.StudentId
--		WHERE G.Name = 'D221'
--		AND GS.StudentId = S.Id
--		AND GS.GroupId = G.Id)


----4. Вывести фамилии и имена преподавателей, ставка которых выше средней ставки профессоров.

--SELECT Surname, Name, Salary
--FROM Teachers
--WHERE Salary > (
--	SELECT AVG(Salary)
--	FROM Teachers
--	WHERE IsProfessor = 1 )


----5. Вывести названия групп, у которых больше одного куратора.

--SELECT Name, COUNT(*)
--FROM Groups G
--	JOIN GroupsCurators GC ON GC.GroupId = G.Id
--GROUP BY Name
--HAVING COUNT(*) >1

----6. Вывести названия групп, имеющих рейтинг (средний рейтинг всех студентов группы) меньше, 
----   чем минимальный рейтинг групп 5-го курса.

--SELECT G.Name, AVG(Rating) AS R
--FROM Groups G
--	JOIN GroupsStudents GS ON GS.GroupId = G.Id
--	JOIN Students S ON S.Id = GS.StudentId
--GROUP BY G.Name
--HAVING AVG(Rating) < (SELECT MIN(Rating)
--		FROM Groups G
--			JOIN GroupsStudents GS ON GS.GroupId = G.Id
--			JOIN Students S ON S.Id = GS.StudentId
--		WHERE G.Year = 5
--		AND GS.StudentId = S.Id
--		AND GS.GroupId = G.Id)


----7. Вывести названия факультетов, суммарный фонд финансирования кафедр которых больше суммарного фонда
----	финансирования кафедр факультета “Computer Science”.

--SELECT F.Name, SUM(Financing)
--FROM Faculties F
--	JOIN Departments D ON D.FacultyId = F.Id
--GROUP BY F.Name
--HAVING SUM(Financing) > ( SELECT SUM(Financing)
--						FROM Faculties F
--						JOIN Departments D ON D.FacultyId = F.Id
--						WHERE F.Name LIKE 'Computer Science' )


----8. Вывести названия дисциплин и полные имена преподавателей, читающих наибольшее количество лекций по ним.

--SELECT S.Name , T.Name + ' ' + T.Surname [Full Name], COUNT(*) AS [Lectures Count]
--FROM Subjects S
--	JOIN Lectures L ON L.SubjectId = S.Id
--	JOIN Teachers T ON T.Id = L.TeacherId
--GROUP BY S.Name,  T.Name + ' ' + T.Surname
--HAVING COUNT(*) = (
--				SELECT MAX(C)  
--				FROM (
--					SELECT COUNT(*) AS C
--					FROM Subjects S
--						JOIN Lectures L ON L.SubjectId = S.Id
--						JOIN Teachers T ON T.Id = L.TeacherId
--					GROUP BY S.Name,  T.Name + ' ' + T.Surname ) AS C
--					)


----9. Вывести название дисциплины, по которому читается меньше всего лекций.

--SELECT S.Name, COUNT(*) AS [Lectures Count]
--FROM Subjects S
--	JOIN Lectures L ON L.SubjectId = S.Id	
--GROUP BY S.Name
--HAVING COUNT(*) = (
--				SELECT MIN(C)  
--				FROM (
--					SELECT COUNT(*) AS C
--					FROM Subjects S
--						JOIN Lectures L ON L.SubjectId = S.Id						
--					GROUP BY S.Name) AS C
--					)


----10. Вывести количество студентов и читаемых дисциплин на кафедре "Software Development" 

--SELECT COUNT(*) [Count]
--FROM Departments D
--JOIN Groups G ON G.DepartmrntId = D.Id
--JOIN GroupsStudents GS ON GS.GroupId = G.Id
--WHERE D.Name = 'Software Development'
--UNION ALL
--SELECT COUNT(*)
--FROM Departments D
--JOIN Groups G ON G.DepartmrntId = D.Id
--JOIN GroupsLectures GL ON GL.GroupId = G.Id
--WHERE D.Name = 'Software Development'