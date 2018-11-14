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
	[Veteran_Id] int NOT NULL,
	CONSTRAINT PK_Section Primary Key (Id, Veteran_Id),
	CONSTRAINT FK_Veteran FOREIGN KEY (Veteran_Id) REFERENCES Veterans(Id)
)
