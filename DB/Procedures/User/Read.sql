CREATE PROCEDURE [dbo].[SP_User_Read]
    @Id int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT Id,LastName,FirstName,Email,DtIn
	FROM [User]
	WHERE id = @Id
	RETURN 0;
END
