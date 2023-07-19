CREATE PROCEDURE [dbo].[SP_Customer_Delete]
	@IdCust int
AS
BEGIN
Delete from [Customer] where Id = @IdCust;
return 0;
END