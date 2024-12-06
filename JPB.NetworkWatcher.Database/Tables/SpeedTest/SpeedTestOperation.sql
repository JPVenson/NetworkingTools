CREATE TABLE [dbo].[SpeedTestOperation]
(
	[SpeedTestOperation_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[OperationStart] DATETIME2 NOT NULL,
	[OperationEnd] DATETIME2 NULL,	
	[Id_DestinationServer] INT NOT NULL, 
    CONSTRAINT [FK_SpeedTestOperation_ToTable] 
		FOREIGN KEY ([Id_DestinationServer]) REFERENCES [DestinationServer]([DestinationServer_Id])

)
