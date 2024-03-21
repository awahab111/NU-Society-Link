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




select RollNumber from users