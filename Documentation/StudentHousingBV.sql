CREATE TABLE [dbo].[AGREEMENT] (
   [eventID] [int] NOT NULL,
   [isAccepted] [smallint] NOT NULL

   ,CONSTRAINT [PK_AGREEMENT] PRIMARY KEY CLUSTERED ([eventID])
)

CREATE TABLE [dbo].[BUILDING] (
   [buildingID] [int] NOT NULL,
   [address] [text] NOT NULL

   ,CONSTRAINT [PK_BUILDING] PRIMARY KEY CLUSTERED ([buildingID])
)

CREATE TABLE [dbo].[EVENT] (
   [eventID] [int] NOT NULL,
   [title] [text] NOT NULL,
   [description] [text] NOT NULL,
   [createdAt] [datetime] NOT NULL,
   [creatorID] [int] NOT NULL,
   [buildingID] [int] NOT NULL

   ,CONSTRAINT [PK_EVENT] PRIMARY KEY CLUSTERED ([eventID])
)

CREATE TABLE [dbo].[REACTION] (
   [reactionID] [int] NOT NULL,
   [creatorID] [int] NOT NULL,
   [agreementID] [int] NOT NULL,
   [isPositive] [smallint] NOT NULL

   ,CONSTRAINT [PK_REACTION] PRIMARY KEY CLUSTERED ([reactionID])
)

CREATE TABLE [dbo].[REPORT] (
   [eventID] [int] NOT NULL,
   [targetedToEventID] [int] NOT NULL

   ,CONSTRAINT [PK_REPORT] PRIMARY KEY CLUSTERED ([eventID])
)

CREATE TABLE [dbo].[ROOM] (
   [roomID] [int] NOT NULL,
   [type] [text] NOT NULL,
   [userID] [int] NULL,
   [name] [text] NOT NULL,
   [buildingID] [int] NOT NULL

   ,CONSTRAINT [PK_ROOM] PRIMARY KEY CLUSTERED ([roomID])
)

CREATE TABLE [dbo].[RULE] (
   [eventID] [int] NOT NULL,
   [updatedAt] [datetime] NOT NULL

   ,CONSTRAINT [PK_RULE] PRIMARY KEY CLUSTERED ([eventID])
)

CREATE TABLE [dbo].[TASK] (
   [eventID] [int] NOT NULL,
   [isShopping] [smallint] NOT NULL,
   [isCompleted] [smallint] NOT NULL

   ,CONSTRAINT [PK_TASK] PRIMARY KEY CLUSTERED ([eventID])
)

CREATE TABLE [dbo].[USER] (
   [userID] [int] NOT NULL,
   [firstName] [text] NOT NULL,
   [lastName] [text] NOT NULL,
   [emailAddress] [text] NOT NULL,
   [password] [text] NOT NULL,
   [phoneNumber] [text] NOT NULL,
   [positiveVotes] [int] NOT NULL,
   [negativeVotes] [int] NOT NULL,
   [isAdmin] [smallint] NOT NULL,
   [lastSeenAt] [datetime] NULL

   ,CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED ([userID])
)

ALTER TABLE [dbo].[AGREEMENT] WITH CHECK ADD CONSTRAINT [FK_AGREEMENT_EVENT]
   FOREIGN KEY([eventID]) REFERENCES [dbo].[EVENT] ([eventID])
   
ALTER TABLE [dbo].[EVENT] WITH CHECK ADD CONSTRAINT [FK_EVENT_BUILDING]
   FOREIGN KEY([buildingID]) REFERENCES [dbo].[BUILDING] ([buildingID])

ALTER TABLE [dbo].[EVENT] WITH CHECK ADD CONSTRAINT [FK_EVENT_USER]
   FOREIGN KEY([creatorID]) REFERENCES [dbo].[USER] ([userID])
   
ALTER TABLE [dbo].[REACTION] WITH CHECK ADD CONSTRAINT [FK_REACTION_AGREEMENT]
   FOREIGN KEY([agreementID]) REFERENCES [dbo].[AGREEMENT] ([eventID])

ALTER TABLE [dbo].[REACTION] WITH CHECK ADD CONSTRAINT [FK_REACTION_USER]
   FOREIGN KEY([creatorID]) REFERENCES [dbo].[USER] ([userID])

ALTER TABLE [dbo].[REPORT] WITH CHECK ADD CONSTRAINT [FK_REPORT_EVENT1]
   FOREIGN KEY([eventID]) REFERENCES [dbo].[EVENT] ([eventID])

ALTER TABLE [dbo].[REPORT] WITH CHECK ADD CONSTRAINT [FK_REPORT_EVENT]
   FOREIGN KEY([targetedToEventID]) REFERENCES [dbo].[EVENT] ([eventID])
   
ALTER TABLE [dbo].[ROOM] WITH CHECK ADD CONSTRAINT [FK_ROOM_BUILDING]
   FOREIGN KEY([buildingID]) REFERENCES [dbo].[BUILDING] ([buildingID])

ALTER TABLE [dbo].[ROOM] WITH CHECK ADD CONSTRAINT [FK_ROOM_USER]
   FOREIGN KEY([userID]) REFERENCES [dbo].[USER] ([userID])
   
ALTER TABLE [dbo].[RULE] WITH CHECK ADD CONSTRAINT [FK_RULE_EVENT]
   FOREIGN KEY([eventID]) REFERENCES [dbo].[EVENT] ([eventID])
   
ALTER TABLE [dbo].[TASK] WITH CHECK ADD CONSTRAINT [FK_TASK_EVENT]
   FOREIGN KEY([eventID]) REFERENCES [dbo].[EVENT] ([eventID])
