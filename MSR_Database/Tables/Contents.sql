CREATE TABLE [dbo].[Contents]
(
	[Id] int ,
	[Title] nvarchar(50) NOT NULL,
	[Timestamp] datetime NOT NULL,
	[type] nvarchar(10) NOT NULL,
	[source] text,
	[DisplayPosition] int NOT NULL,
	[FK_Section_Id] int NOT NULL,
	[FK_Portfolio_Id] int NOT NULL,
	PRIMARY KEY (Id, Fk_Section_Id, Fk_Portfolio_Id),
	Foreign key (FK_Section_Id, FK_Portfolio_Id) references Sections,
	Fk_MultiMedia_Id INT FOREIGN KEY REFERENCES MultiMedias(Id) NOT NULL
)
