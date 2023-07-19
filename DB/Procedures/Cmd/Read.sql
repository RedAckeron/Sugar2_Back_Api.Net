CREATE PROCEDURE [dbo].[SP_Cmd_Read]
    @IdCmd int 
AS
BEGIN
	/*
        Test de valeurs
    */
	SELECT *
	FROM [Cmd]
	WHERE id = @IdCmd
	RETURN 0;
END
