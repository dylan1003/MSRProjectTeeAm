CREATE TABLE [dbo].[Sections]
(
	[Id] int,
	[EventTitle] nvarchar(40) NOT NULL,
	[Approved] bit not null,
	[DisplayPosition] int NOT NULL,
	[CoordY] NVARCHAR(50),
	[CoordX] NVARCHAR(50),
	[Message] NVARCHAR(60),
	[CameraZoom] NVARCHAR(10),
	PRIMARY KEY (Id, Fk_Veterans_Id),
	Fk_Veterans_Id INT FOREIGN KEY REFERENCES Veterans(Id) NOT NULL
	
)
