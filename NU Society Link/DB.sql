CREATE DATABASE SMS
use SMS

CREATE TABLE Users (
    RollNumber VARCHAR(4) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE
);


INSERT INTO Users (RollNumber, Username, Password, Email) VALUES
('1001', 'user1', 'passwordhash1', 'user1@example.com'),
('1002', 'user2', 'passwordhash2', 'user2@example.com'),
('1003', 'user3', 'passwordhash3', 'user3@example.com'),
('1004', 'user4', 'passwordhash4', 'user4@example.com');




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
    SocietyLogoBase64 TEXT
);

drop table Society

select * from Society

INSERT INTO Society (SocietyName, SocietyDescription, SocietyType, SocietySupervisor, SocietySupervisorContact, SocietySupervisorEmail, SocietySupervisorDesignation, SocietySupervisorDepartment, SocietyLogoBase64)
VALUES ('Test Society', 'This is a test society.', 'Type1', 'John Doe', '1234567890', 'john.doe@example.com', 'Supervisor', 'Department1','Base64 string of the image');