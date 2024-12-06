CREATE TABLE [dbo].[SpeedTestDataPoint]
(
	[SpeedTestDataPoint_Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[IsUpload] BIT NOT NULL DEFAULT(0),
	[Value] DECIMAL(18,7) NOT NULL,
	[OperationTime] DATETIME2 NOT NULL, 
	[Id_Operation] INT NOT NULL,
    CONSTRAINT [FK_SpeedTestDataPoint_SpeedTestOperation] 
		FOREIGN KEY ([Id_Operation]) REFERENCES [SpeedTestOperation]([SpeedTestOperation_Id])
)
