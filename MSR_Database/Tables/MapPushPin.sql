CREATE TABLE [dbo].[MapPushPin]
(
	[Id] INT,
	[CoordX] FLOAT NOT NULL,
	[CoordY] FLOAT NOT NULL,
	[ZoomLevel] INT NOT NULL,
	[Message] VARCHAR(200),
	CONSTRAINT PK_MapPinId PRIMARY KEY ([Id]),
)
