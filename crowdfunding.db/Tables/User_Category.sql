CREATE TABLE [dbo].[User_Category]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_User_Category] PRIMARY KEY ([Id])
)