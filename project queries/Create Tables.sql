CREATE TABLE Users (
	Id int identity(1,1) not null,
	PRIMARY KEY (Id),
	Email nvarchar(255) not null,
	Nickname nvarchar(255) not null,
	password nvarchar(255) not null,
	Birthday date not null,
	Role nvarchar(255) not null, 
	Levels nvarchar(255) not null,
	Type nvarchar(255) not null,
	Phone nvarchar(255) not null, 
	City nvarchar(255) not null, 
	JoinedAt date not null,
	FreeDaysLeft int not null,
	Photo varbinary(MAX) 
)
select * from Users

CREATE TABLE Events (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	EventName nvarchar(255) not null,
	Type nvarchar(255) not null CHECK (type IN ('Medical Leave', 'Time Off', 'Event')),
	Status nvarchar(255) not null CHECK (status IN ('Accepted', 'Declined', 'Pending')),
	FromDate date not null,
	ToDate date not null,
	Description nvarchar(500) not null,
)

select * from Events

CREATE TABLE UsersEvents (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	UserId int not null,
	FOREIGN KEY (UserId) REFERENCES Users(Id),
	EventId int not null,
	FOREIGN KEY (EventId) REFERENCES Events(Id),
)
SELECT * FROM UsersEvents


CREATE TABLE Project (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	ProjectName nvarchar(255) unique not null, 
	TeamManagerId INT not null,
	ProjectManagerId INT not null,
	FOREIGN KEY (TeamManagerId) REFERENCES Users(Id),
	FOREIGN KEY (ProjectManagerId) REFERENCES Users(Id),
	ProjectStatus varchar(255) not null CHECK (ProjectStatus IN ('In progress', 'Completed', 'On Hold')),
	StartDate date not null,
	EndDate date not null,
	Client nvarchar(255) not null,
	Description nvarchar(500) not null
)

CREATE TABLE ProjectMembers (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	UserId int not null,
	FOREIGN KEY (UserId) REFERENCES Users(Id),
	ProjectId int not null,
	FOREIGN KEY (ProjectId) REFERENCES Project(Id),
)



CREATE TABLE Review (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	UploadedById int not null,
	FOREIGN KEY (UploadedById) REFERENCES Users(Id),
	UploadedOnDate date not null,
	FileName nvarchar(255) not null,
	UserId int not null,
	FOREIGN KEY (UserId) REFERENCES Users(Id),

)


CREATE TABLE Document (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	Name nvarchar(255) not null,
	Purpose nvarchar(255) not null,
	Link nvarchar(255) not null,
	ProjectId int not null,
	FOREIGN KEY(ProjectId) REFERENCES Project(Id),
)
select * from Document



CREATE TABLE KeyMilestones (
	Id int identity(1,1) not null,
	PRIMARY KEY(Id),
	MilestoneName nvarchar(255) not null,
	Status nvarchar(255) not null CHECK (Status IN ('Completed', 'In Progress', 'To be Completed')),
	FromDate date not null,
	ToDate date not null,
	ProjectId int not null,
	FOREIGN KEY(ProjectId) REFERENCES Project(Id),
)

