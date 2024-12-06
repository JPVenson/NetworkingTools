CREATE TABLE [dbo].[PingOperation]
(
	[PingOperation_Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[PingFailed] BIT NOT NULL,
	[Id_PingDestinationServer] INT NOT NULL, 
	CONSTRAINT [FK_PingOperation_DestinationServer] 
		FOREIGN KEY ([Id_PingDestinationServer]) REFERENCES [DestinationServer]([DestinationServer_Id]),
)
