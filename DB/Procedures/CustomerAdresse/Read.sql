CREATE PROCEDURE [dbo].[SP_CustomerAdresse_Read]
	@IdCust int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT *
	FROM [CustomerAdresse]
	WHERE IdCustomer = @IdCust;
	RETURN 0;
END
