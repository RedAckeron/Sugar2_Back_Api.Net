CREATE PROCEDURE [dbo].[SP_Item_Create]
	
    @Label NVARCHAR(100), 
    @Url NVARCHAR(500), 
    @PrxAchat float, 
    @PrxVente float,
    @AddByUser int
AS
BEGIN
    declare @DtIn datetime2 = GETDATE();
    /*
        Test de valeurs
    */
    INSERT INTO [Item] (Label,Url,PrxAchat,PrxVente,DtIn,AddByUser) Output inserted.Id VALUES (@Label, @Url,@PrxAchat,@PrxVente,@DtIn,@AddByUser);
    RETURN 0
END