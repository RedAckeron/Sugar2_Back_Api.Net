CREATE FUNCTION [dbo].[F_Hasher]
(
    @Password VARCHAR(128),
    @SecurityStamp UNIQUEIDENTIFIER
)
RETURNS BINARY(64)
AS
BEGIN
    DECLARE @hashedValue BINARY(64) = CONVERT(BINARY(64), CONCAT(HASHBYTES('SHA2_512', (@password + CAST(@securityStamp AS VARCHAR(36)))), @securityStamp))
    RETURN @hashedvalue
END