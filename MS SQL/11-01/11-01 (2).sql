--USE Univresity
--GO

--CREATE PROCEDURE StudentList AS
--BEGIN
--	SELECT Id, dbo.GetFullname(FirstName, LastName) AS FullName
--	FROM Students
--END;

--USE Univresity
--EXEC dbo.StudentList

--------------------------------------

--USE Univresity
--go
----CREATE PROCEDURE AddTwoNumbers
----	@a int,  -- ÏÅÐÂÛÉ ÏÀÐÀÌÅÒÐ: ÖÅËÎÅ ×ÈÑËÎ
----	@b int,  -- ÂÒÎÐÎÉ ÏÀÐÀÂÌÅÒÐ: ÖÅËÎÅ ×ÈÑËÎ
----	@res int OUTPUT -- ÂÛÕÎÄÍÎÉ ÏÀÐÀÌÅÒÐ: ÐÅÇÓËÜÒÀÒ ñëîæåíèÿ à è â
----AS
----BEGIN
----	SET @res= @a + @b  -- ÂÛÏÎËÍßÅÌ ÑËÎÆÅÍÈÅ è ïðèñâàèâàåì ðåçóëüòàò âûõîäíîìó ïàðàìåòðó
----END;

--	DECLARE @sum INT;
--	EXEC dbo.AddTwoNumbers 5, 10, @sum output;
--	SELECT @sum;

-------------------------------

--USE Univresity
--go
--CREATE PROCEDURE AddTwoNumbersReturn
--	@a int, 
--	@b int
--AS
--BEGIN
--	DECLARE @res INT;
--	SET @res =@a + @b;
--	RETURN @res;
--END;

--USE Univresity
--DECLARE @sum INT 
--EXEC @sum = AddTwoNumbersReturn 5, 10
--SELECT @sum

-------------------------------

--USE Univresity
--go
--CREATE PROCEDURE DeleteStudentByDate
--	@date DATE
--AS
--BEGIN
--	DECLARE @count INT
--	SELECT @count = COUNT(*)
--	FROM Students
--	WHERE BirthDate > @date

--	DELETE 
--	FROM Students
--	WHERE BirthDate > @date
--	RETURN @count
--END


--DECLARE @count INT 
--EXEC @count = DeleteStudentByDate '2005-01-01'
--SELECT @count


--USE Univresity
--go
--CREATE PROCEDURE DeleteStudentByDateWithAchievments
--	@date DATE
--AS
--BEGIN
--	DECLARE @count INT
--	SELECT @count = COUNT(*)
--	FROM Students
--	WHERE BirthDate > @date

--	DELETE 
--	FROM Achievements
--	WHERE StudentId IN (
--			SELECT Id
--			FROM Students
--			WHERE BirthDate > @date
--			)

--	DELETE 
--	FROM Students
--	WHERE BirthDate > @date
	
--	RETURN @count
--END

------------------------------------------------

--USE Univresity
--go
--Alter PROCEDURE DeleteTeacherByAge
--	@Age int
--AS
--BEGIN
--	DECLARE @count INT
--	SELECT @count = COUNT(*)
--	FROM Students
--	WHERE dbo.GetAge(BirthDate) < @Age

--	DELETE 
--	FROM Teachers
--	WHERE dbo.GetAge(BirthDate) < @Age
--	RETURN @count
--END

--DECLARE @count INT 
--EXEC @count = DeleteTeacherByAge 25
--SELECT @count

