--//added new student//
--INSERT INTO Students(BirthDate, FirstName, LastName)
--VALUES ('1998-05-25', 'Bob', 'Kelso');

--//copy to new table//
--INSERT INTO Temp (LName, FName, BirthDate)
--SELECT LastName, FirstName, BirthDate
--FROM Students
--WHERE MONTH(BirthDate) > 6;

--//copy to new table//
--SELECT LastName, FirstName, BirthDate, Email
--INTO Temp1
--FROM Students
--WHERE Email IS NOT NULL



--UPDATE Students
--Set FirstName='John1', LastName = 'Doe1'
--Where LastName = 'Doe'

--UPDATE Students SET Grants += 500 WHERE Grants IS NOT NULL
--UPDATE Students SET Grants = 500 WHERE Grants IS  NULL

--DELETE FROM Students
--WHERE Grants < 1000

--////////////////////////////////////////////////////////////////