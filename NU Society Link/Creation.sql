+Drop Database if exists SMS
CREATE DATABASE SMS

use SMS

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


CREATE TABLE Events (
    Event_id INT IDENTITY(1,1) PRIMARY KEY,
	Society_id INT,
    Event_type VARCHAR(255),
    Event_title VARCHAR(255),
    Start_time DATETIME,
    End_time DATETIME,
    Expected_participants INT,
    Venue_name VARCHAR(255),
    Event_description VARCHAR(MAX),
    Event_requirements VARCHAR(MAX)
	FOREIGN KEY (Society_id) REFERENCES Society(SocietyId)

);



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


INSERT INTO Society (SocietyName, SocietyPresident , SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64, isApproved)
VALUES ('bhbhrb Society', '1001' ,'This is a test society.', 'Type1', 'John Doe', '1234567890', 'john.doe@example.com', 'Supervisor', 'Department1','NONE', 0);


CREATE TABLE SocietyMembers (
    RollNum VARCHAR(4) PRIMARY KEY,
    SocietyId INT,
	MemberPosition VARCHAR(255),
    FOREIGN KEY (SocietyId) REFERENCES Society(SocietyId),
	FOREIGN KEY (RollNum) REFERENCES Users(RollNumber)
);

INSERT INTO SocietyMembers (RollNum, SocietyId,MemberPosition)
VALUES ('1001', 1,'President'),
       ('1002', 1,'President');




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
(1004, 'Alice Williams', '2023', 'alicewilliams@example.com', '2233445566')

select * from Students
select * from Events