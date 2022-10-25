CREATE PROCEDURE [dbo].[SP_Project_Get_By_Id]
	@id INT
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
	WHERE [Id] = @id
END
GO