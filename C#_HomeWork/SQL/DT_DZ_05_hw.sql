USE Academy

----1.

--SELECT COUNT(*) [Count teacher of Software Development]
--FROM Teachers T
--	JOIN Departments D ON T.DepartmentId = D.Id AND D.Id = 4


----2. Вывести количество лекций, которые читает преподаватель “Dave McQueen”.

--SELECT COUNT(*) [Count Dave McQueen's lectures]
--FROM Lectures L
--	JOIN Teachers T ON L.TeacherId = T.Id AND T.Name LIKE 'Dave' AND Surname LIKE 'McQueen'


----3. Вывести количество занятий, проводимых в аудитории “D201”.

--SELECT COUNT(*) [Count lectures of room D201]
--FROM Lectures
--WHERE LectureRoom LIKE 'D201'


----4. Вывести названия аудиторий и количество лекций, проводимых в них.

--SELECT LectureRoom, S.Name
--FROM Lectures L
--	JOIN Subjects S ON S.Id = L. SubjectId


----5. Вывести количество студентов, посещающих лекции преподавателя “Jack Underhill”.

--SELECT COUNT(*) [Count student of Jack Underhill's lectures]
--FROM Students S
--	JOIN Lectures L ON L.Id = S.LectureId
--	JOIN Teachers T ON T.Id = L.TeacherId AND T.Name LIKE 'Jack' 


----6. Вывести среднюю ставку преподавателей факультета “Computer Science”.

--SELECT D.Name, AVG(Salary) 'Average salary of department “Computer Science”'
--FROM Teachers T
--	JOIN Departments D ON D.Id = T.DepartmentId
--GROUP BY D.Name
--HAVING D.Name LIKE 'Computer Science'


----7. Вывести минимальное и максимальное количество студентов среди всех групп.

----SELECT MIN(sc) 
----FROM(
----	SELECT Name ,COUNT(*) sc
----	FROM Groups G
----		JOIN Students S ON S.GroupId = G.Id
----	GROUP BY G.Name
----	)
 
	
----8. Вывести средний фонд финансирования кафедр.

--SELECT AVG(Financing)
--FROM Departments


----9. Вывести полные имена преподавателей и количество читаемых ими дисциплин.

--SELECT Name + ' ' + Surname AS [Full Name], COUNT(L.Id) AS [Lectures count]
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--GROUP BY Name + ' ' + Surname


----10. Вывести количество лекций в каждый день недели.

--SELECT DayOfWeek , COUNT(L.Id) AS [Lectures count]
--FROM Lectures L
--GROUP BY DayOfWeek


----11. Вывести номера аудиторий и количество кафедр, чьи лекции в них читаются.

--SELECT LectureRoom , COUNT(L.Id) AS [Departments count]
--FROM Lectures L
--	JOIN Subjects S ON S.Id = L.SubjectId
--	JOIN Departments D ON D.Id = S.DepartmentId
--GROUP BY LectureRoom


----12. Вывести названия факультетов и количество дисциплин, которые на них читаются.

--SELECT F.Name , COUNT(S.Id) AS [Subjects count]
--FROM Faculties F
--	JOIN Departments D ON D.FacultyId = F.Id
--	JOIN Subjects S ON S.DepartmentId = D.Id	
--GROUP BY F.Name 


----13. Вывести количество лекций для каждой пары преподаватель-аудитория.

SELECT Name + ' ' + Surname [Full Name], L.LectureRoom, COUNT(*) [Lectures count]
FROM Teachers T
	JOIN Lectures L ON L.TeacherId = T.Id
GROUP BY Name + ' ' + Surname, L.LectureRoom
	

