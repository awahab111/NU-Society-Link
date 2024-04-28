CREATE DATABASE SMS
use SMS
use master
--drop database SMS


CREATE TABLE Users (
    RollNumber VARCHAR(4) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    isAdmin BIT
);


INSERT INTO Users (RollNumber, Username, Password, isAdmin) VALUES
('1001', 'admin', 'admin', 1),
('1002', '1', '1', 0),
('1003', 'user3', 'passwordhash3' ,0),
('1004', 'user4', 'passwordhash4' ,0);


 
SELECT * FROM users WHERE username = '1' AND password = '1'
select * from users


CREATE TABLE Society (
    SocietyId INT IDENTITY(1,1) PRIMARY KEY,
	SocietyPresident VARCHAR(4),
    SocietyName VARCHAR(255),
    SocietyDescription TEXT,
    SocietyType VARCHAR(255),
    SocietySupervisor VARCHAR(255),
    SocietySupervisorContact VARCHAR(255),
    SocietySupervisorEmail VARCHAR(255),
    SocietySupervisorDesignation VARCHAR(255),
    SocietySupervisorDepartment VARCHAR(255),
    SocietyLogoBase64 TEXT,
	IsApproved BIT Default 0
	FOREIGN KEY (SocietyPresident) REFERENCES Users(RollNumber)
);

drop table Society

delete society

select * from Society where SocietyName= 'bhbhrb Society'

INSERT INTO Society (SocietyName, SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64, isApproved)
VALUES ('eee Society', 'This is a test society.', 'Type1', 'John Doe', '1234567890', 'john.doe@example.com', 'Supervisor', 'Department1','NONE', 0);


----------------------------------------------SocietyMembers
CREATE TABLE SocietyMembers (
    RollNum VARCHAR(4) PRIMARY KEY,
    SocietyId INT,
	MemberPosition VARCHAR(255),
    FOREIGN KEY (SocietyId) REFERENCES Society(SocietyId),
	FOREIGN KEY (RollNum) REFERENCES Users(RollNumber)
);

select * from SocietyMembers

INSERT INTO SocietyMembers (RollNum, SocietyId, MemberPosition)
VALUES ('1001', 1, 'President'),
       ('1002', 1, 'President');

select RollNum,SocietyId, Name, Email, contact, MemberPosition, batch from SocietyMembers 
Inner join Students 
on students.rollnumber = SocietyMembers.RollNum
where SocietyMembers.RollNum = 1001



drop table SocietyMembers

delete SocietyMembers
-------------------------------------------------




CREATE TABLE Notifications (
    NotificationId INT IDENTITY(1,1) PRIMARY KEY,
    UserId VARCHAR(4),
    Message VARCHAR(255),
    TimeStamp DATETIME DEFAULT GETDATE(),
    Seen BIT DEFAULT 0,
    FOREIGN KEY (UserId) REFERENCES Users(RollNumber)
);

INSERT INTO Notifications (UserId, Message, Seen)
VALUES ('1001', 'Your application has been approved.', 0),
       ('1002', 'Your application has been rejected.', 0),
       ('1002', 'Your application is under review.', 0),
       ('1002', 'Your application has been received.', 0);

select * from Notifications

UPDATE Notifications SET Seen = 0 WHERE UserId = 1002

CREATE TABLE Students (
    RollNumber VARCHAR(4) PRIMARY KEY,
    Name VARCHAR(100),
    Batch VARCHAR(4),
    Email VARCHAR(100),
    contact VARCHAR(100)
	FOREIGN KEY (RollNumber) REFERENCES Users(RollNumber)
);

INSERT INTO Students (RollNumber, Name, Batch, Email, contact) 
VALUES 
(1001, 'John Doe', '2022', 'johndoe@example.com', '1234567890'),
(1002, 'Jane Smith', '2023', 'janesmith@example.com', '0987654321'),
(1003, 'Bob Johnson', '2022', 'bobjohnson@example.com', '1122334455'),
(1004, 'Alice Williams', '2023', 'alicewilliams@example.com', '2233445566'),
(5, 'Charlie Brown', '2022', 'charliebrown@example.com', '3344556677');

drop table Students

select * from students where rollNumber = 3

 select  SocietyName,SocietyMembers.SocietyId, MemberPosition
 from SocietyMembers
 Inner join Society on Society.societyid = SocietyMembers.SocietyId
 where SocietyMembers.rollnum= 1001


 CREATE TABLE Tasks (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	EventId INT,
    assignedTo VARCHAR(4),
    Description TEXT,
    DueDate DATETIME,
    IsCompleted BIT,
	FOREIGN KEY (assignedTo) REFERENCES Users(RollNumber),
	FOREIGN KEY (EventId) REFERENCES Events(Event_id)

);

select * from Events

SELECT * FROM Events WHERE Society_id = 1 AND Start_time >= GETDATE()


ALTER TABLE Events
ADD HeadId VARCHAR(4),
FOREIGN KEY (HeadId) REFERENCES SocietyMembers(RollNum);


UPDATE Society 
    SET SocietyName = '454',
	SocietyDescription = 'fwfwefwe'

    WHERE SocietyId = 1


	select * from society