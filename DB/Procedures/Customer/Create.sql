CREATE PROCEDURE [dbo].[SP_Customer_Create]
	
    @FirstName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @AddByUser int
AS
BEGIN
    declare @DtIn datetime2 = GETDATE();
    /*
        Test de valeurs
    */
    INSERT INTO [Customer] (FirstName,LastName,DtIn, AddByUser) Output inserted.Id VALUES ( @FirstName,@LastName,@DtIn,@AddByUser);

    RETURN 0
END