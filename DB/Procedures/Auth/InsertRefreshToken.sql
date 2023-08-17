CREATE PROCEDURE [dbo].[InsertRefreshToken]
	@Email nvarchar(384),
	@NewrefreshToken nvarchar(255),
	@RefreshTokenExpiration Datetime

AS
BEGIN
	update [user] set @NewrefreshToken=@NewrefreshToken,
	RefreshTokenExpiration=@RefreshTokenExpiration
	WHERE Email=@Email;
END
RETURN 0
