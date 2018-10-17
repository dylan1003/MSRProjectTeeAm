CREATE TABLE [dbo].[Users]
(
	[Id] int IDENTITY(1,1) PRIMARY KEY,
	[UserName] nvarchar(50) NULL,
	[Password] nvarchar(100) NULL,
	[Permissions] nvarchar(1) NULL
)
