CREATE PROCEDURE [dbo].[SP_Address_CreateUserAddress]
	@IdUSer int,
    @AdrInfo NVARCHAR(20),
    @AdrRue nvarchar(100),
    @AdrNo nvarchar(10),
    @AdrVille nvarchar(100),
    @AdrCp nvarchar(10),
    @AdrPays nvarchar(50)

AS
BEGIN
declare @id integer
--insertion de l adresse 
    INSERT INTO [Address] (AdrInfo,AdrRue, AdrNo,AdrVille,AdrCp,AdrPays)
    VALUES ( @AdrInfo,@AdrRue,@AdrNo,@AdrVille,@AdrCp,@AdrPays);
    
    set @id = @@IDENTITY;
--insertion dans la table d eclatement 
    insert into UserAddress(IdUser,IdAddress)values (@IdUSer,@id);
    RETURN 0
END