CREATE PROCEDURE [dbo].[SP_User_register]
	@LastName NVARCHAR(50), 
    @FirstName NVARCHAR(50), 
    @Email NVARCHAR(384), 
    @Password NVARCHAR(50)
   
AS
BEGIN
    declare 
    @DtIn datetime2 = GETDATE(),
    @Passwordhash Binary(64),
    @SecurityStamp uniqueidentifier;

    set @SecurityStamp=newid()
    set @Passwordhash =dbo.F_Hasher (trim(@Password),@SecurityStamp)

    INSERT INTO [User] (Email,Password,FirstName,LastName,SecurityStamp)
    values(trim(@Email),@Passwordhash,trim(@FirstName),trim(@LastName),@SecurityStamp)
END
RETURN 0
