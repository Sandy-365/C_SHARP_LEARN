create database TRIGGER_1;
use TRIGGER_1;


CREATE TABLE IPL_TEAM
(
    TeamID INT PRIMARY KEY,
    TeamName VARCHAR(50),
    Captain VARCHAR(50)
);


CREATE TABLE IPL_LOG_TEAM
(
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    TeamID INT,
    Act VARCHAR(50),
    ActDate DATE
);

CREATE TRIGGER trg_IPL_TEAM
ON IPL_TEAM
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO IPL_LOG_TEAM (TeamID, Act, ActDate)
    SELECT TeamID, 'INSERT/UPDATE', GETDATE()
    FROM inserted;

    INSERT INTO IPL_LOG_TEAM (TeamID, Act, ActDate)
    SELECT TeamID, 'DELETE', GETDATE()
    FROM deleted;
END;
GO

INSERT INTO IPL_TEAM VALUES (6, 'Delhi Capitals', 'Rishabh Pant');

UPDATE IPL_TEAM
SET Captain = 'MSD'
WHERE TeamID = 6;

DELETE FROM IPL_TEAM WHERE TeamID = 6;


use _2_TEST
CREATE PROCEDURE GetAverageSalary
AS
BEGIN
    SELECT 
        AVG(Salary) AS AverageSalary
    FROM [dbo].[EmployeeMaster];
END;


exec GetAverageSalary