CREATE TABLE [dbo].[Contents]
(
	[Id] int ,
	[Title] nvarchar(50) NOT NULL,
	[Timestamp] datetime NOT NULL,
	[type] nvarchar(10) NOT NULL,
	[source] text,
	[DisplayPosition] int NOT NULL,
	[Media] varbinary(MAX) NOT NULL,
	[FK_Section_Id] int NOT NULL,
	[FK_Veterans_Id] int NOT NULL,
	PRIMARY KEY (Id, Fk_Section_Id, Fk_Veterans_Id),
	Foreign key (FK_Section_Id, FK_Veterans_Id) references Sections
)
