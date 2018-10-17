CREATE TABLE [dbo].[Sections]
(
	[Id] int,
	[Title] nvarchar(50) NOT NULL,
	[Approved] bit not null,
	[displayPosition] int NOT NULL,
	PRIMARY KEY (Id, Fk_Portfolio_Id),
	Fk_Portfolio_Id INT FOREIGN KEY REFERENCES Portfolios(Id) NOT NULL
	
)
