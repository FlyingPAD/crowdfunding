CREATE PROCEDURE [dbo].[SP_Project_Get]
AS
BEGIN
	SELECT	[Id],
			[Created],
			[Modified],
			[Name],
			[Description],
			[URL_Video],
			[Money_Ceiling],
			[User_Id]			
	FROM [Project]
END
GO