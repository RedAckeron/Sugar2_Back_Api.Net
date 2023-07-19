CREATE PROCEDURE [dbo].[SP_Cmd_Update]
    @Id int,
    @Email NVARCHAR(384),
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50)
AS
BEGIN
    /*
        Test de valeurs
    */
    UPDATE [User] set Email=@Email,FirstName=@FirstName,LastName=@LastName where id = @Id;
    RETURN 0
END