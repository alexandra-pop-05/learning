--USERS TABLE 
INSERT INTO Users (Email, Nickname, Password, Birthday, Role, Levels, Type, Phone, City, JoinedAt, FreeDaysLeft) VALUES  ('alexandra08@yahoo.com', 'Alexandra Pop', '123456', '2001-08-05', 'frontend developer', 'junior','user', '002002020200', 'Cluj', '2023-06-06', 5 )
INSERT INTO Users (Email, Nickname, Password, Birthday, Role, Levels, Type, Phone, City, JoinedAt, FreeDaysLeft) VALUES  ('muresan@yahoo.com', 'Alexandru Muresan', '123456', '2000-07-15', 'frontend developer', 'junior','user', '072002020211', 'Bistrita', '2023-03-12', 10 )
INSERT INTO Users (Email, Nickname, Password, Birthday, Role, Levels, Type, Phone, City, JoinedAt, FreeDaysLeft) VALUES  ('popescu@yahoo.com', 'Ion Popescu', '123456', '1999-08-05', 'java developer', 'senior','admin', '052007720211', 'Chisinau', '2023-04-06', 2 )
INSERT INTO Users (Email, Nickname, Password, Birthday, Role, Levels, Type, Phone, City, JoinedAt, FreeDaysLeft) VALUES  ('andreea@yahoo.com', 'Andreea Raduch', '123456', '1997-12-10', 'UI/UX Designer', 'senior','user', '077002020200', 'Chisinau', '2022-10-11', 5 )
INSERT INTO Users (Email, Nickname, Password, Birthday, Role, Levels, Type, Phone, City, JoinedAt, FreeDaysLeft) VALUES  ('tudor@yahoo.com', 'Tudor Craciun', '123456', '2000-11-11', 'java developer', 'senior','admin', '074002020200', 'Cluj', '2023-06-06', 9 )
SELECT * FROM Users

--PROJECT TABLE
INSERT INTO Project (ProjectName, TeamManagerId, ProjectManagerId, ProjectStatus, StartDate, EndDate, Client, Description) VALUES  ('Goodleap',1 , 2, 'On hold', '2023-03-12', '2024-03-12', 'GoodLeap CA, Australia', 'ajhgfdsasdfghgfdsfghjgfdgh')
INSERT INTO Project (ProjectName, TeamManagerId, ProjectManagerId, ProjectStatus, StartDate, EndDate, Client, Description) VALUES  ('LittlePay',2 , 2, 'Completed', '2023-03-12', '2023-07-12', 'LittePay CA, Australia', 'ajhgfdsasdfgheeegfdsfgeeeeehjgfdgh')
INSERT INTO Project (ProjectName, TeamManagerId, ProjectManagerId, ProjectStatus, StartDate, EndDate, Client, Description) VALUES  ('Smartcare',3 , 5, 'In progress', '2023-03-12', '2023-03-12', 'Smartare CA, Australia', 'ajhgfdsasdfgeeeeehgfdsfghjgfdgh')
INSERT INTO Project (ProjectName, TeamManagerId, ProjectManagerId, ProjectStatus, StartDate, EndDate, Client, Description) VALUES  ('Solarizd',3 , 1, 'On hold', '2023-03-12', '2023-03-12', 'Solarizd CA, Australia', 'ajhgfdsasdfghgfdsfghjgfdgrrh')
SELECT * FROM Project

INSERT INTO ProjectMembers(UserId, ProjectId) VALUES  (1, 1)
INSERT INTO ProjectMembers(UserId, ProjectId) VALUES  (2, 1)
INSERT INTO ProjectMembers(UserId, ProjectId) VALUES  (3, 2)
INSERT INTO ProjectMembers(UserId, ProjectId) VALUES  (4, 3)
INSERT INTO ProjectMembers(UserId, ProjectId) VALUES  (5, 4)
SELECT * FROM ProjectMembers

INSERT INTO  Events (EventName, Type, Status, FromDate, ToDate, Description) VALUES ('Alex Out of office', 'Time Off', 'Accepted', '2023-07-17', '2023-07-18', 'sdfghjklkjhgfdssss')
INSERT INTO  Events (EventName, Type, Status, FromDate, ToDate, Description) VALUES ('Wine tasting', 'Event', 'Accepted', '2023-10-11', '2023-10-12', 'aaaaaasdfghjklkjhgfdssss')
INSERT INTO  Events (EventName, Type, Status, FromDate, ToDate, Description) VALUES ('Tudor out of office', 'Time Off', 'Pending', '2023-06-15', '2023-06-17', 'hhhhhhhsdfghjklkjhgfdssss')
INSERT INTO  Events (EventName, Type, Status, FromDate, ToDate, Description) VALUES ('Covid', 'Medical Leave', 'Accepted', '2023-07-03', '2023-08-01', 'edhhhhhhhsdfghjklkjhgfdssss')
SELECT * FROM Events

INSERT INTO UsersEvents (UserId, EventId) VALUES (2, 1)
INSERT INTO UsersEvents (UserId, EventId) VALUES (5, 3)
INSERT INTO UsersEvents (UserId, EventId) VALUES (3, 4)
SELECT * FROM UsersEvents
