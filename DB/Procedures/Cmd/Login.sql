CREATE PROCEDURE [dbo].[SP_Cmd_Login]
	@Email NVARCHAR(384), 
    @Password NVARCHAR(20) 
AS
BEGIN
print(@Email+' - '+@Password);
	/*
        Test de valeurs
    */
	SELECT Id, LastName, FirstName, @Email AS Email,DtIn
	FROM [User]
	WHERE Email = @Email AND Password = HASHBYTES('SHA2_512', CONCAT(dbo.CSF_GetPreSalt(), @Password, dbo.CSF_GetPostSalt()));
	RETURN 0;
END