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

EXECUTE SP_User_Register
@FirstName = N'Tony',
@LastName = N'Van Langenhove',
@Email = N'tonyvan@live.fr',
@Password = N'Test1234='

EXECUTE SP_User_Register
@FirstName = N'Soën',
@LastName = N'Van Langenhove',
@Email = N'soenvan@outlook.com',
@Password = N'Test1234='

INSERT INTO [User_Category] ([Name]) VALUES (N'Registered')
INSERT INTO [User_Category] ([Name]) VALUES (N'Owner')
INSERT INTO [User_Category] ([Name]) VALUES (N'Administrator')

UPDATE [User]
SET [User_Category] = 3
WHERE [Id] = 1

INSERT INTO [Project] ([Created], [Modified], [Name], [Description], [URL_Video], [URL_Picture],Money_Ceiling, [User_Id]) 
VALUES (@now, @now, N'Flying PAD', N'Youtuber | Music', N'https://www.flyingpad.be', N'https://scontent.fbru1-1.fna.fbcdn.net/v/t39.30808-6/271186725_3093637974206325_902932029979181293_n.jpg?stp=dst-jpg_p180x540&_nc_cat=101&ccb=1-7&_nc_sid=e3f864&_nc_ohc=9NxhYin4GEQAX9C1XDz&_nc_ht=scontent.fbru1-1.fna&oh=00_AT873rr5P_Mfsi-mKajb4pZiOGAB-gGqFhLEF-qonrNpbw&oe=6324C544', 15000, 1);

INSERT INTO [Project] ([Created], [Modified], [Name], [Description], [URL_Video], [URL_Picture], Money_Ceiling, [User_Id]) 
VALUES (@now, @now, N'Best Of You', N'Photographer', N'https://www.bestofyou.com', N'https://cdn.wallpapersafari.com/62/80/IE4rFw.png', 25000, 1);

INSERT INTO [Project] ([Created], [Modified], [Name], [Description], [URL_Video], [URL_Picture], Money_Ceiling, [User_Id]) 
VALUES (@now, @now, N'Soen9048', N'Youtuber | Gaming', N'https://www.flyingpad.be', N'https://i.pinimg.com/originals/71/9e/80/719e80760999b4c355a723224120eb07.png', 10000, 1);