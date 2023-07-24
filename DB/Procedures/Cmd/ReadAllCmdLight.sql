CREATE PROCEDURE [dbo].[SP_Cmd_ReadAllCmdLight]
    @IdCust int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT id,DtIn
	FROM [Cmd]
	WHERE IdCustomer = @IdCust
	RETURN 0;
END
