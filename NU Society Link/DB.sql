CREATE DATABASE SMS
use SMS

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
	IsApproved BIT
);

drop table Society

select * from Society

INSERT INTO Society (SocietyName, SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64, isApproved)
VALUES ('bhbhrb Society', 'This is a test society.', 'Type1', 'John Doe', '1234567890', 'john.doe@example.com', 'Supervisor', 'Department1','NONE', 0);