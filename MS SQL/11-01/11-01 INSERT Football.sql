USE Football

--BEGIN TRANSACTION;

--INSERT INTO Teams VALUES ('Manchester Unated');

--INSERT INTO Players VALUES ('Cristiano Ronaldo', 1);

--COMMIT TRANSACTION;

-----------------------------------------------------------------------

--BEGIN TRANSACTION

--INSERT INTO Players VALUES ('David Beckham', 1)

--SELECT * FROM Players
--ROLLBACK TRANSACTION
--SELECT * FROM Players

-------------------------------------------------------------------------

--BEGIN TRANSACTION
--INSERT INTO Teams VALUES ('Real Madrid');
--INSERT INTO Teams VALUES ('Barcelona');


--INSERT INTO Players VALUES ('Raul', 2);
--INSERT INTO Players VALUES ('Lionel Messi', 3);

--IF (@@ERROR > 0)
--	ROLLBACK TRANSACTION
--ELSE COMMIT TRANSACTION

----------------------------------------------------------------------

--BEGIN TRANSACTION 
--	BEGIN TRY
--		INSERT INTO Teams
--		VALUES ('Arsenal');
--		INSERT INTO Teams
--		VALUES ('AC Milan');

--		COMMIT TRANSACTION
--	END TRY
--	BEGIN CATCH 
--		ROLLBACK TRANSACTION
--	END CATCH

