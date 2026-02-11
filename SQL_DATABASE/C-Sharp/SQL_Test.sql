/*
A training institute stores student course and marks data. Initially, all data was stored in a single un-normalized table.

Un-normalized table: StudentCourseRaw
Columns:
StudentId
StudentName
CourseName
TrainerName
CourseFee
JoiningDate
ExamMonth
ExamYear
Marks

Question 1 – Normalization (Mandatory)

Identify the normalization issues present in the above table.

Normalize the design up to Third Normal Form (3NF).

Create the required tables with appropriate primary keys and foreign keys.

Expected tables:
Student
Course
Trainer
Exam / Marks

Question 2 – ALTER TABLE (Schema Change)
Institute requirement:
“We want to store student reward points.”

Tasks:

Use ALTER TABLE to add a RewardPoints column to the Student table.

Set the default value of RewardPoints as 0.

(This question depends on Question 1)



Question 3 – CHECK Constraint (Mandatory)
Business rule:
“RewardPoints value must be between 0 and 100.”

Tasks:

Add a CHECK constraint on RewardPoints.

Prevent invalid values from being inserted.



Question 4 – INNER JOIN (Mandatory)
Write an SQL query to display the following details:
Student Name
Course Name
Trainer Name
Exam Month and Exam Year
Marks

Conditions:
• Show only students who have appeared for exams
• Use INNER JOIN



Question 5 – Date Function (Mandatory)
Write an SQL query to calculate the total marks obtained by each student in the current year.

Rules:
• Use SQL Server date functions
• Do not hardcode the year

Question 6 – SUBSTRING and LEFT (Mandatory)
The institute wants to generate a Student Login ID.

Rule:
• First 3 letters of student name
• First 2 letters of course name
• Append student ID

Example:
Kumar + SQL + 105 → KumSQ105

Tasks:

Generate the login ID using SUBSTRING and LEFT functions.

Display Student Name and Login ID.

Question 7 – Subquery (Mandatory)
Write an SQL query to list students whose total marks are greater than the average marks of all students.

Rules:
• Use a subquery
• Do not calculate the average in the outer query

Question 8 – UNION (Mandatory)
The institute wants a combined list of:
• Students who scored above 80 marks
• Students who scored below 40 marks

Tasks:

Write two SELECT queries.

Combine them using UNION.

Display Student Name, Marks, and Category (HIGH or LOW).

Question 9 – Trigger (Mandatory)
Business rule:
“Whenever marks are inserted, update student RewardPoints.”

Rules:
• Marks ≥ 80 → add 10 points
• Marks ≥ 60 → add 5 points
• Else → add 2 points

Tasks:

Create an AFTER INSERT trigger on the Marks table.

Automatically update RewardPoints.

Question 10 – COALESCE and Date Calculation (Mandatory)
Institute loyalty rule:
“If a student completes 3 years from JoiningDate, give ₹10,000 scholarship.”

Conditions:
• Some students may not have exam records
• RewardPoints may be NULL

Tasks:
Calculate scholarship amount:
Eligible → 10000
Not eligible → 0


Use COALESCE to handle NULL values.
Display Student Name, Joining Date, Years of Study, and Scholarship Amount.
Rules:
• Use SQL Server date functions
• Do not hardcode dates
*/
CREATE DATABASE STU_EXAM;
USE STU_EXAM;


--Student Table
CREATE TABLE StudentMaster (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50),
    JoiningDate DATE
);

--Trainer Table
CREATE TABLE TrainerMaster (
    TrainerId INT PRIMARY KEY,
    TrainerName VARCHAR(50)
);

--Course Table
CREATE TABLE CourseMaster (
    CourseId INT PRIMARY KEY,
    CourseName VARCHAR(50),
    CourseFee INT,
    TrainerId INT,
    FOREIGN KEY (TrainerId) REFERENCES TrainerMaster(TrainerId)
);


--Exam Table
CREATE TABLE ExamDetails (
    ExamId INT PRIMARY KEY,
    CourseId INT,
    ExamMonth INT,
    ExamYear INT,
    FOREIGN KEY (CourseId) REFERENCES CourseMaster(CourseId)
);

--Marks Table
CREATE TABLE MarksDetails (
    MarksId INT PRIMARY KEY,
    StudentId INT,
    ExamId INT,
    Marks INT,
    FOREIGN KEY (StudentId) REFERENCES StudentMaster(StudentId),
    FOREIGN KEY (ExamId) REFERENCES ExamDetails(ExamId)
);


-- Q2: ALTER TABLE (Add RewardPoints)
ALTER TABLE StudentMaster
ADD RewardPoints INT DEFAULT 0;


-- Q3: CHECK Constraint
ALTER TABLE StudentMaster
ADD CONSTRAINT CK_RewardPoints
CHECK (RewardPoints BETWEEN 0 AND 100);


--Q4: Inner Join
SELECT StudentName,CourseName,TrainerName,ExamMonth,ExamYear,Marks      
FROM CourseMaster INNER JOIN ExamDetails ON CourseMaster.CourseId = ExamDetails.CourseId 
INNER JOIN MarksDetails ON ExamDetails.ExamId = MarksDetails.ExamId 
INNER JOIN StudentMaster ON MarksDetails.StudentId = StudentMaster.StudentId 
INNER JOIN TrainerMaster ON CourseMaster.TrainerId = TrainerMaster.TrainerId


-- Q5 Date Function
SELECT s.StudentName,SUM(m.Marks) AS TotalMarks
FROM MarksDetails m
INNER JOIN StudentMaster s ON m.StudentId = s.StudentId
INNER JOIN ExamDetails e ON m.ExamId = e.ExamId
WHERE e.ExamYear = YEAR(GETDATE())
GROUP BY s.StudentName;


-- Q6 Substring and Left
SELECT 
    s.StudentName,
    LEFT(s.StudentName, 3) +
    LEFT(c.CourseName, 2) +
    CAST(s.StudentId AS VARCHAR) AS LoginID
FROM StudentMaster s
INNER JOIN MarksDetails m ON s.StudentId = m.StudentId
INNER JOIN ExamDetails e ON m.ExamId = e.ExamId
INNER JOIN CourseMaster c ON e.CourseId = c.CourseId;


-- Q7 SubQuery
SELECT s.StudentName, SUM(m.Marks) AS TotalMarks
FROM StudentMaster s
INNER JOIN MarksDetails m ON s.StudentId = m.StudentId
GROUP BY s.StudentName
HAVING SUM(m.Marks) >
(
    SELECT AVG(Marks)
    FROM MarksDetails
);



-- Q8: Union
SELECT s.StudentName,m.Marks,'HIGH' AS Category
FROM StudentMaster s
INNER JOIN MarksDetails m ON s.StudentId = m.StudentId
WHERE m.Marks > 80
UNION
SELECT s.StudentName,m.Marks,'LOW' AS Category
FROM StudentMaster s
INNER JOIN MarksDetails m ON s.StudentId = m.StudentId
WHERE m.Marks < 40;



-- Q9 Triggers
CREATE TRIGGER trg_UpdateRewardPoints
ON MarksDetails
AFTER INSERT
AS
BEGIN
    UPDATE s
    SET RewardPoints = RewardPoints +
        CASE
            WHEN i.Marks >= 80 THEN 10
            WHEN i.Marks >= 60 THEN 5
            ELSE 2
        END
    FROM StudentMaster s
    INNER JOIN inserted i
    ON s.StudentId = i.StudentId;
END;



---Q10 Coalesce
SELECT 
    StudentName,
    JoiningDate,
    DATEDIFF(YEAR, JoiningDate, GETDATE()) AS YearsOfStudy,
    CASE
        WHEN DATEDIFF(YEAR, JoiningDate, GETDATE()) >= 3
        THEN 10000
        ELSE 0
    END AS ScholarshipAmount,
    COALESCE(RewardPoints, 0) AS RewardPoints
FROM StudentMaster;

