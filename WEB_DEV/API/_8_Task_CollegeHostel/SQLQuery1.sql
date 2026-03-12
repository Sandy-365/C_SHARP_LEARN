CREATE TABLE Student
(
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    StudentName VARCHAR(100),
    Department VARCHAR(50),
    Year INT
);


CREATE TABLE Hostel
(
    HostelID INT PRIMARY KEY IDENTITY(1,1),
    StudentID INT,
    HostelName VARCHAR(100),
    RoomNo INT,
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID)
);


INSERT INTO Student (StudentName, Department, Year) VALUES
('Sandeep Kumar','CSE',3),
('Rahul Sharma','ECE',2),
('Priya Singh','IT',4),
('Amit Verma','ME',1),
('Neha Gupta','CSE',2);



INSERT INTO Hostel (StudentID, HostelName, RoomNo) VALUES
(1,'Boys Hostel A',101),
(2,'Boys Hostel A',102),
(4,'Boys Hostel B',201);