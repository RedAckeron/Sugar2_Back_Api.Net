CREATE TABLE [dbo].[CustomerAddress]
(
	[Id] INT NOT NULL identity,
	[IdCustomer] int not null, 
	[IdAddress] int not null, 
    CONSTRAINT [PK_CustomerAddress] PRIMARY KEY ([Id]), 
	CONSTRAINT [FK_CustomerAddress_IdCustomer] FOREIGN KEY ([IdCustomer]) REFERENCES [dbo].[Customer] ([Id]),
	CONSTRAINT [FK_CustomerAddress_IdAddress] FOREIGN KEY ([IdAddress]) REFERENCES [dbo].[Address] ([Id])


)
