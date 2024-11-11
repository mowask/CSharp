USE Academy7

BEGIN TRANSACTION

INSERT INTO Departments (Building, Name, FacultyId, HeadId) VALUES 
(1, 'Software Development', 1, 2),  -- Head: Alex Carmack
(2, 'Pure Mathematics', 2, 4)       -- Head: Jane Smith

INSERT INTO Heads (TeacherId) VALUES 
(2),  -- Alex Carmack
(4)   -- Jane Smith

INSERT INTO Groups (Name, Year, DepartmentId) VALUES 
('F505', 5, 1),  -- Group from Software Development
('M101', 1, 2)   -- Group from Pure Mathematics

INSERT INTO Teachers (Name, Surname) VALUES 
('Edward', 'Hopper'),
('Alex', 'Carmack'),
('John', 'Doe'),
('Jane', 'Smith'),
('Michael', 'Johnson')

INSERT INTO Curators (TeacherId) VALUES 
(1),  -- Edward Hopper
(2)   -- Alex Carmack

INSERT INTO Deans (TeacherId) VALUES 
(1),  -- Edward Hopper
(3)   -- John Doe

INSERT INTO Faculties (Building, Name, DeanId) VALUES 
(1, 'Computer Science', 1),  -- Dean: Edward Hopper
(2, 'Mathematics', 2)        -- Dean: John Doe

INSERT INTO GroupsCurators (CuratorId, GroupId) VALUES 
(1, 1),  -- Curator: Edward Hopper for Group F505
(2, 2)   -- Curator: Alex Carmack for Group M101

INSERT INTO Assistants (TeacherId) VALUES 
(3),  -- John Doe
(4)   -- Jane Smith

INSERT INTO Subjects (Name) VALUES 
('Programming 101'),
('Calculus I'),
('Data Structures'),
('Linear Algebra')

INSERT INTO Lectures (SubjectId, TeacherId) VALUES 
(1, 1),  -- Programming 101 by Edward Hopper
(2, 2),  -- Calculus I by Alex Carmack
(3, 3),  -- Data Structures by John Doe
(4, 4)   -- Linear Algebra by Jane Smith

INSERT INTO GroupsLectures (GroupId, LectureId) VALUES 
(1, 1),  -- Group F505 attends Programming 101
(2, 2)   -- Group M101 attends Calculus I

INSERT INTO LectureRooms (Building, Name) VALUES 
(1, 'A101'),
(1, 'A102'),
(2, 'B201'),
(2, 'B202')

INSERT INTO Schedules (Class, DayOfWeek, Week, LectureId, LectureRoomId) VALUES 
(1, 1, 1, 1, 1),  -- Class 1, Monday, Week 1, Programming 101 in A101
(2, 2, 1, 2, 2),  -- Class 2, Tuesday, Week 1, Calculus I in A102
(3, 3, 1, 3, 3)   -- Class 3, Wednesday, Week 1, Data Structures in B201


IF (@@ERROR > 0)
	ROLLBACK TRANSACTION
ELSE COMMIT TRANSACTION