CREATE TABLE [dbo].[Sections]
(
	[Id] INT,
	[EventTitle] NVARCHAR(40) NOT NULL,
	[Approved] BIT NOT NULL,
	[DisplayPosition] INT NOT NULL,
	[CoordY] NVARCHAR(50),
	[CoordX] NVARCHAR(50),
	[Message] NVARCHAR(60),
	[CameraZoom] NVARCHAR(2),
	PRIMARY KEY (Id, Fk_Veterans_Id),
	Fk_Veterans_Id INT FOREIGN KEY REFERENCES Veterans(Id) NOT NULL
	
)
