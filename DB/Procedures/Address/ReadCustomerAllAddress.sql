CREATE PROCEDURE [dbo].[SP_Address_ReadCustomerAllAddress]
	@IdCust int 
AS
BEGIN
	/*
        Test de valeurs
    */
	
SELECT *
	FROM Address
	INNER JOIN CustomerAddress 
	on Address.id = CustomerAddress.IdAddress
	where CustomerAddress.IdCustomer= @IdCust;
	RETURN 0;
END
