USE _1_MasterCampus;
GO

CREATE FUNCTION dbo.GetDepartmentName
(
    @name NVARCHAR(100)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM CollegeMaster
    WHERE name = @name
);
GO

SELECT *
FROM dbo.GetDepartmentName('Sandeep');


CREATE FUNCTION dbo.GetHighestM2 ()
RETURNS INT
AS
BEGIN
    DECLARE @HighestM2 INT;

    SELECT @HighestM2 = MAX(M2)
    FROM CollegeMaster;

    RETURN @HighestM2;
END;
GO
SELECT dbo.GetHighestM2();


-----------------------------------TEMPORARY TABLE----------------------------------
create table #StudentTemp(id int,name nvarchar(30));
insert into #StudentTemp values (1,'Sandeep'),(2,'Manish'),(3,'Happy'),(4,'Ramjee');


use _1_MasterCampus
go
create table #bonuscalculator (Name nvarchar(50),Total int,Bonus int);
insert into #bonuscalculator (Name,Total) select name,tot from CollegeMaster;
update #bonuscalculator set bonus=500 where Total > 200;
select * from #bonuscalculator;

select * from CollegeMaster;
update CollegeMaster set m1 = m1+5;
select * from CollegeMaster;


create table #m1_marks(id int,name varchar(50),m1 int)
insert into #m1_marks values(1,'Sandeep',81),(2,'Raman',80),(3,'Satyam',29);

select * from #m1_marks;
exec USP_PASSBYGRACE_1

