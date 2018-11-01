CREATE TABLE [dbo].[VeteranQueues]
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[Teacher_Id] int,
	CONSTRAINT FK_Teacher FOREIGN KEY (Teacher_Id) REFERENCES Users(Id) 
)
