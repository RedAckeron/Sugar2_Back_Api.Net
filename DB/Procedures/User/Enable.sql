CREATE PROCEDURE [dbo].[CSP_User_Enable]
	@IdUser int
AS
BEGIN
update [User] set DtOut=null,IsActive=1 where Id=@IdUser; 
return 0;
END