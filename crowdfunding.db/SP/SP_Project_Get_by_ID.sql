CREATE PROCEDURE [dbo].[SP_Project_Get]
AS
BEGIN
	SELECT	[Id],
			[Name],
			[Created],
			[Modified]
		FROM [Project]
END
GO