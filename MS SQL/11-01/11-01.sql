--USE Univresity
--GO 

--CREATE FUNCTION GetFullname
--(
--	@FirstName NVARCHAR (50),
--	@LastName NVARCHAR (50)
--)
--RETURNS NVARCHAR (100)
--AS
--BEGIN
--	DECLARE @FullName NVARCHAR (100)

--	SET @FullName = @FirstName + ' ' + @LastName
	
--	RETURN @FullName

--END;

--USE Univresity
--SELECT dbo.GetFullname (FirstName, LastName)
--FROM Students


-------------------------------------------------------------------------

--USE SportShop
--GO

--SELECT ((SellPrice - NetPrice)/NetPrice *100)
--FROM Products

--ALTER FUNCTION MarginPercent
--(
--	@SellPrice DECIMAL (7,2),
--	@NetPrice DECIMAL (7,2),
--	@Perscent CHAR(1)
--)
--RETURNS DECIMAL (7,2)
--AS 
--BEGIN
--	DECLARE @MarginPercent DECIMAL (7,2)

--	SET @MarginPercent  = ((@SellPrice - @NetPrice)/@NetPrice *100) + @Perscent
	
--	RETURN @MarginPercent

--END;

--USE SportShop
--SELECT dbo.MarginPercent (SellPrice, NetPrice, '%')
--FROM Products


----------------------------------------------------------------------------------
--USE Univresity
--GO

--CREATE FUNCTION GetAge
--(
--	@BirthDate DATE	
--)
--RETURNS INT
--AS
--BEGIN
--	DECLARE @Age INT

--	SET @Age = DATEDIFF(YEAR, @BirthDate, GETDATE())
	
--	RETURN @Age

--END;

--SELECT dbo.GetFullname(FirstName, LastName) [FullName], dbo.GetAge(BirthDate) [Age], 'Student'
--FROM Students S
--UNION ALL
--SELECT dbo.GetFullname(FirstName, LastName), dbo.GetAge(BirthDate), 'Teacher'
--FROM Teachers
--ORDER BY Age


-----------------------------------------------------------------
USE Univresity
GO

--ALTER FUNCTION GetAllPersonnel()
--RETURNS TABLE
--AS
--RETURN 
--(
--	SELECT FirstName, LastName, BirthDate, 'Student' AS [Type]
--	FROM Students
--	UNION ALL
--	SELECT FirstName, LastName, BirthDate, 'Teacher' AS [Type]
--	FROM Teachers
--)

SELECT AVG(dbo.GetAge(BirthDate)) [avg Age]
FROM dbo.GetAllPersonnel()

SELECT *
FROM dbo.GetAllPersonnel()



---------------------------------------------------------------------
---------------------------------------------------------------------
---------------------------------------------------------------------
--DROP dbo.GetAge	- // delete function 
---------------------------------------------------------------------
---------------------------------------------------------------------
---------------------------------------------------------------------

