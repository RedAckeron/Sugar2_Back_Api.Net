CREATE PROCEDURE [dbo].[CSP_User_Disable]
	@IdUser int
AS
BEGIN
declare @DtOut datetime2 = GETDATE();
update [User] set DtOut=@DtOut,IsActive=0 where Id=@IdUser; 
return 0;
END