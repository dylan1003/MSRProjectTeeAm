CREATE TABLE [dbo].[Users]
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[UserName] nvarchar(50) NULL,
	[Password] nvarchar(100) NULL,
	[Permissions] nvarchar(1) NULL
)

CREATE TABLE [dbo].[VeteranQueues]
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	Fk_Teacher_Id INT UNIQUE FOREIGN KEY REFERENCES Users(Id) NOT NULL 
)

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
