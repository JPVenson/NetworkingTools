CREATE TABLE [dbo].[PingDataPoint]
(
	[PingDataPoint_Id] BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[OperationTime] DATETIME2 NOT NULL,
	[Value] DECIMAL(18,2) NOT NULL,
	[Id_PingOperation] BIGINT NOT NULL, 
	[Id_AggreationState] INT NOT NULL,
	CONSTRAINT [FK_PingDataPoint_PingOperation] 
		FOREIGN KEY ([Id_PingOperation]) REFERENCES [PingOperation]([PingOperation_Id]),
	CONSTRAINT [FK_PingDataPoint_AggreationState] 
		FOREIGN KEY ([Id_AggreationState]) REFERENCES [PingAggregationState]([PingAggregationState_Id])
)
