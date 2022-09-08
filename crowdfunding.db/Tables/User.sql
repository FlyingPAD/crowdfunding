CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY, 
    [Created] DATETIME2(7) NOT NULL, 
    [Modified] DATETIME2(7) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(384) NOT NULL, 
    [Password] BINARY(64) NOT NULL
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
)