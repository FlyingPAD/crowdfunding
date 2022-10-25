CREATE PROCEDURE [dbo].[SP_User_Register]
	@FirstName NVARCHAR(75),
	@LastName NVARCHAR(75),
	@Email NVARCHAR(384),
	@Password NVARCHAR(32)
AS BEGIN
DECLARE @now DATETIME2(7) = SYSDATETIME()

	INSERT INTO [User] ( Created, Modified, FirstName, LastName, Email, [Password], [User_Category] ) 
	OUTPUT	[Inserted].[Id], 
			[Inserted].[Created], 
			[Inserted].[Modified], 
			[inserted].[FirstName], 
			[Inserted].[LastName], 
			[Inserted].[Email], 
			[Inserted].[User_Category]
	VALUES (@now, @now, @FirstName, @LastName, @Email, HASHBYTES('SHA2_512', dbo.SF_Salt() + @Password), 1)
END
GO