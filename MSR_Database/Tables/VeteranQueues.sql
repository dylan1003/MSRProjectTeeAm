CREATE TABLE [dbo].[VeteranQueues]
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	Fk_Teacher_Id INT FOREIGN KEY REFERENCES Users(Id) NOT NULL 
)
