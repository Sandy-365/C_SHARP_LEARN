CREATE PROC USP_CheckAndUpdate100Marks
AS
BEGIN
    DECLARE @count INT

    SELECT @count = COUNT(*)
    FROM [dbo].[CollegeMaster]
    WHERE m1 = 100 OR m2 = 100 OR m3 = 100

    IF (@count < 4)
    BEGIN
        UPDATE [dbo].[CollegeMaster]
        SET state = 'Punjab',
            m2 = 'UP'
    END
END



ALTER TABLE CollegeMaster WITH NOCHECK
ADD CONSTRAINT CK_Gender CHECK (Gender IN ('male', 'female'));

ALTER TABLE CollegeMaster WITH NOCHECk
ADD CONSTRAINT CK_Marks CHECK (m1 BETWEEN 0 AND 100 AND m2 BETWEEN 0 AND 100 AND m3 BETWEEN 0 AND 100);


--------------------------------------------------------------
USE _1_MasterCampus
GO
/****** Object:  StoredProcedure [dbo].[uspGetstudentCountByDept]    Script Date: 29-01-2026 09:42:11 ******/

ALTER PROCEDURE [dbo].[uspGetstudentCountByDept]
AS
BEGIN

BEGIN TRY

BEGIN TRANSACTION Trans_One

update collegemaster set department ='ME' where department ='MCA'
insert into Hostel (RoomNo,CollegeId) values (23,7)

if @@ROWCOUNT = 0
ROLLBACK TRANSACTION Trans_One

COMMIT TRANSACTION Trans_One

END TRY

BEGIN CATCH

ROLLBACK TRANSACTION Trans_One

END CATCH

END;
GO

--------------------------------------------------------------
--1. Insert into Collegemaster
--2. Select id from Collegemaster
--3. Insert into Hostel
USE _1_MasterCampus
GO

ALTER PROCEDURE [dbo].[uspGetstudentCountByDept]
AS
BEGIN
    DECLARE @id INT

    BEGIN TRY

        BEGIN TRANSACTION Trans_One

        INSERT INTO dbo.CollegeMaster
        VALUES('Satyam', 'CSE', 'UP', 5678902367, 'Male', 69, 90, 249, 90, 'B')

        SELECT @id = Id FROM CollegeMaster WHERE Name = 'Satyam'

        INSERT INTO Hostel
        VALUES (6789,701, @id)

        SELECT Id FROM CollegeMaster

        IF @@ROWCOUNT = 0
            ROLLBACK TRANSACTION Trans_One
        ELSE
            COMMIT TRANSACTION Trans_One

    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION Trans_One
    END CATCH
END;
GO

