use Test
go

alter table [dbo].[CollegeMaster] add Gender Nvarchar(10)

select * from [dbo].[CollegeMaster]

update [dbo].[CollegeMaster] set Gender = 'male' where id <5
update [dbo].[CollegeMaster] set Gender = 'female' where id = 5

alter table [dbo].[CollegeMaster] add m1 int
alter table [dbo].[CollegeMaster] add m2 int
alter table [dbo].[CollegeMaster] add m3 int
alter table [dbo].[CollegeMaster] add tot int

insert into dbo.CollegeMaster (Name, Department, Location, PhoneNo, Gender, m1, m2, m3, tot)
values
('Sandeep', 'Btech', 'Punjab', '9876543210', 'male', 100, 100, 100, 300),
('Rahul',   'Btech', 'Delhi',  '9876501234', 'male', 85,  90,  88,  263),
('Priya',   'Btech', 'Hyderabad', '9876512345', 'female', 95,  98,  99,  292),
('Anjali',  'Btech', 'Mumbai', '9876523456', 'female', 70,  80,  75,  225),
('Rohit',   'Btech', 'Bangalore', '9876520001', 'male', 100, 88, 100, 288),
('Neha',    'Btech', 'Chandigarh', '9876520002', 'female', 95, 100, 100, 290),
('Arjun',   'Btech', 'Pune', '9876520003', 'male', 100, 100, 100, 300);


sp_help 'dbo.CollegeMaster'


select count(*) from [dbo].[CollegeMaster] where m1 = 100 or m2 = 100 or m3 = 100

select Name from [dbo].[CollegeMaster] where (m1 = 100 or m2 = 100 or m3 = 100) and Gender = 'Male' and Department = 'CSE'

alter table [dbo].[CollegeMaster] add Grade nvarchar(2)

select sum(m1) from [dbo].[CollegeMaster]
select min(m1) from [dbo].[CollegeMaster]
select max(m1) from [dbo].[CollegeMaster]
select avg(m1) from [dbo].[CollegeMaster]

select * from CollegeMaster inner join Hostel on CollegeMaster.Id = Hostel.CollegeId

-- Find the room number of btech student

select * from CollegeMaster inner join Hostel on CollegeMaster.Id = Hostel.CollegeId where CollegeMaster.Department='CSE'



/*

			DATE - 24/Jan/2026

*/

select Name,RoomNo from CollegeMaster inner join Hostel on CollegeMaster.Id = Hostel.CollegeId where (m1 =100 or m2 =100 or m3 = 100)

-- 1. Print the phone number of the room number 1 student(More Students)
select Name,PhoneNo,RoomNo from CollegeMaster inner join Hostel
on CollegeMaster.Id = Hostel.CollegeId
where RoomNo = 617;

-- 2. List the room number of all female/male students
select Name,PhoneNo,RoomNo from CollegeMaster inner join Hostel
on CollegeMaster.Id = Hostel.CollegeId
where Gender = 'female';

-- 3. How many students scored 100 they are belongs to hostel student
select * from CollegeMaster inner join Hostel
on CollegeMaster.Id = Hostel.CollegeId
where (m1 = 100 or m2 = 100 or m3=100)

-- 4. how many students staying in the room no 2 and print their full information.
select * from CollegeMaster inner join Hostel
on CollegeMaster.Id = Hostel.CollegeId
where RoomNo = 617;

-- 5. what is the average M1 mark for the room no 2 students.
select AVG(m1) as 'Average Marks Of RoomNo 620' from CollegeMaster inner join Hostel
on CollegeMaster.Id = Hostel.CollegeId
where RoomNo = 620;



--Inserting data in BookMaster and LibraryMasterSELECT        
FROM            AadharMaster INNER JOIN
                         OrderMaster ON AadharMaster.AdharId = OrderMaster.AadharId CROSS JOIN
                         Hostel INNER JOIN
                         CollegeMaster ON Hostel.CollegeId = CollegeMaster.Id INNER JOIN
                         LIbraryMaster ON CollegeMaster.Id = LIbraryMaster.TakenBy_CID INNER JOIN
                         BookMaster ON LIbraryMaster.Book_ID = BookMaster.Book_ID
insert into BookMaster(Book_ID, Title, Author, Code) values
(101,'Java Complete Reference','Herbert Schildt',1001),
(102,'Let Us C','Yashwant Kanetkar',1002),
(103,'Python Crash Course','Eric Matthes',1003),
(104,'DBMS Concepts','Korth',1004),
(105,'Operating System Concepts','Galvin',1005),
(106,'Computer Networks','Tanenbaum',1006),
(107,'Data Structures Using C','Reema Thareja',1007),
(108,'Clean Code','Robert Martin',1008);

insert into LibraryMaster(Library_ID, Book_ID, TakenBy_CID, IssueDate) values
(1,101,1,'2026-01-10'),
(2,102,4,'2026-01-11'),
(3,103,5,'2026-01-12'),
(4,104,6,'2026-01-13'),
(5,105,7,'2026-01-14'),
(6,106,8,'2026-01-15'),
(7,107,9,'2026-01-16'),
(8,108,10,'2026-01-17'),
(9,101,11,'2026-01-18');


/*
1. Print the student name and room number who has taken the java book from the library?
2. How many books taken by the person who scored 100 in any one subject?
3. How many students in Room no 1 have taken the book fron library?
4. Which department students have taken python book?
5. Print the phone of the student who took the Java book?
*/

-- 1. Print the student name and room number who has taken the java book from the library?
select cm.Name,h.RoomNo
from CollegeMaster cm
inner join Hostel h
on cm.Id = h.CollegeId
inner join LIbraryMaster lm
on cm.Id = lm.TakenBy_CID
inner join BookMaster bm
on lm.Book_ID = bm.Book_ID
where bm.Title like '%JAVA%';

-- 2. How many books taken by the person who scored 100 in any one subject?


---------------------------------    27-01-2026  --------------------------------------
select * from CollegeMaster CM
left join Hostel H
on CM.Id=h.COllegeId;


/*
INSERT INTO dbo.CourseMaster (Id, CourseName) VALUES
(1, 'BTech Computer Science'),
(2, 'BTech Mechanical'),
(3, 'BTech Civil'),
(4, 'BCA'),
(5, 'MCA'),
(6, 'MBA'),
(7, 'BSc Physics'),
(8, 'BSc Chemistry'),
(9, 'BSc Mathematics'),
(10, 'BA English');
*/

/*
INSERT INTO CollegeMaster1 (id, name, CourseId) VALUES
(1, 'Shubhanshu', 4),
(2, 'Pavan', 2),
(3, 'Deepak', 1),
(4, 'Arjun', 4),
(5, 'Mahima', 4),
(6, 'Sanjana', 1),
(7, 'Tirtharaj', 2);
*/


SELECT *
FROM CollegeMaster1 c
RIGHT OUTER JOIN CourseMaster cr
ON c.CourseId = cr.id;
