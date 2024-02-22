CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Login] VARCHAR(20) NOT NULL, 
    [Pass] VARCHAR(20) NOT NULL, 
    [Admin] CHAR NULL
)
