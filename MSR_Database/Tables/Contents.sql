CREATE TABLE [dbo].[Contents]
(
	[Id] int,
	[Title] nvarchar(50) NOT NULL,
	[Timestamp] datetime NULL,
	[MediaType] nvarchar(10) NULL,
	[Source] nvarchar(500),
	[DisplayPosition] int NULL,
	[Media] nvarchar(1000) NULL,
	[Section_Id] int NOT NULL,
	[Veteran_Id] int NOT NULL,
	CONSTRAINT PK_Content PRIMARY KEY (Id, Section_Id, Veteran_Id),
	CONSTRAINT FK_Section FOREIGN KEY (Section_Id, Veteran_Id) REFERENCES Sections(Id, Veteran_Id)
)
