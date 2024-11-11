USE Academy
------1. ������� ��� ��������� ���� ����� �������������� � �����.

--SELECT T.Name + ' ' + Surname AS [Full Name], G.Name
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId


------2. ������� �������� �����������, ���� �������������� ������ ������� ��������� ���� �������������� ����������.

--SELECT F.Name
--FROM Faculties F
--	JOIN Departments D ON D.FacultyId = F.Id
--WHERE D.Financing > F.Financing


------3. ������� ������� ��������� ����� � �������� �����, ������� ��� ��������.

--SELECT Surname, G.Name [Group]
--FROM Curators C
--	JOIN GroupsCurators GC ON GC.CuratorId = C.Id
--	JOIN Groups G ON G.Id = GC.GroupId


------4. ������� ����� � ������� ��������������, ������� ������ ������ � ������ �P107�.

--SELECT T.Name + ' ' + Surname AS [Full Name], G.Name
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--WHERE G.Name LIKE 'P107'
	


------5. ������� ������� �������������� � �������� ����������� �� ������� ��� ������ ������.

--SELECT T.Name + ' ' + Surname AS [Full Name], G.Name
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--	JOIN Departments D ON D.Id = G.DepartmentId
--	JOIN Faculties F ON F.Id = D.FacultyId


------6. ������� �������� ������ � �������� �����, ������� � ��� ���������.

--SELECT D.Name, G.Name
--FROM Departments D
--	JOIN Groups G ON G.DepartmentId = D.Id


------7. ������� �������� ���������, ������� ������ ������������� �Samantha Adams�.

--SELECT S.Name
--FROM Lectures L	
--	JOIN Subjects S ON S.Id = L.SubjectId
--	JOIN Teachers T ON L.TeacherId = T.Id AND T.Name LIKE 'Samantha' AND Surname LIKE 'Adams'


------8. ������� �������� ������, �� ������� �������� ���������� "Database Theory"

--SELECT D.Name
--FROM Subjects S
--	JOIN Lectures L ON L.SubjectId = S.Id
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--	JOIN Departments D ON D.Id = G.DepartmentId
--WHERE S.Name LIKE 'Database Theory'


------9. ������� �������� �����, ������� ��������� � ���������� �Computer Science�.

--SELECT G.Name
--FROM Groups G
--	JOIN Departments D ON D.Id = G.DepartmentId
--	JOIN Faculties F ON F.Id = D.FacultyId
--WHERE F.Name LIKE 'Computer Science'
	

------10. ������� �������� ����� 5-�� �����, � ����� �������� �����������, � ������� ��� ���������.

--SELECT G.Name, F.Name
--FROM Groups G
--	JOIN Departments D ON D.Id = G.DepartmentId
--	JOIN Faculties F ON F.Id = D.FacultyId
--WHERE G.Year = 5


------11. ������� ������ ����� �������������� � ������, ������� ��� ������ (�������� ��������� � �����), ������ ��������
------	������ �� ������, ������� �������� � ��������� �B103�.

--SELECT T.Name + ' ' + Surname AS [Full Name], S.Name [Subject], G.Name [Group]
--FROM Teachers T
--	JOIN Lectures L ON L.TeacherId = T.Id
--	JOIN Subjects S ON S.Id = L.SubjectId
--	JOIN GroupsLectures GL ON GL.LectureId = L.Id
--	JOIN Groups G ON G.Id= GL.GroupId
--WHERE L.LectureRoom LIKE 'B103'