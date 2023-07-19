CREATE PROCEDURE [dbo].[SP_Item_Delete]
	@IdItem int
AS
BEGIN
Delete from [Item] where Id = @IdItem;
return 0;
END