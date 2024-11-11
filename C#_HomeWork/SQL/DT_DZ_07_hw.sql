USE Academy7

------ 1 ������� �������� ���������, � ������� ������ ������ ������������� �Edward Hopper�.

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


-------- 3 ������� ����������, ������� ������ ������������� �Alex Carmack� ��� ����� 5-�� �����

--SELECT S.Name
--FROM Subjects S
--JOIN Lectures L ON L.SubjectId = S.Id
--JOIN Teachers T ON T.Id = L.TeacherId
--JOIN GroupsLectures GL ON GL.LectureId = L.Id
--JOIN Groups G ON G.Id = GL.GroupId
--WHERE Year = 5 AND T.Name = 'Alex' AND T.Surname = 'Carmack'


------ 4  ������� ������� ��������������, ������� �� ������ ������ �� �������������

--SELECT T.Surname
--FROM Teachers T
--JOIN Lectures L ON L.TeacherId = T.Id
--JOIN Schedules SCH ON SCH.LectureId = L.Id
--WHERE SCH.DayOfWeek != 1


------ 5 ������� �������� ���������, � ��������� �� ��������, � ������� ��� ������ � ����� ������ ������ �� ������� ����.

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


------ 7 ������� ������ ������� ���� ��������, ������� ������� � �������� �����������, ������ � ���������.

--SELECT Building, 'Faculties'
--FROM Faculties 
--UNION ALL
--SELECT Building, 'Departments'
--FROM Departments
--UNION ALL
--SELECT Building, 'Auditories'
--FROM LectureRooms 

------ 8 ������� ������ ����� �������������� � ��������� �������: ������ �����������, ���������� ���������, �������������, ��������, ����������.

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


------ 9 ������� ��� ������ (��� ����������), � ������� ������� ������� � ���������� �A311� � �A104� ������� 6.

--SELECT DayOfWeek
--FROM Schedules
--JOIN LectureRooms LR ON LR.Id = Schedules.LectureRoomId
--WHERE Name = 'A104' AND Building = 3
--UNION 
--SELECT DayOfWeek
--FROM Schedules
--JOIN LectureRooms LR ON LR.Id = Schedules.LectureRoomId
--WHERE Name = 'A311' AND Building = 3
