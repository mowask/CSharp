USE Academy7

------ 1 Вывести названия аудиторий, в которых читает лекции преподаватель “Edward Hopper”.

--SELECT LR.Name, T.Surname, T.Name
--FROM LectureRooms LR
--JOIN Schedules SCH ON SCH.LectureId = LR.Id
--JOIN Lectures L ON L.Id = SCH.Id
--JOIN Teachers T ON T.Id = L.TeacherId
--WHERE Surname = 'Hopper' AND T.Name = 'Edward'

------ 2

--SELECT LR.Name, T.Surname
--FROM LectureRooms LR
--JOIN Schedules SCH ON SCH.LectureId = LR.Id
--JOIN Lectures L ON L.Id = SCH.Id
--JOIN Teachers T ON T.Id = L.TeacherId
--JOIN Assistants A ON A.TeacherId = T.Id
--WHERE LR.Name = 'F505' 


-------- 3 Вывести дисциплины, которые читает преподаватель “Alex Carmack” для групп 5-го курса

--SELECT S.Name
--FROM Subjects S
--JOIN Lectures L ON L.SubjectId = S.Id
--JOIN Teachers T ON T.Id = L.TeacherId
--JOIN GroupsLectures GL ON GL.LectureId = L.Id
--JOIN Groups G ON G.Id = GL.GroupId
--WHERE Year = 5 AND T.Name = 'Alex' AND T.Surname = 'Carmack'


------ 4  Вывести фамилии преподавателей, которые не читают лекции по понедельникам

--SELECT T.Surname
--FROM Teachers T
--JOIN Lectures L ON L.TeacherId = T.Id
--JOIN Schedules SCH ON SCH.LectureId = L.Id
--WHERE SCH.DayOfWeek != 1


------ 5 Вывести названия аудиторий, с указанием их корпусов, в которых нет лекций в среду второй недели на третьей паре.

--SELECT Name, Building
--FROM LectureRooms LR
--JOIN Schedules SCH ON SCH.LectureId = LR.Id
--JOIN Lectures L ON L.Id = SCH.Id
--WHERE DayOfWeek != 3 AND Class != 3 AND Week != 2


------ 6 

--SELECT T.Name + ' ' + T.Surname AS Fullname
--FROM Teachers T
--JOIN Heads H ON H.TeacherId = T.Id
--JOIN Departments D ON D.HeadId = H.Id
--JOIN Faculties F ON F.Id = D.FacultyId
--WHERE F.Name = 'Computer Science' AND D.Name != 'Software Development' 


------ 7 Вывести список номеров всех корпусов, которые имеются в таблицах факультетов, кафедр и аудиторий.

--SELECT Building, 'Faculties'
--FROM Faculties 
--UNION ALL
--SELECT Building, 'Departments'
--FROM Departments
--UNION ALL
--SELECT Building, 'Auditories'
--FROM LectureRooms 

------ 8 Вывести полные имена преподавателей в следующем порядке: деканы факультетов, заведующие кафедрами, преподаватели, кураторы, ассистенты.

--SELECT T.Name + ' ' + T.Surname AS Fullname, 'Deens'
--FROM Teachers T
--JOIN Deans DN ON DN.TeacherId = T.Id
--UNION ALL
--SELECT T.Name + ' ' + T.Surname AS Fullname, 'Heads'
--FROM Teachers T
--JOIN Heads H ON H.TeacherId = T.Id
--UNION ALL
--SELECT T.Name + ' ' + T.Surname AS Fullname, 'Teachers'
--FROM Teachers T
--UNION ALL
--SELECT T.Name + ' ' + T.Surname AS Fullname, 'Curators'
--FROM Teachers T
--JOIN Curators C ON C.TeacherId = T.Id
--UNION ALL
--SELECT T.Name + ' ' + T.Surname AS Fullname, 'Assistanse'
--FROM Teachers T
--JOIN Assistants A ON A.TeacherId = T.Id


------ 9 Вывести дни недели (без повторений), в которые имеются занятия в аудиториях “A311” и “A104” корпуса 6.

--SELECT DayOfWeek
--FROM Schedules
--JOIN LectureRooms LR ON LR.Id = Schedules.LectureRoomId
--WHERE Name = 'A104' AND Building = 3
--UNION 
--SELECT DayOfWeek
--FROM Schedules
--JOIN LectureRooms LR ON LR.Id = Schedules.LectureRoomId
--WHERE Name = 'A311' AND Building = 3
