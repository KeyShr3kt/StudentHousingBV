-- Insert 10 rows into the USER table
INSERT INTO [USER] (FirstName, LastName, EmailAddress, Password, PhoneNumber, PositiveVotes, NegativeVotes, IsAdmin, IBAN)
VALUES 
	('Ionut', 'Dragomir', 'i.dragomir@student.fontys.nl', 'ionutdragomir123', '123-456-7890', 10, 2, 1, 'NL75ABNA4887467303'),
	('John', 'Doe', 'john.doe@example.com', 'johndoe123', '123-456-7890', 10, 2, 0, 'NL03ABNA9510165298'),
	('Jane', 'Doe', 'jane.doe@example.com', 'janedoe456', '123-456-7891', 20, 3, 0, 'NL81ABNA3984212798'),
	('Bob', 'Smith', 'bob.smith@example.com', 'bobsmith789', '123-456-7892', 30, 4, 0, 'NL51ABNA9861487085'),
	('Sally', 'Smith', 'sally.smith@example.com', 'sallysmith101', '123-456-7893', 40, 5, 0, 'NL06ABNA6482008283'),
	('Tom', 'Johnson', 'tom.johnson@example.com', 'tomjohnson112', '123-456-7894', 50, 6, 0, 'NL32RABO1670475085'),
	('Alice', 'Johnson', 'alice.johnson@example.com', 'alicejohnson113', '123-456-7895', 60, 7, 0, 'NL73RABO6709624056'),
	('David', 'Brown', 'david.brown@example.com', 'davidbrown114', '123-456-7896', 70, 8, 0, 'NL28ABNA2504374283'),
	('Emily', 'Brown', 'emily.brown@example.com', 'emilybrown115', '123-456-7897', 80, 9, 0, 'NL32RABO4193835510'),
	('James', 'Miller', 'james.miller@example.com', 'jamesmiller116', '123-456-7898', 90, 10, 0, 'NL46RABO2045352188'),
	('Abby', 'Miller', 'abby.miller@example.com', 'abbymiller117', '123-456-7899', 100, 11, 0, 'NL48INGB4991062764');
SELECT * FROM [USER]

-- Insert 10 rows into the BUILDING table
INSERT INTO BUILDING (Address)
VALUES ('1234 Main St'), ('2345 Elm St'), ('3456 Oak St'), ('4567 Maple St'), ('5678 Cedar St'),
       ('6789 Pine St'), ('7890 Spruce St'), ('8901 Willow St'), ('9012 Birch St'), ('0123 Hickory St');
SELECT * FROM [BUILDING]

-- Insert 10 rows into the ROOM table
INSERT INTO ROOM (Type, UserID, Name, BuildingID)
VALUES ('Bedroom', 5, '104', 2), ('Bedroom', 6, '105', 2), ('Bedroom', 7, '106', 2),
       ('Bedroom', 8, '107', 3), ('Bedroom', 9, '109', 3), ('Bedroom', 10, '109', 3),
       ('Bedroom', 11, '110', 4);

INSERT INTO ROOM (Type, Name, BuildingID)
VALUES ('Office', '101', 1), ('Meeting', '102', 1), ('Storage','103', 1);
SELECT * FROM [ROOM]

-- Insert 10 rows into the EVENT table
INSERT INTO EVENT (Title, Description, CreatedAt, CreatorID, BuildingID) VALUES
('Event 1', 'Description of event 1', '2022-12-14 12:00:00', 2, 2),
('Event 2', 'Description of event 2', '2022-12-14 12:30:00', 3, 2),
('Event 3', 'Description of event 3', '2022-12-14 13:00:00', 4, 3),
('Event 4', 'Description of event 4', '2022-12-14 13:30:00', 5, 4),
('Event 5', 'Description of event 5', '2022-12-14 14:00:00', 6, 5),
('Event 6', 'Description of event 6', '2022-12-14 14:30:00', 7, 6),
('Event 7', 'Description of event 7', '2022-12-14 15:00:00', 8, 7),
('Event 8', 'Description of event 8', '2022-12-14 15:30:00', 9, 8),
('Event 9', 'Description of event 9', '2022-12-14 16:00:00', 10, 9),
('Event 10', 'Description of event 10', '2022-12-14 16:30:00', 11, 10);

INSERT INTO [RULE] (eventID, updatedAt) VALUES (1, CURRENT_TIMESTAMP);
INSERT INTO AGREEMENT (eventID, StartDateTime, EndDateTime, isAccepted) VALUES (2, CURRENT_TIMESTAMP, '2022/12/17 00:00:00', 0);
INSERT INTO TASK (eventID, AssignedToUserId, isShopping, isCompleted) VALUES (3, 2, 0, 0);

INSERT INTO [RULE] (eventID, updatedAt) VALUES (4, CURRENT_TIMESTAMP);
INSERT INTO AGREEMENT (eventID, StartDateTime, EndDateTime, isAccepted) VALUES (5, CURRENT_TIMESTAMP, '2022/12/17 00:00:00', 0);
INSERT INTO TASK (eventID, AssignedToUserId, isShopping, isCompleted) VALUES (6, 3,1, 0);

INSERT INTO [RULE] (eventID, updatedAt) VALUES (7, CURRENT_TIMESTAMP);
INSERT INTO AGREEMENT (eventID, StartDateTime, EndDateTime, isAccepted) VALUES (8, CURRENT_TIMESTAMP, '2022/12/17 00:00:00', 0);
INSERT INTO TASK (eventID, AssignedToUserId, isShopping, isCompleted) VALUES (9, 4, 1, 1);

INSERT INTO REPORT (Title, Description, CreatedAt, CreatorID, BuildingID, TargetedToEventID, IsReviewed) VALUES 
('Report 1', 'Description of report 1', CURRENT_TIMESTAMP, 5, 2, 5, 0);


Select *
From [event]
where id = 1;

SELECT * FROM [RULE]
SELECT * FROM [TASK]
SELECT * FROM [AGREEMENT]
SELECT * FROM [REPORT]

/*
DELETE FROM [USER]
DBCC CHECKIDENT ('[USER]', RESEED, 0)
DELETE FROM [BUILDING]
DBCC CHECKIDENT ('[BUILDING]', RESEED, 0)
DELETE FROM [ROOM]
DBCC CHECKIDENT ('[ROOM]', RESEED, 0)
DELETE FROM [EVENT]
DBCC CHECKIDENT ('[EVENT]', RESEED, 0)
DELETE FROM [TASK]
DELETE FROM [REPORT]
DELETE FROM [RULE]
DELETE FROM [AGREEMENT]
DELETE FROM [REACTION]
DBCC CHECKIDENT ('[REACTION]', RESEED, 0)
DROP TABLE [AGREEMENT]
DROP TABLE [BUILDING]
DROP TABLE [EVENT]
DROP TABLE [REACTION]
DROP TABLE [REPORT]
DROP TABLE [ROOM]
DROP TABLE [RULE]
DROP TABLE [TASK]
DROP TABLE [TASK_LOG]
DROP TABLE [USER]
*/

UPDATE [ROOM]
SET UserId = NULL
WHERE Id = 2;

SELECT [ROOM].*
FROM [ROOM] INNER JOIN [BUILDING] ON [ROOM].BuildingId = [BUILDING].Id
WHERE CONVERT(varchar, [ROOM].Type) = 'Bedroom' AND [ROOM].UserId IS NULL AND [BUILDING].Id = 2;

SELECT *
FROM [ROOM];