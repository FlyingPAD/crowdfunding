CREATE TABLE [dbo].[Company]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] NCHAR(10) NOT NULL, 
    [TVA_Num] NCHAR(10) NOT NULL, 
    [User_Id] NCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Company] PRIMARY KEY ([Id])
)