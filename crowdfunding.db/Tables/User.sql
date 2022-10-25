CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY, 
    [Created] DATETIME2(7) NOT NULL, 
    [Modified] DATETIME2(7) NOT NULL, 
    [FirstName] NVARCHAR(75) NOT NULL, 
    [LastName] NVARCHAR(75) NOT NULL, 
    [Email] NVARCHAR(384) NOT NULL, 
    [Password] BINARY(64) NOT NULL,
    [User_Category] INT NOT NULL
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]),
)