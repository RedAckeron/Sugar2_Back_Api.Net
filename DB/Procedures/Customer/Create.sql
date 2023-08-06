CREATE PROCEDURE [dbo].[SP_Customer_Create]
	
    @FirstName NVARCHAR(50), 
    @LastName NVARCHAR(100), 
    @Email NVARCHAR(300), 
    @Call1 NVARCHAR(50), 
    @Call2 NVARCHAR(50), 
    @AddByUser int
AS
BEGIN
    declare @DtIn datetime2 = GETDATE();
    /*
        Test de valeurs
    */
    INSERT INTO [Customer] (FirstName,LastName,Email,Call1,Call2,DtIn, AddByUser) Output inserted.Id VALUES ( @FirstName,@LastName,@Email,@Call1,@Call2,@DtIn,@AddByUser);

    RETURN 0
END