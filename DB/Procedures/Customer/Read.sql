CREATE PROCEDURE [dbo].[SP_Customer_Read]
	@IdCust int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT *
	FROM [Customer]
	WHERE Id = @IdCust;
	RETURN 0;
END
