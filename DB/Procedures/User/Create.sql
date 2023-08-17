CREATE PROCEDURE [dbo].[SP_User_Create]
	@LastName NVARCHAR(50), 
    @FirstName NVARCHAR(50), 
    @Email NVARCHAR(384), 
    @Password NVARCHAR(50)
   
AS
BEGIN
    declare 
    @DtIn datetime2 = GETDATE();
  
    /*
        Test de valeurs
    */
    INSERT INTO [User] (LastName, FirstName, Email, Password,DtIn) OUTPUT inserted.Id VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', CONCAT(dbo.CSF_GetPreSalt(), @Password, dbo.CSF_GetPostSalt())),@DtIn);
    
    RETURN 0
END