--CREATE DATABASE [Academy6]

USE Academy6

--CREATE TABLE Curators (
--	Id INT PRIMARY KEY IDENTITY(1,1), 
--	Name NVARCHAR(max),
--	Surname nvarchar(max)  )

--CREATE TABLE Faculties (
--	Id INT PRIMARY KEY IDENTITY(1,1), 
--	Name NVARCHAR(100) )

--CREATE TABLE Departments (
--	Id INT  PRIMARY KEY IDENTITY(1,1) , 
--	Building INT CHECK (Building BETWEEN 1 AND 5),
--	Financing MONEY NOT NULL,
--	Name NVARCHAR(100) NOT NULL,
--	FacultyId INT FOREIGN KEY REFERENCES Faculties(Id)  )
	
--CREATE TABLE Groups (
--	Id INT PRIMARY KEY IDENTITY(1,1), 
--	Name NVARCHAR(100), 
--	Year INT NOT NULL CHECK (Year BETWEEN 1 AND 5),
--	DepartmrntId INT FOREIGN KEY REFERENCES Departments(Id) )

--CREATE TABLE GroupsCurators (
--	Id INT PRIMARY KEY IDENTITY(1,1) , 
--	CuratorId INT FOREIGN KEY REFERENCES Curators(Id) ,
--	GroupId INT FOREIGN KEY REFERENCES Groups(Id)  )

--CREATE TABLE Students (
--	Id INT PRIMARY KEY IDENTITY(1,1) ,
--	Name NVARCHAR(max) ,
--	Surname nvarchar(max) ,
--	Rating INT CHECK (Rating BETWEEN 0 AND 5) )

--CREATE TABLE Subjects (
--	Id INT PRIMARY KEY IDENTITY(1,1) ,
--	Name NVARCHAR(100)  )

--CREATE TABLE Teachers (
--	Id INT PRIMARY KEY IDENTITY(1,1),	
--	Name NVARCHAR(max) ,
--	Surname nvarchar(max) ,
--	IsProfessor BIT DEFAULT '0',
--	Salary MONEY CHECK (Salary >0)   )

--CREATE TABLE GroupsStudents (
--	Id INT PRIMARY KEY IDENTITY(1,1), 
--	GroupId INT FOREIGN KEY REFERENCES Groups(Id),
--	StudentId INT FOREIGN KEY REFERENCES Students(Id) )

--CREATE TABLE Lectures (
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	Date DATE NOT NULL,
--	SubjectId INT FOREIGN KEY REFERENCES Subjects(Id) ,
--	TeacherId INT FOREIGN KEY REFERENCES Teachers(Id) )

--CREATE TABLE GroupsLectures (
--	Id INT PRIMARY KEY IDENTITY(1,1), 
--	GroupId INT FOREIGN KEY REFERENCES Groups(Id),
--	LectureId INT FOREIGN KEY REFERENCES Lectures(Id)  )
	

-------------------------------------------------------------------------------------------


