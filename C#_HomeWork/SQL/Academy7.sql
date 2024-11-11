--CREATE DATABASE Academy7
--GO

USE Academy7
GO

CREATE TABLE Teachers (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Name NVARCHAR(MAX) NOT NULL,
    Surname NVARCHAR(MAX) NOT NULL
)

CREATE TABLE Curators (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TeacherId INT NOT NULL FOREIGN KEY REFERENCES Teachers(Id)
)

CREATE TABLE Deans (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TeacherId INT NOT NULL FOREIGN KEY REFERENCES Teachers(Id)
)

CREATE TABLE Faculties (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Building INT CHECK (Building BETWEEN 1 AND 5) NOT NULL,
    Name NVARCHAR(100) UNIQUE NOT NULL,
    DeanId INT NOT NULL FOREIGN KEY REFERENCES Deans(Id)
)

CREATE TABLE Heads (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TeacherId INT NOT NULL FOREIGN KEY REFERENCES Teachers(Id)
)

CREATE TABLE Departments (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Building INT CHECK (Building BETWEEN 1 AND 5) NOT NULL,
    Name NVARCHAR(100) UNIQUE NOT NULL,
    FacultyId INT NOT NULL FOREIGN KEY REFERENCES Faculties(Id),
    HeadId INT NOT NULL FOREIGN KEY REFERENCES Heads(Id)
)

CREATE TABLE Groups (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Name NVARCHAR(10) UNIQUE NOT NULL,
    Year INT CHECK (Year BETWEEN 1 AND 5) NOT NULL,
    DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE GroupsCurators (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    CuratorId INT NOT NULL FOREIGN KEY REFERENCES Curators(Id),
    GroupId INT NOT NULL FOREIGN KEY REFERENCES Groups(Id)
)

CREATE TABLE Assistants (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    TeacherId INT NOT NULL FOREIGN KEY REFERENCES Teachers(Id)
)

CREATE TABLE Subjects (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Name NVARCHAR(100) UNIQUE NOT NULL
)

CREATE TABLE Lectures (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    SubjectId INT NOT NULL FOREIGN KEY REFERENCES Subjects(Id),
    TeacherId INT NOT NULL FOREIGN KEY REFERENCES Teachers(Id)
)

CREATE TABLE GroupsLectures (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    GroupId INT NOT NULL FOREIGN KEY REFERENCES Groups(Id),
    LectureId INT NOT NULL FOREIGN KEY REFERENCES Lectures(Id)
)

CREATE TABLE LectureRooms (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Building INT CHECK (Building BETWEEN 1 AND 5) NOT NULL,
    Name NVARCHAR(10) UNIQUE NOT NULL
)

CREATE TABLE Schedules (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Class INT CHECK (Class BETWEEN 1 AND 8) NOT NULL,
    DayOfWeek INT CHECK (DayOfWeek BETWEEN 1 AND 7) NOT NULL,
    Week INT CHECK (Week BETWEEN 1 AND 52) NOT NULL,
    LectureId INT NOT NULL FOREIGN KEY REFERENCES Lectures(Id),
    LectureRoomId INT NOT NULL FOREIGN KEY REFERENCES LectureRooms(Id)
)
