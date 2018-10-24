CREATE TABLE [dbo].[Veterans]
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[FirstName] nvarchar(50),
	[MiddleName] nvarchar(50),	
	[Surname] nvarchar(50),
	[DOB] nvarchar(20),
	[Fate] nvarchar(50),
	[Death] nvarchar(20),
	[EnlistedDate] nvarchar(20),
	[ServiceNo] nvarchar(10),
	[Unit] nvarchar(50),
	[Parish] nvarchar(50),
	[Address] nvarchar(150),
	[Town] nvarchar(50),
	[Country] nvarchar(50),
	[ShortBio] nvarchar(1000),
	[Status] int null,
	Fk_User_Id INT UNIQUE FOREIGN KEY REFERENCES Users(Id),
	Fk_Profile_Picture_Id INT FOREIGN KEY REFERENCES ProfilePictures(Id) NULL,
	Fk_Portfolio_Id INT UNIQUE FOREIGN KEY REFERENCES Portfolios(Id) NULL,
	Fk_Veteran_Queue_Id INT FOREIGN KEY REFERENCES VeteranQueues(Id) 
)
