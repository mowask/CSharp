USE Academy
------1. Вывести все возможные пары строк преподавателей и групп.

--SELECT T.Name + ' ' + Surname AS [Full Name], G.Name
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId


------2. Вывести названия факультетов, фонд финансирования кафедр которых превышает фонд финансирования факультета.

--SELECT F.Name
--FROM Faculties F
--	JOIN Departments D ON D.FacultyId = F.Id
--WHERE D.Financing > F.Financing


------3. Вывести фамилии кураторов групп и названия групп, которые они курируют.

--SELECT Surname, G.Name [Group]
--FROM Curators C
--	JOIN GroupsCurators GC ON GC.CuratorId = C.Id
--	JOIN Groups G ON G.Id = GC.GroupId


------4. Вывести имена и фамилии преподавателей, которые читают лекции у группы “P107”.

--SELECT T.Name + ' ' + Surname AS [Full Name], G.Name
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--WHERE G.Name LIKE 'P107'
	


------5. Вывести фамилии преподавателей и названия факультетов на которых они читают лекции.

--SELECT T.Name + ' ' + Surname AS [Full Name], G.Name
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--	JOIN Departments D ON D.Id = G.DepartmentId
--	JOIN Faculties F ON F.Id = D.FacultyId


------6. Вывести названия кафедр и названия групп, которые к ним относятся.

--SELECT D.Name, G.Name
--FROM Departments D
--	JOIN Groups G ON G.DepartmentId = D.Id


------7. Вывести названия дисциплин, которые читает преподаватель “Samantha Adams”.

--SELECT S.Name
--FROM Lectures L	
--	JOIN Subjects S ON S.Id = L.SubjectId
--	JOIN Teachers T ON L.TeacherId = T.Id AND T.Name LIKE 'Samantha' AND Surname LIKE 'Adams'


------8. Вывести названия кафедр, на которых читается дисциплина "Database Theory"

--SELECT D.Name
--FROM Subjects S
--	JOIN Lectures L ON L.SubjectId = S.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--	JOIN Departments D ON D.Id = G.DepartmentId
--WHERE S.Name LIKE 'Database Theory'


------9. Вывести названия групп, которые относятся к факультету “Computer Science”.

--SELECT G.Name
--FROM Groups G
--	JOIN Departments D ON D.Id = G.DepartmentId
--	JOIN Faculties F ON F.Id = D.FacultyId
--WHERE F.Name LIKE 'Computer Science'
	

------10. Вывести названия групп 5-го курса, а также название факультетов, к которым они относятся.

--SELECT G.Name, F.Name
--FROM Groups G
--	JOIN Departments D ON D.Id = G.DepartmentId
--	JOIN Faculties F ON F.Id = D.FacultyId
--WHERE G.Year = 5


------11. Вывести полные имена преподавателей и лекции, которые они читают (названия дисциплин и групп), причем отобрать
------	только те лекции, которые читаются в аудитории “B103”.

--SELECT T.Name + ' ' + Surname AS [Full Name], S.Name [Subject], G.Name [Group]
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN Subjects S ON S.Id = L.SubjectId
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--WHERE L.LectureRoom LIKE 'B103'