CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Created] DATETIME2 NOT NULL, 
    [Modified] DATETIME2 NOT NULL, 
    CONSTRAINT [PK_Project] PRIMARY KEY ([Id])
)