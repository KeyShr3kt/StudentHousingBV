CREATE TABLE [dbo].[BUILDING](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [text] NOT NULL,
	PRIMARY KEY (Id)
)

CREATE TABLE [dbo].[USER](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [text] NOT NULL,
	[LastName] [text] NOT NULL,
	[EmailAddress] [text] NOT NULL,
	[Password] [text] NOT NULL,
	[PhoneNumber] [text] NOT NULL,
	[PositiveVotes] [int] NOT NULL,
	[NegativeVotes] [int] NOT NULL,
	[IsAdmin] [smallint] NOT NULL,
	[LastSeenAt] [datetime] NULL,
	[IBAN] [text] NOT NULL,
	PRIMARY KEY (Id)
)

CREATE TABLE [dbo].[ROOM](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [text] NOT NULL,
	[UserId] [int] NULL,
	[Name] [text] NOT NULL,
	[BuildingId] [int] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UserId) REFERENCES [User] (Id),
	FOREIGN KEY (BuildingId) REFERENCES [Building] (Id)
)

CREATE TABLE [dbo].[EVENT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [text] NOT NULL,
	[Description] [text] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[BuildingId] [int] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (CreatorId) REFERENCES [User] (Id),
	FOREIGN KEY (BuildingId) REFERENCES [Building] (Id)
)

CREATE TABLE [dbo].[REPORT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [text] NOT NULL,
	[Description] [text] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[BuildingId] [int] NOT NULL,
	[TargetedToEventId] [int] NOT NULL,
	[IsReviewed] [smallint] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (CreatorId) REFERENCES [User] (Id),
	FOREIGN KEY (BuildingId) REFERENCES [Building] (Id),
	FOREIGN KEY (TargetedToEventId) REFERENCES [Event] (Id)
)

CREATE TABLE [dbo].[RULE](
	[EventId] [int] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	PRIMARY KEY (EventId),
	FOREIGN KEY (EventId) REFERENCES [Event] (Id)
)

CREATE TABLE [dbo].[AGREEMENT](
	[EventId] [int] NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NOT NULL,
	[IsAccepted] [smallint] NOT NULL,
	PRIMARY KEY (EventId),
	FOREIGN KEY (EventId) REFERENCES [Event] (Id)
)

CREATE TABLE [dbo].[REACTION](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatorId] [int] NOT NULL,
	[AgreementId] [int] NOT NULL,
	[IsPositive] [smallint] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (CreatorId) REFERENCES [User] (Id),
	FOREIGN KEY (AgreementId) REFERENCES [AGREEMENT] (EventId)
	
)

CREATE TABLE [dbo].[TASK](
	[EventId] [int] NOT NULL,
	[AssignedToUserId] [int] NOT NULL,
	[IsShopping] [smallint] NOT NULL,
	[IsCompleted] [smallint] NOT NULL,
	[TotalPrice] [int] NULL,
	PRIMARY KEY (EventId),
	FOREIGN KEY (EventId) REFERENCES [Event] (Id),
	FOREIGN KEY (AssignedToUserId) REFERENCES [User] (Id)
)

CREATE TABLE [dbo].[TASK_LOG](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TaskId] [int] NOT NULL,
	[UserId] [int] NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (UserId) REFERENCES [User] (Id),
	FOREIGN KEY (TaskId) REFERENCES [Task] (EventId)
)