CREATE PROCEDURE [dbo].[SP_Item_Read]
	@IdItem int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT *
	FROM [Item]
	WHERE Id = @IdItem;
	RETURN 0;
END