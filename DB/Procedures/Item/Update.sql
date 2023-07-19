CREATE PROCEDURE [dbo].[SP_Item_Update]
    @IdItem int,
    @Label NVARCHAR(100),
    @Url nvarchar(500),
    @PrxAchat float,
    @PrxVente float,
    @AddByUser int
AS
BEGIN
    /*
        Test de valeurs
    */
    UPDATE [Item]
    set 
    Label=@Label,
    Url=@Url,
    PrxAchat=@PrxAchat,
    PrxVente=@PrxVente
    where id = @IdItem;
    RETURN 0
END