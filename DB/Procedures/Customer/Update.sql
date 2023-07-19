CREATE PROCEDURE [dbo].[SP_Customer_Update]
    @Id int,
    @FirstName NVARCHAR(384),
    @LastName NVARCHAR(50)
AS
BEGIN
    /*
        Test de valeurs
    */
    UPDATE [Customer] 
    set FirstName=@FirstName,
    LastName=@LastName 
    where id = @Id;
    RETURN 0
END