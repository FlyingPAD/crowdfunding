CREATE PROCEDURE [dbo].[SP_User_Insert]
	@Created DATETIME2,
	@Modified DATETIME2,
	@FirstName NVARCHAR(75),
	@LastName NVARCHAR(75),
	@Email NVARCHAR(384),
	@Password NVARCHAR(20)
AS
BEGIN
	INSERT INTO [User] (Created, Modified, FirstName, LastName, Email, [Password]) 
	VALUES (@Created, @Modified, @FirstName, @LastName, @Email, HASHBYTES('SHA2_512', dbo.SF_Salt() + @Password));
END
