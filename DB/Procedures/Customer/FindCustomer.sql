CREATE PROCEDURE [dbo].[SP_Customer_FindCustomer]
	
    @Customer NVARCHAR(50)
    
AS
BEGIN
    select Id,FirstName,LastName from customer where FirstName LIKE @Customer
    union 
    select Id,FirstName,LastName from customer fn where LastName LIKE @Customer

    RETURN 0
END