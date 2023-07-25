CREATE PROCEDURE [dbo].[SP_CustomerAdresse_Create]
	
    @IdCustomer int, 
    @AdrInfo NVARCHAR(20),
    @AdrRue nvarchar(100),
    @AdrNo nvarchar(10),
    @AdrVille nvarchar(100),
    @AdrCp nvarchar(10),
    @AdrPays nvarchar(50)

AS
BEGIN
    INSERT INTO [CustomerAdresse] (IdCustomer,AdrInfo,AdrRue, AdrNo,AdrVille,AdrCp,AdrPays) Output inserted.Id 
    VALUES ( @IdCustomer,@AdrInfo,@AdrRue,@AdrNo,@AdrVille,@AdrCp,@AdrPays);

    RETURN 0
END