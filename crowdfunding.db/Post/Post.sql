/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DECLARE @now DATETIME2(7) = SYSDATETIME();

EXECUTE SP_User_Insert 
@Created = @now,
@Modified = @now,
@FirstName = N'Tony',
@LastName = N'Van Langenhove',
@Email = N'tonyvan@live.fr',
@Password = N'Test1234='

INSERT INTO [Project] ([Created], [Modified], [Name], [Description], [URL_Video], Money_Ceiling, [User_Id]) 
VALUES (@now, @now, 'Flying PAD', N'Youtuber | Music', N'https://www.youtube.com/', 15.000, 1);