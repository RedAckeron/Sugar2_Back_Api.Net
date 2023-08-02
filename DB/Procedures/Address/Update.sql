CREATE PROCEDURE [dbo].[SP_Adresse_Update]
	@Id int,
    @AdrInfo NVARCHAR(20),
    @AdrRue nvarchar(100),
    @AdrNo nvarchar(10),
    @AdrVille nvarchar(100),
    @AdrCp nvarchar(10),
    @AdrPays nvarchar(50)

AS
BEGIN
    Update [Adresse] 
    set AdrInfo=@AdrInfo,AdrRue=@AdrRue,AdrNo=@AdrNo,AdrVille=@AdrVille,@AdrCp=@AdrCp,AdrPays=@AdrPays
    where id = @Id
    RETURN 0
END