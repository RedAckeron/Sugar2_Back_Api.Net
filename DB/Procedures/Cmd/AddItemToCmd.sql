CREATE PROCEDURE [dbo].[SP_Cmd_AddItemToCmd]
    @IdItem int,
    @IdCmd int, 
    @Qt int,
    @AddByUser int
AS
BEGIN
   declare @DtIn datetime2 = GETDATE();
   INSERT INTO [ItemCmd] (IdItem,IdCmd,Qt,AddByUser, DtIn) OUTPUT Inserted.Id VALUES (@IdItem,@IdCmd, @Qt,@AddByUser,@DtIn);


RETURN 0
END