CREATE PROCEDURE [dbo].[SP_Adresse_Delete]
	@Id int
AS
BEGIN
    Delete From [Address]
    where id = @Id;
    RETURN 0
END