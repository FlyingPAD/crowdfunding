CREATE PROCEDURE [dbo].[SP_Project_Get_by_ID]

AS
BEGIN
	SELECT	[Id],
			[Name],
			[Created],
			[Modified]
		FROM [Project]
END
GO