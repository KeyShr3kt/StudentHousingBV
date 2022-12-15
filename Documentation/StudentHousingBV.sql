/****** Object:  Table [dbo].[BUILDING] ******/

CREATE TABLE [dbo].[BUILDING](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [text] NOT NULL,
	PRIMARY KEY (Id)
)


/****** Object:  Table [dbo].[USER] ******/

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
	PRIMARY KEY (Id)
)


/****** Object:  Table [dbo].[ROOM] ******/

CREATE TABLE [dbo].[ROOM](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [text] NOT NULL,
	[UserId] [int] NULL,
	[Name] [text] NOT NULL,
	[BuildingId] [int] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (BuildingId) REFERENCES [BUILDING] (Id) ON DELETE CASCADE,
	FOREIGN KEY (UserId) REFERENCES [USER] (Id) ON DELETE SET NULL
)


/****** Object:  Table [dbo].[EVENT] ******/

CREATE TABLE [dbo].[EVENT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [text] NOT NULL,
	[Description] [text] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[BuildingId] [int] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (CreatorId) REFERENCES [USER] (Id) ON DELETE CASCADE,
	FOREIGN KEY (BuildingId) REFERENCES [BUILDING] (Id) ON DELETE CASCADE
)

/****** Object:  Table [dbo].[AGREEMENT] ******/

CREATE TABLE [dbo].[AGREEMENT](
	[EventId] [int] NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NOT NULL,
	[IsAccepted] [smallint] NOT NULL,
	PRIMARY KEY (EventId),
	FOREIGN KEY (EventId) REFERENCES [EVENT] (Id) ON DELETE CASCADE
)


/****** Object:  Table [dbo].[RULE] ******/

CREATE TABLE [dbo].[RULE](
	[EventId] [int] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	PRIMARY KEY (EventId),
	FOREIGN KEY (EventId) REFERENCES [EVENT] (Id) ON DELETE CASCADE
)


/****** Object:  Table [dbo].[TASK] ******/

CREATE TABLE [dbo].[TASK](
	[EventId] [int] NOT NULL,
	[IsShopping] [smallint] NOT NULL,
	[IsCompleted] [smallint] NOT NULL,
	PRIMARY KEY (EventId),
	FOREIGN KEY (EventId) REFERENCES [EVENT] (Id) ON DELETE CASCADE
)


/****** Object:  Table [dbo].[REPORT] ******/

CREATE TABLE [dbo].[REPORT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [text] NOT NULL,
	[Description] [text] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[BuildingID] [int] NOT NULL,
	[TargetedToEventId] [int] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (TargetedToEventID) REFERENCES [EVENT] (Id) ON DELETE CASCADE,
	FOREIGN KEY (CreatorId) REFERENCES [USER] (Id)
)


/****** Object:  Table [dbo].[REACTION] ******/

CREATE TABLE [dbo].[REACTION](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatorId] [int] NOT NULL,
	[AgreementId] [int] NOT NULL,
	[IsPositive] [smallint] NOT NULL,
	PRIMARY KEY (Id),
	FOREIGN KEY (CreatorId) REFERENCES [USER] (Id) ON DELETE CASCADE,
	FOREIGN KEY (AgreementId) REFERENCES [AGREEMENT] (EventId)
)


ALTER TABLE [dbo].[REPORT]
ADD FOREIGN KEY (CreatorId) REFERENCES [USER] (Id)