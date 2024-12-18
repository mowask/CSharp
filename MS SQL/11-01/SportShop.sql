USE [master]
GO
/****** Object:  Database [SportShop]    Script Date: 01.11.2024 18:30:52 ******/
CREATE DATABASE [SportShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SportShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SportShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SportShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SportShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SportShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SportShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SportShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SportShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SportShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SportShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SportShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SportShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SportShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SportShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SportShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SportShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SportShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SportShop] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SportShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SportShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SportShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SportShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SportShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SportShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SportShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SportShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SportShop] SET  MULTI_USER 
GO
ALTER DATABASE [SportShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SportShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SportShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SportShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SportShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SportShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SportShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [SportShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SportShop]
GO
/****** Object:  User [qwer]    Script Date: 01.11.2024 18:30:52 ******/
CREATE USER [qwer] FOR LOGIN [qwer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[MidleName] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Discount] [decimal](2, 2) NULL,
	[IsSubscribed] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[MidleName] [nvarchar](50) NULL,
	[PositionId] [int] NULL,
	[HireDate] [date] NULL,
	[Gender] [char](1) NULL,
	[Salary] [decimal](7, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Makers]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Makers](
	[MakerId] [int] IDENTITY(1,1) NOT NULL,
	[MakerName] [nvarchar](100) NULL,
	[MakerCountry] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MakerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionId] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NULL,
	[Quantity] [int] NULL,
	[NetPrice] [decimal](7, 2) NULL,
	[SellPrice] [decimal](7, 2) NULL,
	[MakerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NULL,
	[EmployeeId] [int] NULL,
	[SaleDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SelesProducts]    Script Date: 01.11.2024 18:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SelesProducts](
	[SaleId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[SaleQuantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Clothes')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Shoes')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Balls')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Bags')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Snowboarding')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (6, N'Accessories')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (1, N'Gerladina', N'Beminster', N'Claudell', N'399-510-2490', N'cbeminster0@nasa.gov', CAST(0.22 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (2, N'Winne', N'Croisdall', N'Fanny', N'134-686-7734', N'fcroisdall1@gravatar.com', CAST(0.17 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (3, N'Tiphani', N'Noir', N'Ingram', N'659-129-1997', N'inoir2@goo.ne.jp', CAST(0.02 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (4, N'Luce', N'Pates', N'Melisande', N'738-643-5083', N'mpates3@elpais.com', CAST(0.39 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (5, N'Irena', N'Merman', N'Neely', N'719-835-5284', N'nmerman4@technorati.com', CAST(0.33 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (6, N'Ephrem', N'McKerton', N'Bernadina', N'958-586-3433', N'bmckerton5@hud.gov', CAST(0.17 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (7, N'Prentiss', N'Giff', N'Haleigh', N'742-165-8080', N'hgiff6@ted.com', CAST(0.27 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (8, N'Ferrel', N'Hackett', N'Jo', N'143-472-5658', N'jhackett7@columbia.edu', CAST(0.63 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (10, N'Lynette', N'Temporal', N'Nat', N'352-397-5990', N'ntemporal9@salon.com', CAST(0.99 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (11, N'Sibby', N'Bortolomei', N'Emylee', N'519-220-0153', N'ebortolomeia@over-blog.com', CAST(0.59 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (12, N'Jedd', N'Christoffe', N'Essie', N'904-816-7382', N'echristoffeb@google.com.au', CAST(0.39 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (13, N'Naoma', N'Abrahamsohn', N'Juan', N'169-584-5114', N'jabrahamsohnc@bluehost.com', CAST(0.65 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (14, N'Priscilla', N'Stonham', N'Onida', N'462-534-5773', N'ostonhamd@sitemeter.com', CAST(0.17 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (15, N'Wilbert', N'Girodier', N'Dori', N'648-969-1616', N'dgirodiere@cbc.ca', CAST(0.48 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (16, N'Hadrian', N'Akid', N'Fifi', N'891-617-0912', N'fakidf@cnet.com', CAST(0.74 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (17, N'Tris', N'Lanfer', N'Windham', N'926-685-5323', N'wlanferg@booking.com', CAST(0.83 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (18, N'Bradford', N'Tilsley', N'Kirbie', N'492-816-9155', N'ktilsleyh@home.pl', CAST(0.44 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (19, N'Harlin', N'Reilinger', N'Clerkclaude', N'323-330-3337', N'creilingeri@barnesandnoble.com', CAST(0.28 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (20, N'Virgina', N'Harbar', N'Charlean', N'172-533-1580', N'charbarj@hubpages.com', CAST(0.96 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (21, N'Jody', N'Crickmer', N'Halley', N'509-501-3327', N'hcrickmerk@whitehouse.gov', CAST(0.57 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (22, N'Shepard', N'Arunowicz', N'Agnola', N'904-206-0242', N'aarunowiczl@imgur.com', CAST(0.58 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (23, N'Kendra', N'Pidcock', N'Lizbeth', N'846-780-3947', N'lpidcockm@dailymotion.com', CAST(0.59 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (24, N'Althea', N'Beange', N'Kayne', N'203-740-0837', N'kbeangen@nbcnews.com', CAST(0.45 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (25, N'Kristyn', N'Guidera', N'Martita', N'630-338-4411', N'mguiderao@vimeo.com', CAST(0.32 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (26, N'Susan', N'Gogay', N'Flory', N'651-175-8177', N'fgogayp@hatena.ne.jp', CAST(0.19 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (27, N'Melloney', N'Dugmore', N'Bil', N'290-412-5749', N'bdugmoreq@weather.com', CAST(0.91 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (28, N'Raychel', N'Luby', N'Corrinne', N'979-921-5469', N'clubyr@xinhuanet.com', CAST(0.17 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (29, N'Osbourne', N'Anwell', N'Daria', N'856-277-8154', N'danwells@utexas.edu', CAST(0.13 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (30, N'Timmi', N'Kildea', N'Berthe', N'516-223-0490', N'bkildeat@blogs.com', CAST(0.72 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (31, N'Haydon', N'Pettko', N'Thea', N'857-349-6170', N'tpettkou@addthis.com', CAST(0.10 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (32, N'Robyn', N'Gullan', N'Fredrika', N'303-203-7400', N'fgullanv@elegantthemes.com', CAST(0.59 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (33, N'Waylin', N'Pittam', N'Burch', N'862-250-7918', N'bpittamw@wufoo.com', CAST(0.81 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (34, N'Timoteo', N'Kacheller', N'Elsi', N'828-795-6015', N'ekachellerx@microsoft.com', CAST(0.04 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (35, N'Salome', N'Labat', N'Chantal', N'313-693-3505', N'clabaty@ebay.com', CAST(0.68 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (36, N'Sidney', N'Cains', N'Danya', N'218-343-9724', N'dcainsz@opera.com', CAST(0.37 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (37, N'Delmer', N'Armit', N'Jorge', N'494-938-7412', N'jarmit10@sfgate.com', CAST(0.64 AS Decimal(2, 2)), 0)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (38, N'Garvin', N'Spurling', N'Dorothea', N'164-725-0540', N'dspurling11@quantcast.com', CAST(0.64 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (39, N'Angele', N'Estable', N'Maxy', N'493-315-0181', N'mestable12@skype.com', CAST(0.22 AS Decimal(2, 2)), 1)
INSERT [dbo].[Clients] ([ClientId], [FirstName], [LastName], [MidleName], [Phone], [Email], [Discount], [IsSubscribed]) VALUES (40, N'Ana', N'Fehners', N'Kath', N'796-219-4143', N'kfehners13@cam.ac.uk', CAST(0.60 AS Decimal(2, 2)), 1)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (2, N'Pegeen', N'Dowman', N'Lynda', 1, CAST(N'2023-12-19' AS Date), NULL, CAST(51425.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (3, N'Christiano', N'Rogans', N'Ferrel', 2, CAST(N'2020-09-22' AS Date), N'M', CAST(35118.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (4, N'Raynell', N'Mulford', N'Joanie', 4, CAST(N'2024-07-03' AS Date), N'F', CAST(65928.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (5, N'Lilah', N'Duchart', N'Marys', 3, CAST(N'2021-02-18' AS Date), N'F', CAST(95840.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (6, N'Tony', N'de Guerre', N'Kally', 4, CAST(N'2024-02-22' AS Date), N'F', CAST(31844.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (7, N'Jenn', N'Ambrosi', N'Rivy', 2, CAST(N'2024-01-28' AS Date), N'F', CAST(55503.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (8, N'Broddy', N'Jaouen', N'Land', 1, CAST(N'2023-05-22' AS Date), NULL, CAST(20809.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (9, N'Winfield', N'Werlock', N'Beaufort', 2, CAST(N'2023-01-02' AS Date), N'M', CAST(58641.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (10, N'Harris', N'Denyakin', N'Cristian', 2, CAST(N'2021-09-05' AS Date), N'M', CAST(20184.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (11, N'Rorke', N'Lorant', N'Irvine', 2, CAST(N'2022-09-16' AS Date), N'M', CAST(59221.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (12, N'Wandie', N'Dumphrey', N'Robin', 1, CAST(N'2024-03-15' AS Date), N'F', CAST(57586.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (13, N'Cordelie', N'O'' Neligan', N'Susann', 1, CAST(N'2020-06-10' AS Date), N'F', CAST(90595.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (14, N'Edithe', N'Treske', N'Katina', 3, CAST(N'2022-05-22' AS Date), N'F', CAST(94199.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (15, N'Salomo', N'Antognelli', N'Kevon', 3, CAST(N'2022-06-05' AS Date), N'M', CAST(44076.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (16, N'Seamus', N'Bellenie', N'Kim', 3, CAST(N'2024-04-24' AS Date), N'M', CAST(52492.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (17, N'Adorne', N'Merkel', N'Christabella', 4, CAST(N'2023-03-21' AS Date), N'F', CAST(32818.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (18, N'Koralle', N'Bullin', N'Mavra', 2, CAST(N'2023-03-21' AS Date), N'F', CAST(42676.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (19, N'Melisandra', N'Connolly', N'Fan', 1, CAST(N'2024-09-02' AS Date), N'F', CAST(56260.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (20, N'Kale', N'Prestedge', N'Raff', 4, CAST(N'2023-10-23' AS Date), N'M', CAST(39872.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (21, N'Carmina', N'Russon', N'Naomi', 3, CAST(N'2024-10-24' AS Date), N'F', CAST(68515.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (22, N'Britt', N'Longdon', N'Clarey', 1, CAST(N'2023-02-01' AS Date), N'F', CAST(56651.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (23, N'Cacilia', N'Crutchley', N'Shel', 2, CAST(N'2020-07-09' AS Date), N'F', CAST(69859.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (24, N'Fanechka', N'Ianni', N'Allen', 1, CAST(N'2022-06-01' AS Date), NULL, CAST(48752.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (25, N'Sallyann', N'Treacy', N'Alaine', 3, CAST(N'2022-10-02' AS Date), N'F', CAST(73321.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (26, N'Giraldo', N'Keese', N'Morten', 2, CAST(N'2020-10-13' AS Date), N'M', CAST(51000.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (27, N'Florry', N'Shakelade', N'Clari', 3, CAST(N'2021-08-03' AS Date), N'F', CAST(44673.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (28, N'Dugald', N'Lassells', N'Bealle', 2, CAST(N'2021-03-23' AS Date), N'M', CAST(49662.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (29, N'Teddie', N'Girardini', N'Ranna', 3, CAST(N'2024-03-09' AS Date), N'F', CAST(79777.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (30, N'Fawne', N'Leathart', N'Idalina', 2, CAST(N'2023-03-12' AS Date), N'F', CAST(64978.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (31, N'Geoff', N'Lashbrook', N'Constancy', 2, CAST(N'2021-11-11' AS Date), NULL, CAST(97960.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (32, N'Rozele', N'Jerdein', N'Wynne', 2, CAST(N'2021-05-31' AS Date), N'F', CAST(82277.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (33, N'Arlan', N'Harding', N'Yank', 1, CAST(N'2021-08-26' AS Date), N'M', CAST(84606.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (34, N'Olga', N'Barff', N'Heddie', 2, CAST(N'2022-10-06' AS Date), N'F', CAST(58408.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (35, N'Carmon', N'Burgot', N'Quinn', 1, CAST(N'2023-04-23' AS Date), N'F', CAST(93991.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (36, N'Jorry', N'Breckin', N'Ardith', 4, CAST(N'2021-03-08' AS Date), N'F', CAST(49615.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (37, N'Arly', N'Lickess', N'Clem', 1, CAST(N'2022-03-01' AS Date), N'F', CAST(96414.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (38, N'Concordia', N'Cuming', N'Helenka', 4, CAST(N'2024-04-27' AS Date), N'F', CAST(86627.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (39, N'Alfred', N'Tonner', N'Carline', 4, CAST(N'2024-09-04' AS Date), NULL, CAST(81052.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (40, N'Dyanna', N'Ginnety', N'Louisette', 4, CAST(N'2022-05-30' AS Date), N'F', CAST(98211.00 AS Decimal(7, 2)))
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [MidleName], [PositionId], [HireDate], [Gender], [Salary]) VALUES (41, N'Alfy', N'Northley', N'Genny', 3, CAST(N'2024-09-04' AS Date), N'F', CAST(58591.00 AS Decimal(7, 2)))
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Makers] ON 

INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (1, N'Kuphal-Collier', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (2, N'Kutch-Monahan', N'Spain')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (3, N'Lang, Stracke and Hartmann', N'Russia')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (4, N'Beer, Effertz and Langosh', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (5, N'Sauer Inc', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (6, N'Howe Inc', N'Italy')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (7, N'Bauch, Hintz and Hagenes', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (8, N'Gusikowski, Mills and Botsford', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (9, N'Grimes-Johns', N'Russia')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (10, N'Kozey, Streich and O''Reilly', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (11, N'Streich-Wisoky', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (12, N'Monahan and Sons', N'Spain')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (13, N'Hauck Inc', N'Russia')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (14, N'Friesen-Fisher', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (15, N'Nitzsche Group', N'Germany')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (16, N'Kilback, O''Hara and Kilback', N'Spain')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (17, N'Bruen, Crooks and Collins', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (18, N'Hayes, Wisoky and Nader', N'Russia')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (19, N'Corwin, Kutch and Hoppe', N'Italy')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (20, N'Mayer, Quitzon and Cremin', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (21, N'Bruen, Crooks and Collins', N'China')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (22, N'Hayes, Wisoky and Nader', N'Russia')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (23, N'Corwin, Kutch and Hoppe', N'Italy')
INSERT [dbo].[Makers] ([MakerId], [MakerName], [MakerCountry]) VALUES (24, N'Mayer, Quitzon and Cremin', N'China')
SET IDENTITY_INSERT [dbo].[Makers] OFF
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (1, N'Manager')
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (2, N'Cashier')
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (3, N'Assistient')
INSERT [dbo].[Positions] ([PositionId], [PositionName]) VALUES (4, N'Warker')
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (101, N'Champlin, Beier and Quitzon', 1, 700, CAST(65077.00 AS Decimal(7, 2)), CAST(78794.00 AS Decimal(7, 2)), 16)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (102, N'DuBuque-Hackett', 3, 1900, CAST(769.00 AS Decimal(7, 2)), CAST(67877.00 AS Decimal(7, 2)), 20)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (103, N'Marvin-Stoltenberg', 4, 540, CAST(83378.00 AS Decimal(7, 2)), CAST(83379.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (104, N'Smitham-Ritchie', 2, 3505, CAST(61012.00 AS Decimal(7, 2)), CAST(91083.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (105, N'Schamberger Inc', 4, 514, CAST(65447.00 AS Decimal(7, 2)), CAST(65448.00 AS Decimal(7, 2)), 10)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (106, N'Skiles-Lockman', 6, 2707, CAST(38188.00 AS Decimal(7, 2)), CAST(38189.00 AS Decimal(7, 2)), 6)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (107, N'Mills, Kozey and Bartoletti', 5, 3847, CAST(69454.00 AS Decimal(7, 2)), CAST(74001.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (108, N'DuBuque and Sons', 3, 4381, CAST(15454.00 AS Decimal(7, 2)), CAST(52600.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (109, N'Ledner LLC', 1, 2064, CAST(14064.00 AS Decimal(7, 2)), CAST(14065.00 AS Decimal(7, 2)), 20)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (110, N'Hackett, Little and Harber', 2, 1137, CAST(76568.00 AS Decimal(7, 2)), CAST(76569.00 AS Decimal(7, 2)), 14)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (111, N'Price, Wilkinson and Huel', 3, 443, CAST(56912.00 AS Decimal(7, 2)), CAST(56913.00 AS Decimal(7, 2)), 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (112, N'Davis, Beatty and Douglas', 3, 3377, CAST(64290.00 AS Decimal(7, 2)), CAST(71834.00 AS Decimal(7, 2)), 16)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (113, N'Schultz Inc', 5, 3994, CAST(34456.00 AS Decimal(7, 2)), CAST(66955.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (114, N'McGlynn-Howell', 6, 333, CAST(23074.00 AS Decimal(7, 2)), CAST(33781.00 AS Decimal(7, 2)), 14)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (115, N'Haley, Baumbach and Mraz', 6, 915, CAST(19073.00 AS Decimal(7, 2)), CAST(92490.00 AS Decimal(7, 2)), 20)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (116, N'Mueller, Beer and Bailey', 5, 2908, CAST(37711.00 AS Decimal(7, 2)), CAST(98928.00 AS Decimal(7, 2)), 14)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (117, N'Weber-Pfeffer', 1, 2230, CAST(63591.00 AS Decimal(7, 2)), CAST(63592.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (118, N'Grimes, Lesch and Ritchie', 5, 344, CAST(45690.00 AS Decimal(7, 2)), CAST(55955.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (119, N'Schaden-Kuhlman', 3, 1377, CAST(72376.00 AS Decimal(7, 2)), CAST(72377.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (120, N'Turner Group', 1, 1945, CAST(34065.00 AS Decimal(7, 2)), CAST(80903.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (121, N'Crooks-Hermann', 3, 3129, CAST(78980.00 AS Decimal(7, 2)), CAST(78981.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (122, N'Monahan, Zboncak and Bode', 6, 644, CAST(9281.00 AS Decimal(7, 2)), CAST(62685.00 AS Decimal(7, 2)), 17)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (123, N'Farrell-Effertz', 5, 1069, CAST(30659.00 AS Decimal(7, 2)), CAST(30660.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (124, N'Maggio-Kuphal', 2, 1950, CAST(69847.00 AS Decimal(7, 2)), CAST(78384.00 AS Decimal(7, 2)), 6)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (125, N'Larkin and Sons', 2, 2046, CAST(80941.00 AS Decimal(7, 2)), CAST(80942.00 AS Decimal(7, 2)), 20)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (126, N'O''Keefe LLC', 6, 2400, CAST(12727.00 AS Decimal(7, 2)), CAST(63976.00 AS Decimal(7, 2)), 18)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (127, N'McLaughlin, Schiller and Lueilwitz', 2, 2147, CAST(20670.00 AS Decimal(7, 2)), CAST(97640.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (128, N'Stoltenberg, Rohan and Reilly', 6, 90, CAST(13806.00 AS Decimal(7, 2)), CAST(15741.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (129, N'Reichel, Jacobs and Ortiz', 2, 2887, CAST(17913.00 AS Decimal(7, 2)), CAST(17914.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (130, N'Collier, Toy and Hansen', 2, 4387, CAST(62619.00 AS Decimal(7, 2)), CAST(62620.00 AS Decimal(7, 2)), 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (131, N'Mitchell Inc', 1, 3303, CAST(44150.00 AS Decimal(7, 2)), CAST(44151.00 AS Decimal(7, 2)), 19)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (132, N'Christiansen, Harris and Parker', 3, 1967, CAST(30883.00 AS Decimal(7, 2)), CAST(32221.00 AS Decimal(7, 2)), 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (133, N'Murazik, Hirthe and Lakin', 6, 3995, CAST(88323.00 AS Decimal(7, 2)), CAST(88324.00 AS Decimal(7, 2)), 13)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (134, N'Stracke, Romaguera and Skiles', 6, 993, CAST(72919.00 AS Decimal(7, 2)), CAST(72920.00 AS Decimal(7, 2)), 10)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (135, N'Johns-Block', 1, 2114, CAST(89950.00 AS Decimal(7, 2)), CAST(89951.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (136, N'Macejkovic LLC', 1, 3467, CAST(21328.00 AS Decimal(7, 2)), CAST(24672.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (137, N'Bogan Inc', 4, 2795, CAST(30165.00 AS Decimal(7, 2)), CAST(30166.00 AS Decimal(7, 2)), 10)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (138, N'Medhurst-Boyer', 5, 4, CAST(45198.00 AS Decimal(7, 2)), CAST(50873.00 AS Decimal(7, 2)), 16)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (139, N'Schinner-Heidenreich', 2, 2140, CAST(5967.00 AS Decimal(7, 2)), CAST(67646.00 AS Decimal(7, 2)), 9)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (140, N'Zieme Inc', 2, 1989, CAST(74851.00 AS Decimal(7, 2)), CAST(80906.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (141, N'Stehr Inc', 6, 3405, CAST(52042.00 AS Decimal(7, 2)), CAST(52043.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (142, N'Johnson-Mayert', 3, 3705, CAST(87660.00 AS Decimal(7, 2)), CAST(87661.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (143, N'Frami, Schmeler and Glover', 4, 2386, CAST(47799.00 AS Decimal(7, 2)), CAST(84106.00 AS Decimal(7, 2)), 17)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (144, N'Borer-Parker', 5, 1920, CAST(6110.00 AS Decimal(7, 2)), CAST(91713.00 AS Decimal(7, 2)), 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (145, N'Huel Group', 1, 2097, CAST(20863.00 AS Decimal(7, 2)), CAST(67327.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (146, N'Thompson, Ledner and Ernser', 6, 4869, CAST(83470.00 AS Decimal(7, 2)), CAST(83471.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (147, N'Lehner Inc', 1, 3683, CAST(20156.00 AS Decimal(7, 2)), CAST(42300.00 AS Decimal(7, 2)), 19)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (148, N'Larkin Inc', 1, 3828, CAST(86303.00 AS Decimal(7, 2)), CAST(86304.00 AS Decimal(7, 2)), 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (149, N'Stracke-Paucek', 5, 1930, CAST(84922.00 AS Decimal(7, 2)), CAST(84923.00 AS Decimal(7, 2)), 6)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (150, N'Halvorson-Bogan', 3, 3872, CAST(28754.00 AS Decimal(7, 2)), CAST(89843.00 AS Decimal(7, 2)), 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (151, N'Kautzer Group', 2, 2655, CAST(66709.00 AS Decimal(7, 2)), CAST(66710.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (152, N'Beier, Prosacco and Sawayn', 6, 15, CAST(59969.00 AS Decimal(7, 2)), CAST(59970.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (153, N'Williamson and Sons', 1, 122, CAST(10055.00 AS Decimal(7, 2)), CAST(72477.00 AS Decimal(7, 2)), 13)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (154, N'Schimmel, Rempel and Wuckert', 3, 3109, CAST(43076.00 AS Decimal(7, 2)), CAST(54659.00 AS Decimal(7, 2)), 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (155, N'Weimann, Weissnat and Ledner', 1, 702, CAST(83318.00 AS Decimal(7, 2)), CAST(83319.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (156, N'Tromp-Johnston', 5, 7, CAST(24589.00 AS Decimal(7, 2)), CAST(24590.00 AS Decimal(7, 2)), 8)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (157, N'Monahan, Deckow and Lowe', 4, 3692, CAST(13811.00 AS Decimal(7, 2)), CAST(24504.00 AS Decimal(7, 2)), 8)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (158, N'Huel-Monahan', 3, 1094, CAST(39834.00 AS Decimal(7, 2)), CAST(93331.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (159, N'Goyette-Heller', 4, 5, CAST(32182.00 AS Decimal(7, 2)), CAST(32183.00 AS Decimal(7, 2)), 19)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (160, N'Morar and Sons', 3, 3592, CAST(4966.00 AS Decimal(7, 2)), CAST(82419.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (161, N'Wisoky, Powlowski and McDermott', 5, 2426, CAST(82331.00 AS Decimal(7, 2)), CAST(82332.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (162, N'Quigley and Sons', 2, 46, CAST(20522.00 AS Decimal(7, 2)), CAST(57407.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (163, N'Reichert Inc', 2, 4512, CAST(18062.00 AS Decimal(7, 2)), CAST(25069.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (164, N'Anderson-Veum', 4, 455, CAST(78297.00 AS Decimal(7, 2)), CAST(78298.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (165, N'Dibbert Inc', 6, 3079, CAST(52624.00 AS Decimal(7, 2)), CAST(77103.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (166, N'Schneider, Conn and King', 4, 157, CAST(77161.00 AS Decimal(7, 2)), CAST(77162.00 AS Decimal(7, 2)), 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (167, N'Sporer Group', 2, 3742, CAST(64903.00 AS Decimal(7, 2)), CAST(82954.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (168, N'Rogahn LLC', 4, 516, CAST(57077.00 AS Decimal(7, 2)), CAST(84305.00 AS Decimal(7, 2)), 4)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (169, N'Kemmer, Ruecker and Hoppe', 1, 1123, CAST(6878.00 AS Decimal(7, 2)), CAST(35444.00 AS Decimal(7, 2)), 17)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (170, N'Cormier, Tremblay and Dickinson', 4, 3018, CAST(5238.00 AS Decimal(7, 2)), CAST(67002.00 AS Decimal(7, 2)), 12)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (171, N'Hackett, Collins and Halvorson', 2, 1727, CAST(50043.00 AS Decimal(7, 2)), CAST(50044.00 AS Decimal(7, 2)), 2)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (172, N'Hilpert, Gutmann and Hilpert', 4, 716, CAST(52678.00 AS Decimal(7, 2)), CAST(56217.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (173, N'Kuhic Inc', 6, 4259, CAST(37304.00 AS Decimal(7, 2)), CAST(56021.00 AS Decimal(7, 2)), 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (174, N'Spinka-Von', 1, 1890, CAST(67315.00 AS Decimal(7, 2)), CAST(67316.00 AS Decimal(7, 2)), 17)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (175, N'Hermann-Yundt', 3, 240, CAST(56556.00 AS Decimal(7, 2)), CAST(77917.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (176, N'Bogan-Orn', 3, 2684, CAST(65160.00 AS Decimal(7, 2)), CAST(65161.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (177, N'Spinka Group', 6, 3630, CAST(32608.00 AS Decimal(7, 2)), CAST(62744.00 AS Decimal(7, 2)), 3)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (178, N'Torp-Morissette', 1, 1328, CAST(45835.00 AS Decimal(7, 2)), CAST(45836.00 AS Decimal(7, 2)), 13)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (179, N'Stehr-Hyatt', 3, 3272, CAST(5253.00 AS Decimal(7, 2)), CAST(57466.00 AS Decimal(7, 2)), 14)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (180, N'Homenick Inc', 4, 4349, CAST(53718.00 AS Decimal(7, 2)), CAST(53719.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (181, N'Kemmer-Stamm', 3, 2529, CAST(68611.00 AS Decimal(7, 2)), CAST(68612.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (182, N'King, Dibbert and Little', 2, 3186, CAST(43560.00 AS Decimal(7, 2)), CAST(43561.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (183, N'Kulas Inc', 1, 1539, CAST(51714.00 AS Decimal(7, 2)), CAST(51715.00 AS Decimal(7, 2)), 5)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (184, N'Fadel LLC', 5, 4474, CAST(64638.00 AS Decimal(7, 2)), CAST(66180.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (185, N'Altenwerth-Upton', 6, 2438, CAST(53410.00 AS Decimal(7, 2)), CAST(53411.00 AS Decimal(7, 2)), 13)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (186, N'Windler Group', 6, 90, CAST(1062.00 AS Decimal(7, 2)), CAST(43978.00 AS Decimal(7, 2)), 6)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (187, N'Howe-Mante', 1, 1383, CAST(30034.00 AS Decimal(7, 2)), CAST(74611.00 AS Decimal(7, 2)), 20)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (188, N'Pollich, Buckridge and Kling', 4, 2648, CAST(60756.00 AS Decimal(7, 2)), CAST(60757.00 AS Decimal(7, 2)), 15)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (189, N'D''Amore-Streich', 5, 4794, CAST(52115.00 AS Decimal(7, 2)), CAST(52116.00 AS Decimal(7, 2)), 8)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (190, N'Greenholt LLC', 5, 2241, CAST(14339.00 AS Decimal(7, 2)), CAST(17798.00 AS Decimal(7, 2)), 9)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (191, N'Toy, White and Grady', 2, 3632, CAST(44757.00 AS Decimal(7, 2)), CAST(69963.00 AS Decimal(7, 2)), 13)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (192, N'Adams Inc', 6, 4184, CAST(5054.00 AS Decimal(7, 2)), CAST(56377.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (193, N'D''Amore and Sons', 2, 1229, CAST(55596.00 AS Decimal(7, 2)), CAST(67663.00 AS Decimal(7, 2)), 7)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (194, N'Bahringer LLC', 2, 4805, CAST(83237.00 AS Decimal(7, 2)), CAST(89650.00 AS Decimal(7, 2)), 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (195, N'Morar-Homenick', 3, 3660, CAST(57153.00 AS Decimal(7, 2)), CAST(57154.00 AS Decimal(7, 2)), 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (196, N'Waelchi, White and Pfeffer', 5, 2649, CAST(14353.00 AS Decimal(7, 2)), CAST(14354.00 AS Decimal(7, 2)), 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (197, N'Leuschke, Weimann and O''Conner', 2, 2651, CAST(44695.00 AS Decimal(7, 2)), CAST(44696.00 AS Decimal(7, 2)), 8)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (198, N'Gerlach, Heidenreich and McKenzie', 4, 3128, CAST(24664.00 AS Decimal(7, 2)), CAST(24665.00 AS Decimal(7, 2)), 11)
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (199, N'Von, Ledner and Ortiz', 5, 1301, CAST(24060.00 AS Decimal(7, 2)), CAST(41724.00 AS Decimal(7, 2)), 8)
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [CategoryID], [Quantity], [NetPrice], [SellPrice], [MakerId]) VALUES (200, N'Orn LLC', 4, 940, CAST(70131.00 AS Decimal(7, 2)), CAST(70132.00 AS Decimal(7, 2)), 7)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (1, 22, 10, CAST(N'2023-03-01' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (2, 29, 13, CAST(N'2021-10-03' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (3, 39, 16, CAST(N'2023-07-09' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (4, 34, 5, CAST(N'2021-01-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (5, 29, 11, CAST(N'2021-04-13' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (6, 33, 14, CAST(N'2024-10-21' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (7, 24, 13, CAST(N'2021-06-12' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (8, 36, 4, CAST(N'2020-11-16' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (9, 35, 8, CAST(N'2021-07-14' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (10, 19, 7, CAST(N'2021-12-10' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (11, 10, 12, CAST(N'2020-11-16' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (12, 34, 3, CAST(N'2022-03-27' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (13, 29, 9, CAST(N'2021-02-28' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (14, 34, 2, CAST(N'2023-11-28' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (15, 16, 5, CAST(N'2023-04-14' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (16, 11, 15, CAST(N'2023-06-11' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (17, 10, 14, CAST(N'2023-12-03' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (18, 22, 5, CAST(N'2021-04-12' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (19, 36, 16, CAST(N'2024-04-29' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (20, 10, 13, CAST(N'2021-01-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (21, 22, 8, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (22, 28, 14, CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (23, 23, 11, CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (24, 25, 9, CAST(N'2023-07-02' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (25, 27, 15, CAST(N'2022-07-04' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (26, 28, 14, CAST(N'2023-06-07' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (27, 32, 9, CAST(N'2023-03-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (28, 21, 6, CAST(N'2023-05-04' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (29, 13, 15, CAST(N'2024-08-07' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (30, 22, 16, CAST(N'2021-04-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (31, 19, 14, CAST(N'2023-08-07' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (32, 16, 11, CAST(N'2022-03-27' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (33, 11, 12, CAST(N'2022-08-19' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (34, 37, 7, CAST(N'2021-11-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (35, 10, 5, CAST(N'2022-07-11' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (36, 19, 15, CAST(N'2023-11-19' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (37, 33, 11, CAST(N'2022-08-12' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (38, 32, 6, CAST(N'2021-04-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (39, 23, 12, CAST(N'2021-06-22' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (40, 31, 11, CAST(N'2022-08-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (41, 16, 4, CAST(N'2021-08-19' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (42, 30, 7, CAST(N'2021-01-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (43, 27, 16, CAST(N'2021-04-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (44, 29, 6, CAST(N'2022-10-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (45, 40, 2, CAST(N'2024-05-13' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (46, 27, 10, CAST(N'2023-08-28' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (47, 32, 2, CAST(N'2021-06-16' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (48, 27, 14, CAST(N'2020-12-27' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (49, 39, 2, CAST(N'2023-12-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (50, 35, 13, CAST(N'2024-02-22' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (51, 21, 5, CAST(N'2023-01-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (52, 17, 7, CAST(N'2024-02-09' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (53, 19, 8, CAST(N'2022-11-29' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (54, 26, 4, CAST(N'2022-03-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (55, 27, 9, CAST(N'2023-02-09' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (56, 25, 9, CAST(N'2023-04-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (57, 30, 2, CAST(N'2022-03-15' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (58, 26, 16, CAST(N'2023-09-18' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (59, 36, 10, CAST(N'2023-07-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (60, 34, 4, CAST(N'2022-08-12' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (61, 27, 4, CAST(N'2021-05-11' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (62, 19, 8, CAST(N'2023-06-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (63, 26, 13, CAST(N'2021-06-28' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (64, 16, 4, CAST(N'2022-10-06' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (65, 38, 12, CAST(N'2024-01-15' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (66, 31, 3, CAST(N'2022-08-16' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (67, 16, 8, CAST(N'2023-10-07' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (68, 27, 7, CAST(N'2021-01-15' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (69, 19, 10, CAST(N'2024-02-13' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (70, 13, 11, CAST(N'2024-06-02' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (71, 40, 14, CAST(N'2021-03-12' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (72, 32, 14, CAST(N'2023-10-26' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (73, 16, 15, CAST(N'2023-04-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (74, 35, 15, CAST(N'2024-08-31' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (75, 12, 5, CAST(N'2023-06-30' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (76, 13, 16, CAST(N'2024-08-29' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (77, 17, 9, CAST(N'2021-03-04' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (78, 25, 14, CAST(N'2020-12-04' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (79, 38, 3, CAST(N'2022-01-18' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (80, 39, 10, CAST(N'2021-12-16' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (81, 29, 8, CAST(N'2022-05-23' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (82, 38, 13, CAST(N'2023-06-26' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (83, 27, 10, CAST(N'2021-02-23' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (84, 25, 5, CAST(N'2023-06-21' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (85, 31, 2, CAST(N'2022-04-03' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (86, 34, 13, CAST(N'2023-01-24' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (87, 26, 15, CAST(N'2023-03-09' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (88, 37, 13, CAST(N'2022-06-06' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (89, 34, 14, CAST(N'2023-04-05' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (90, 12, 13, CAST(N'2020-12-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (91, 35, 11, CAST(N'2021-12-07' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (92, 21, 16, CAST(N'2023-09-18' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (93, 36, 12, CAST(N'2021-06-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (94, 31, 4, CAST(N'2021-02-06' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (95, 15, 11, CAST(N'2022-05-13' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (96, 37, 2, CAST(N'2022-01-22' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (97, 40, 15, CAST(N'2022-02-25' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (98, 32, 3, CAST(N'2022-01-20' AS Date))
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (99, 33, 3, CAST(N'2022-01-02' AS Date))
GO
INSERT [dbo].[Sales] ([SaleId], [ClientId], [EmployeeId], [SaleDate]) VALUES (100, 29, 4, CAST(N'2021-06-12' AS Date))
SET IDENTITY_INSERT [dbo].[Sales] OFF
GO
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (2, 157, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (2, 160, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (2, 168, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (2, 183, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (3, 126, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (4, 115, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (4, 188, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (5, 101, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (5, 105, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (5, 106, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (5, 124, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (5, 180, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (6, 151, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (6, 167, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (6, 174, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (6, 181, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (7, 145, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (7, 149, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (7, 158, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (7, 177, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (7, 183, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (7, 197, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (8, 123, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (8, 150, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (8, 160, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (8, 161, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (8, 193, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (9, 126, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (9, 151, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (10, 142, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (11, 115, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (11, 160, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (11, 165, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (12, 181, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (12, 185, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (12, 187, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (13, 112, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (13, 119, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (14, 101, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (14, 136, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (15, 118, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (15, 128, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 102, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 116, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 123, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 139, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 178, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 194, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (16, 195, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (17, 111, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (17, 135, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (17, 150, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (18, 101, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (18, 134, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (18, 135, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (18, 157, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (18, 176, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (18, 199, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (19, 122, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (19, 164, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (20, 176, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (20, 181, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (20, 200, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (21, 105, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (21, 116, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (21, 169, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (21, 188, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (22, 165, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (22, 169, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (22, 172, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (23, 119, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (23, 157, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (23, 164, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (23, 165, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (23, 192, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (24, 146, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (25, 116, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (25, 159, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (25, 173, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (25, 180, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (26, 137, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (26, 150, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (26, 166, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (26, 194, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (27, 102, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (27, 117, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (27, 141, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (28, 105, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (28, 113, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (28, 176, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (29, 133, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (29, 136, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (29, 165, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (29, 175, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (30, 104, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (30, 181, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (30, 196, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (31, 116, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (31, 119, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (31, 143, 20)
GO
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (31, 175, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (31, 182, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (31, 185, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (32, 133, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (33, 142, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (33, 173, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (33, 196, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (34, 120, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (34, 151, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (34, 165, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (35, 135, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (36, 130, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (36, 141, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (36, 180, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (37, 127, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (37, 155, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (38, 107, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (38, 171, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (39, 119, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (40, 139, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (40, 153, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (40, 171, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (40, 195, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (41, 123, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (41, 124, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (41, 135, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (41, 141, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (42, 124, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (42, 161, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (43, 105, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (43, 119, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (43, 185, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (44, 148, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (44, 154, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (46, 168, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (47, 104, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (47, 117, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (47, 159, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (47, 163, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (47, 182, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (48, 122, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (48, 125, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (48, 133, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (48, 136, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (48, 143, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (48, 159, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (49, 104, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (49, 129, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (49, 159, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (50, 101, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (50, 109, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (50, 126, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (50, 169, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (51, 120, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (51, 130, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (51, 143, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (51, 180, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (52, 126, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (52, 173, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (52, 176, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (53, 109, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (53, 128, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (53, 150, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (54, 136, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (54, 143, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (54, 170, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (55, 139, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (55, 184, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (56, 171, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (56, 173, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (56, 188, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (57, 106, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (57, 109, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (57, 123, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (57, 149, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (57, 175, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (57, 184, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (58, 126, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (58, 185, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (58, 187, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (59, 118, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (59, 171, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (59, 192, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (60, 131, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (60, 160, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (60, 198, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (61, 127, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (61, 145, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (61, 146, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (62, 133, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (62, 144, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (62, 157, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (63, 107, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (63, 111, 20)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (63, 130, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (64, 121, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (64, 135, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (65, 150, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (66, 102, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (66, 171, 13)
GO
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (66, 188, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (67, 109, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (68, 191, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (68, 200, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (69, 120, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (69, 123, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (70, 116, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (70, 137, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (70, 148, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (70, 168, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 112, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 123, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 128, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 129, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 159, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 182, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (71, 184, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (72, 133, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (72, 140, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (73, 131, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (73, 134, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (73, 151, 6)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (73, 191, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (74, 104, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (74, 130, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (75, 105, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (75, 113, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (75, 183, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (76, 106, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (76, 155, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (76, 165, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (76, 178, 2)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (77, 134, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (77, 189, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (78, 198, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (79, 125, 11)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (79, 174, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (79, 187, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (80, 137, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (80, 145, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (80, 186, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (81, 163, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (82, 102, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (82, 170, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (83, 174, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (83, 183, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (84, 115, 15)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (84, 125, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (84, 179, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (84, 181, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (84, 190, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (85, 108, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (85, 126, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (85, 127, 10)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (85, 146, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (85, 173, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (86, 108, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (86, 138, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (86, 185, 19)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (88, 107, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (89, 117, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (89, 178, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (89, 189, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (90, 111, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (90, 136, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (90, 152, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (91, 144, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (91, 148, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (91, 199, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (92, 138, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (92, 174, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (93, 120, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (93, 176, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (94, 102, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (94, 106, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (94, 107, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (95, 183, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (96, 114, 5)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (96, 134, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (96, 151, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (96, 163, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (96, 184, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (97, 121, 18)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (97, 141, 1)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (97, 199, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (98, 127, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (98, 135, 13)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (98, 160, 4)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (99, 132, 12)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (99, 134, 14)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (99, 166, 16)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (100, 106, 17)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (100, 117, 7)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (100, 162, 3)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (100, 175, 9)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (100, 190, 8)
INSERT [dbo].[SelesProducts] ([SaleId], [ProductId], [SaleQuantity]) VALUES (100, 191, 10)
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([PositionId])
REFERENCES [dbo].[Positions] ([PositionId])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([MakerId])
REFERENCES [dbo].[Makers] ([MakerId])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([ClientId])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[SelesProducts]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[SelesProducts]  WITH CHECK ADD FOREIGN KEY([SaleId])
REFERENCES [dbo].[Sales] ([SaleId])
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD CHECK  (([Discount]>=(0)))
GO
USE [master]
GO
ALTER DATABASE [SportShop] SET  READ_WRITE 
GO
