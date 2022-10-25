CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL IDENTITY, 
    [Created] DATETIME2(7) NOT NULL, 
    [Modified] DATETIME2(7) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [URL_Video] NVARCHAR(MAX) NOT NULL, 
    [URL_Picture] NVARCHAR(MAX) NOT NULL, 
    [Money_Ceiling] FLOAT NOT NULL, 
    [User_Id] INT NOT NULL
    CONSTRAINT [PK_Project] PRIMARY KEY ([Id])
    CONSTRAINT CK_Project_Money_Ceiling CHECK (Money_Ceiling > 0),
	CONSTRAINT FK_Project_User FOREIGN KEY ([User_Id]) REFERENCES [User]([Id])
)