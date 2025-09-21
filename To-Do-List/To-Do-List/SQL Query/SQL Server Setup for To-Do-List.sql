CREATE DATABASE [to-do-list];
USE [to-do-list];
CREATE TABLE TASKS (ID int PRIMARY KEY IDENTITY(1,1),  task varchar(100), description_task varchar(250), date_task DATE, COMPLETED BIT);
INSERT INTO [TASKS] (task, description_task, date_task, COMPLETED) VALUES ('Grocery Shopping', 'Go the grocery to buy ingredients for pizza', '2025-09-10' , 0);
INSERT INTO [TASKS] (task, description_task, date_task, COMPLETED) VALUES ('Light Bulb', 'Buy a light bulb to replace the old one', '2025-09-26' , 0);
INSERT INTO [TASKS] (task, description_task, date_task, COMPLETED) VALUES ('Supplies', 'Get school supplies for my son', '2025-09-07' , 0);
INSERT INTO [TASKS] (task, description_task, date_task, COMPLETED) VALUES ('Picture Day', 'Take a picture at the photo store', '2025-09-22' , 0);
INSERT INTO [TASKS] (task, description_task, date_task, COMPLETED) VALUES ('Sodas', 'Go to the grocery store and get two sodas', '2025-09-24' , 0);
