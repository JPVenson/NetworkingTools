CREATE TABLE [dbo].[DestinationServerUsage]
(
	[DestinationServerUsage_Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Code] NVARCHAR(MAX) NOT NULL,
	[Name] NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
)
