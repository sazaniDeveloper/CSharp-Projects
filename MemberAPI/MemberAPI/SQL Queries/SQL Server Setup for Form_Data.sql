CREATE DATABASE form_data;
GO
USE form_data;
GO

CREATE TABLE USERS (
    ID int PRIMARY KEY IDENTITY(1,1),
    first_name varchar(100) NOT NULL,
    last_name varchar(100) NOT NULL,
    email_address varchar(254) NOT NULL UNIQUE
);

INSERT INTO USERS (first_name, last_name, email_address) 
VALUES ('Joel', 'Cesula', 'jcesula@gmail.com'),
       ('James', 'Smith', 'jsmith@gmail.com'),
       ('Regina', 'George', 'rgeorge@yahoo.com');