CREATE PROCEDURE [dbo].[SP_Project_Get]
AS
BEGIN
	SELECT	[Id],
			[Created],
			[Modified],
			[Name],
			[Description],
			[URL_Video] AS UrlVideo,
			[URL_Picture] AS UrlPicture,
			[Money_Ceiling],
			[User_Id] AS UserId			
	FROM [Project]
END
GO