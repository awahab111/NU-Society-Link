CREATE DATABASE SMS
use SMS
use master
DROP DATABASE SMS


CREATE TABLE Users (
    RollNumber VARCHAR(4) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    isAdmin BIT
);

drop table Users

INSERT INTO Users (RollNumber, Username, Password, isAdmin) VALUES
('1001', 'admin', 'admin', 1),
('1002', '1', '1', 0),
('1003', 'user3', 'passwordhash3' ,0),
('1004', 'user4', 'passwordhash4' ,0);



SELECT * FROM users WHERE username = '1' AND password = '1'
select * from users


CREATE TABLE Society (
    SocietyId INT IDENTITY(1,1) PRIMARY KEY,
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
);

drop table Society

delete society

select * from Society where SocietyName= 'bhbhrb Society'

INSERT INTO Society (SocietyName, SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64, isApproved)
VALUES ('eee Society', 'This is a test society.', 'Type1', 'John Doe', '1234567890', 'john.doe@example.com', 'Supervisor', 'Department1','NONE', 0);

CREATE TABLE SocietyMembers (
    RollNum VARCHAR(4) PRIMARY KEY,
    SocietyId INT,
    MemberName VARCHAR(255),
    MemberEmail VARCHAR(255),
    MemberContact VARCHAR(255),
	MemberPosition VARCHAR(255),
	MemberBatch VARCHAR(4),
    FOREIGN KEY (SocietyId) REFERENCES Society(SocietyId),
	FOREIGN KEY (RollNum) REFERENCES Users(RollNumber)
);

select * from SocietyMembers

delete SocietyMembers

INSERT INTO SocietyMembers (RollNum, SocietyId, MemberName, MemberEmail, MemberContact, MemberPosition, MemberBatch)
VALUES ('1001', 1, 'John Doe', 'john.doe@example.com', '1234567890', 'President', '2022'),
       ('1002', 1, 'Jane Smith', 'jane.smith@example.com', '0987654321', 'President', '2022');


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