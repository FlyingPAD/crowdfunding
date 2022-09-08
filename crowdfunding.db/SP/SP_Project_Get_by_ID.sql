CREATE PROCEDURE [dbo].[SP_Project_Get_By_Id]
	@id INT
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
	WHERE [Id] = @id
END
GO