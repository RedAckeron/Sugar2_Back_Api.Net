CREATE PROCEDURE [dbo].[SP_Address_ReadCustomerAddress]
	@IdAdr int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT *
	FROM Address
	INNER JOIN CustomerAddress 
	on Address.id = CustomerAddress.IdAddress
	where Address.Id= @IdAdr;
	RETURN 0;
END
