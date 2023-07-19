CREATE PROCEDURE [dbo].[SP_User_Delete]
	@IdUser int
AS
BEGIN
--declare @DtOut datetime2 = GETDATE();
Delete from [User] where Id = @IdUser;
return 0;
END