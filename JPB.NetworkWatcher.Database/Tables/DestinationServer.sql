CREATE TABLE [dbo].[DestinationServer]
(
	[DestinationServer_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Name] NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[Address] NVARCHAR(350) NOT NULL,
	[Id_Usage] INT NOT NULL, 
	[Active] BIT NOT NULL DEFAULT(1),
	CONSTRAINT [FK_DestinationServer_DestinationServerUsage] 
		FOREIGN KEY ([Id_Usage]) REFERENCES [DestinationServerUsage]([DestinationServerUsage_Id])
)
