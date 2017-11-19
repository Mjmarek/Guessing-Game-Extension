USE [aspnet-GuessingGame-20171118013053]
GO

BEGIN TRANSACTION

CREATE TABLE [GG_Person](
	[userId][nvarchar](128) NOT NULL,
	[firstName][nvarchar](256) NOT NULL,
	PRIMARY KEY (userId),
	FOREIGN KEY (userId) REFERENCES [dbo].[AspNetUsers] (Id)
)

CREATE TABLE [GG_Game](
	[gameId][UNIQUEIDENTIFIER] NOT NULL
		DEFAULT NEWID(),
	[userId][nvarchar](128) NOT NULL,
	[createdTime][TIMESTAMP] NOT NULL,
	PRIMARY KEY (gameId),
	FOREIGN KEY (userId) REFERENCES GG_Person (userId)
)

CREATE TABLE [GG_Guess](
	[guessId][UNIQUEIDENTIFIER] NOT NULL
		DEFAULT NEWID(),
	[gameId][UNIQUEIDENTIFIER] NOT NULL,
	[guessValue][INT] NOT NULL,
	PRIMARY KEY (guessId),
	FOREIGN KEY (gameId) REFERENCES GG_Game (gameId)
)

COMMIT