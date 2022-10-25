CREATE PROCEDURE [dbo].[SP_User_Login]
	@email NVARCHAR(384),
	@password NVARCHAR(32)
AS
	SELECT	[Id],
			[Created],
			[Modified],
			[FirstName],
			[LastName],
			[Email],
			'********' AS [Password],
			[User_Category]
	FROM [User]
	WHERE [Email] LIKE @email
		AND [Password] = HASHBYTES('SHA2_512', dbo.SF_Salt() + @password)