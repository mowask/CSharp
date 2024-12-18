USE [master]
GO
/****** Object:  Database [Academy]    Script Date: 27.10.2024 23:18:11 ******/
CREATE DATABASE [Academy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Academy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Academy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Academy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Academy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Academy] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Academy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Academy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Academy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Academy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Academy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Academy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Academy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Academy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Academy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Academy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Academy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Academy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Academy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Academy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Academy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Academy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Academy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Academy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Academy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Academy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Academy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Academy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Academy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Academy] SET RECOVERY FULL 
GO
ALTER DATABASE [Academy] SET  MULTI_USER 
GO
ALTER DATABASE [Academy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Academy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Academy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Academy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Academy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Academy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Academy', N'ON'
GO
ALTER DATABASE [Academy] SET QUERY_STORE = ON
GO
ALTER DATABASE [Academy] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Academy]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Financing] [money] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[FacultyId] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Dean] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](10) NOT NULL,
	[Year] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupsLectures]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupsLectures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupId] [int] NOT NULL,
	[LectureId] [int] NOT NULL,
 CONSTRAINT [PK_GroupsLectures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lectures]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lectures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DayOfWeek] [int] NOT NULL,
	[LectureRoom] [nvarchar](max) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[TeacherId] [int] NOT NULL,
 CONSTRAINT [PK_Lectures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Grants] [money] NULL,
	[Email] [nvarchar](50) NULL,
	[GroupId] [int] NULL,
	[LectureId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 27.10.2024 23:18:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Salary] [money] NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[EmploymentDate] [date] NOT NULL,
	[IsAssistant] [bit] NOT NULL,
	[IsProfessor] [bit] NOT NULL,
	[Position] [nvarchar](max) NOT NULL,
	[Premium] [money] NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Financing], [Name], [FacultyId]) VALUES (2, 50000.0000, N'Math', 1)
INSERT [dbo].[Departments] ([Id], [Financing], [Name], [FacultyId]) VALUES (3, 10000.0000, N'Computer Science', 3)
INSERT [dbo].[Departments] ([Id], [Financing], [Name], [FacultyId]) VALUES (4, 30000.0000, N'Software Develolopment', 3)
INSERT [dbo].[Departments] ([Id], [Financing], [Name], [FacultyId]) VALUES (5, 40000.0000, N'Phisics', 2)
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Faculties] ON 

INSERT [dbo].[Faculties] ([Id], [Name], [Dean]) VALUES (1, N'Math', N'Wilson')
INSERT [dbo].[Faculties] ([Id], [Name], [Dean]) VALUES (2, N'Phisics', N'Jones')
INSERT [dbo].[Faculties] ([Id], [Name], [Dean]) VALUES (3, N'Computer Science', N'Johnson')
SET IDENTITY_INSERT [dbo].[Faculties] OFF
GO
SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([Id], [Name], [Year], [Rating], [DepartmentId]) VALUES (1, N'Group 1', 1, 5, NULL)
INSERT [dbo].[Groups] ([Id], [Name], [Year], [Rating], [DepartmentId]) VALUES (2, N'Group 2', 2, 4, NULL)
INSERT [dbo].[Groups] ([Id], [Name], [Year], [Rating], [DepartmentId]) VALUES (3, N'Group 3', 5, 3, NULL)
SET IDENTITY_INSERT [dbo].[Groups] OFF
GO
SET IDENTITY_INSERT [dbo].[Lectures] ON 

INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (1, 1, N'D201', 1, 5)
INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (2, 2, N'C303', 3, 12)
INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (3, 3, N'B208', 5, 4)
INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (4, 4, N'A113', 4, 8)
INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (5, 5, N'D202', 2, 11)
INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (6, 1, N'D202', 2, 11)
INSERT [dbo].[Lectures] ([Id], [DayOfWeek], [LectureRoom], [SubjectId], [TeacherId]) VALUES (7, 3, N'C303', 3, 12)
SET IDENTITY_INSERT [dbo].[Lectures] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (1, N'Smith', N'John', CAST(N'1998-01-01' AS Date), NULL, N'john.smith@example.com', 1, 1)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (2, N'Doe', N'Jane', CAST(N'2000-02-02' AS Date), 3500.0000, N'jane.doe@example.com', 2, 1)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (3, N'Johnson', N'John', CAST(N'1999-03-03' AS Date), NULL, N'michael.johnson@example.com', 2, 2)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (4, N'Williams', N'Emily', CAST(N'2001-04-04' AS Date), 2800.0000, N'emily.williams@example.com', 3, 3)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (5, N'Brown', N'David', CAST(N'1997-05-05' AS Date), 600.0000, N'david.brown@example.com', 3, 4)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (6, N'Jones', N'Olivia', CAST(N'2002-06-06' AS Date), 4500.0000, N'olivia.jones@example.com', 2, 5)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (7, N'Miller', N'James', CAST(N'1996-07-07' AS Date), 3000.0000, N'james.miller@example.com', 1, 5)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (8, N'Davis', N'Ava', CAST(N'2003-08-08' AS Date), NULL, N'ava.davis@example.com', 3, 6)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (9, N'Garcia', N'Ethan', CAST(N'1995-09-09' AS Date), 5500.0000, N'ethan.garcia@example.com', 1, 1)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (10, N'Rodriguez', N'Sophia', CAST(N'2004-10-10' AS Date), 850.0000, N'sophia.rodriguez@example.com', 2, 5)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (11, N'Wilson', N'Jacob', CAST(N'1994-11-11' AS Date), 3200.0000, N'jacob.wilson@example.com', 1, 2)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (12, N'Martinez', N'Emma', CAST(N'2005-12-12' AS Date), 2700.0000, N'emma.martinez@example.com', 2, 3)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (13, N'Anderson', N'Noah', CAST(N'1993-01-01' AS Date), 220.0000, N'noah.anderson@example.com', 1, 1)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (14, N'Taylor', N'Amelia', CAST(N'2006-02-02' AS Date), 4300.0000, N'amelia.taylor@example.com', 3, 4)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (15, N'Thomas', N'Oliver', CAST(N'1992-03-03' AS Date), 3400.0000, N'oliver.thomas@example.com', 2, 5)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (16, N'Moore', N'Evelyn', CAST(N'2007-04-04' AS Date), 999.0000, N'evelyn.moore@example.com', 3, 6)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (17, N'Jackson', N'Liam', CAST(N'1991-05-05' AS Date), 999.0000, N'liam.jackson@example.com', 1, 7)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (18, N'Martin', N'Harper', CAST(N'2008-06-06' AS Date), 4600.0000, N'harper.martin@example.com', 2, 2)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (19, N'Campbell', N'Benjamin', CAST(N'1990-07-07' AS Date), 3100.0000, N'benjamin.campbell@example.com', 3, 3)
INSERT [dbo].[Students] ([Id], [LastName], [FirstName], [BirthDate], [Grants], [Email], [GroupId], [LectureId]) VALUES (20, N'Mitchell', N'Emily', CAST(N'2009-08-08' AS Date), 2600.0000, N'charlotte.mitchell@example.com', 2, 5)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name], [DepartmentId]) VALUES (1, N'Math', 2)
INSERT [dbo].[Subjects] ([Id], [Name], [DepartmentId]) VALUES (2, N'Phisics', 5)
INSERT [dbo].[Subjects] ([Id], [Name], [DepartmentId]) VALUES (3, N'C++', 3)
INSERT [dbo].[Subjects] ([Id], [Name], [DepartmentId]) VALUES (4, N'Java', 4)
INSERT [dbo].[Subjects] ([Id], [Name], [DepartmentId]) VALUES (5, N'Basic', 3)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (4, N'John', 1000.0000, N'Smith', CAST(N'1990-01-01' AS Date), 1, 0, N'T', 150.0000, 3)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (5, N'Jane', 1000.0000, N'Dosen', CAST(N'2003-02-02' AS Date), 1, 0, N'T', NULL, 5)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (6, N'Mike', 2000.0000, N'Johnson', CAST(N'1995-03-03' AS Date), 0, 1, N'P', 300.0000, 3)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (8, N'Emily', 1100.0000, N'Williams', CAST(N'1995-04-04' AS Date), 1, 0, N'T', 200.0000, 4)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (9, N'Sarah', 2100.0000, N'Jones', CAST(N'1992-06-06' AS Date), 0, 1, N'P', 100.0000, 5)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (10, N'Michael', 2250.0000, N'Wilson', CAST(N'1993-09-09' AS Date), 0, 1, N'P', 250.0000, 2)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (11, N'Dave', 2000.0000, N'McQueen', CAST(N'1999-11-11' AS Date), 0, 1, N'P', NULL, 2)
INSERT [dbo].[Teachers] ([Id], [Name], [Salary], [Surname], [EmploymentDate], [IsAssistant], [IsProfessor], [Position], [Premium], [DepartmentId]) VALUES (12, N'Jack', 1500.0000, N'Underhill', CAST(N'2001-01-18' AS Date), 1, 0, N'T', NULL, 4)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Departments_Name]    Script Date: 27.10.2024 23:18:11 ******/
ALTER TABLE [dbo].[Departments] ADD  CONSTRAINT [UK_Departments_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Faculties_Name]    Script Date: 27.10.2024 23:18:11 ******/
ALTER TABLE [dbo].[Faculties] ADD  CONSTRAINT [UK_Faculties_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Groups_Name]    Script Date: 27.10.2024 23:18:11 ******/
ALTER TABLE [dbo].[Groups] ADD  CONSTRAINT [UK_Groups_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_Subjects_Name]    Script Date: 27.10.2024 23:18:11 ******/
ALTER TABLE [dbo].[Subjects] ADD  CONSTRAINT [UK_Subjects_Name] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Departments] ADD  CONSTRAINT [DF_Departments_Financing]  DEFAULT ((0)) FOR [Financing]
GO
ALTER TABLE [dbo].[Teachers] ADD  CONSTRAINT [DF_Teachers_IsAssistant]  DEFAULT ((0)) FOR [IsAssistant]
GO
ALTER TABLE [dbo].[Teachers] ADD  CONSTRAINT [DF_Teachers_IsProfessor]  DEFAULT ((0)) FOR [IsProfessor]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Faculties] FOREIGN KEY([FacultyId])
REFERENCES [dbo].[Faculties] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Faculties]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [FK_Groups_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [FK_Groups_Departments]
GO
ALTER TABLE [dbo].[GroupsLectures]  WITH CHECK ADD  CONSTRAINT [FK_GroupsLectures_Groups] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[GroupsLectures] CHECK CONSTRAINT [FK_GroupsLectures_Groups]
GO
ALTER TABLE [dbo].[GroupsLectures]  WITH CHECK ADD  CONSTRAINT [FK_GroupsLectures_Lectures] FOREIGN KEY([LectureId])
REFERENCES [dbo].[Lectures] ([Id])
GO
ALTER TABLE [dbo].[GroupsLectures] CHECK CONSTRAINT [FK_GroupsLectures_Lectures]
GO
ALTER TABLE [dbo].[Lectures]  WITH CHECK ADD  CONSTRAINT [FK_Lectures_Subjects] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
GO
ALTER TABLE [dbo].[Lectures] CHECK CONSTRAINT [FK_Lectures_Subjects]
GO
ALTER TABLE [dbo].[Lectures]  WITH CHECK ADD  CONSTRAINT [FK_Lectures_Teachers] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
GO
ALTER TABLE [dbo].[Lectures] CHECK CONSTRAINT [FK_Lectures_Teachers]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([GroupId])
REFERENCES [dbo].[Groups] ([Id])
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD FOREIGN KEY([LectureId])
REFERENCES [dbo].[Lectures] ([Id])
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [FK_Subjects_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [FK_Subjects_Departments]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Departments]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [CK_Departments_Name] CHECK  ((NOT [Name] like '[ ]'))
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [CK_Departments_Name]
GO
ALTER TABLE [dbo].[Faculties]  WITH CHECK ADD  CONSTRAINT [CK_Faculties_Dean] CHECK  ((NOT [Dean] like '[ ]'))
GO
ALTER TABLE [dbo].[Faculties] CHECK CONSTRAINT [CK_Faculties_Dean]
GO
ALTER TABLE [dbo].[Faculties]  WITH CHECK ADD  CONSTRAINT [CK_Faculties_Name] CHECK  ((NOT [Name] like '[ ]'))
GO
ALTER TABLE [dbo].[Faculties] CHECK CONSTRAINT [CK_Faculties_Name]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [CK_Groups_Name] CHECK  ((NOT [Name] like '[ ]'))
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [CK_Groups_Name]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [CK_Groups_Rating] CHECK  (([Rating] like '[0-5]'))
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [CK_Groups_Rating]
GO
ALTER TABLE [dbo].[Groups]  WITH CHECK ADD  CONSTRAINT [CK_Groups_Year] CHECK  (([Year] like '[1-5]'))
GO
ALTER TABLE [dbo].[Groups] CHECK CONSTRAINT [CK_Groups_Year]
GO
ALTER TABLE [dbo].[Lectures]  WITH CHECK ADD  CONSTRAINT [CK_Lectures_DayOfWeek] CHECK  (([DayOfWeek]>=(1) AND [DayOfWeek]<=(7)))
GO
ALTER TABLE [dbo].[Lectures] CHECK CONSTRAINT [CK_Lectures_DayOfWeek]
GO
ALTER TABLE [dbo].[Lectures]  WITH CHECK ADD  CONSTRAINT [CK_Lectures_LectureRoom] CHECK  ((NOT [LectureRoom] like '[ ]'))
GO
ALTER TABLE [dbo].[Lectures] CHECK CONSTRAINT [CK_Lectures_LectureRoom]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [CK_Subjects_Name] CHECK  ((NOT [Name] like '[ ]'))
GO
ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [CK_Subjects_Name]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [CK_Teachers_Name] CHECK  ((NOT [Name] like '[ ]'))
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [CK_Teachers_Name]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [CK_Teachers_Posistion] CHECK  ((NOT [Position] like '[ ]'))
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [CK_Teachers_Posistion]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [CK_Teachers_Premium] CHECK  (([Premium]>=(0)))
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [CK_Teachers_Premium]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [CK_Teachers_Salary] CHECK  (([Salary]>(0)))
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [CK_Teachers_Salary]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [CK_Teachers_Surname] CHECK  ((NOT [Surname] like '[ ]'))
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [CK_Teachers_Surname]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'от 1 до 5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Groups', @level2type=N'COLUMN',@level2name=N'Year'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'от 0 до 5' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Groups', @level2type=N'COLUMN',@level2name=N'Rating'
GO
USE [master]
GO
ALTER DATABASE [Academy] SET  READ_WRITE 
GO
