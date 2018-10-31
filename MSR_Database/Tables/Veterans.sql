CREATE TABLE [dbo].[Veterans]
(
	[Id] int PRIMARY KEY,
	[FirstName] nvarchar(50),
	[MiddleName] nvarchar(50),	
	[Surname] nvarchar(50),
	[DOB] nvarchar(20),
	[BirthPlace] nvarchar(50),
	[Death] nvarchar(20),
	[MaritalStatus] nvarchar(20),
	[EnlistedDate] nvarchar(20),
	[EmbarkmentAge] nvarchar(20),
	[RegimentNumber] nvarchar(10),
	[Battalion] nvarchar(50),
	[Religion] nvarchar(50),
	[Address] nvarchar(150),
	[State] nvarchar(50),
	[Country] nvarchar(50),
	[PreWarOccupation] nvarchar(50),
	[NextOfKin] nvarchar(50),
	[ShortBio] nvarchar(1000),
	[Fate] nvarchar(50),
	[Status] int null,
	[ProfilePicture] varbinary(MAX),

	Fk_User_Id INT UNIQUE FOREIGN KEY REFERENCES Users(Id),
	Fk_Veteran_Queue_Id INT FOREIGN KEY REFERENCES VeteranQueues(Id) 
)
