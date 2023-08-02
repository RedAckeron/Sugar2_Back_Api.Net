CREATE TABLE [dbo].[UserAddress]
(
	[Id] INT NOT NULL identity,
	[IdUser] int not null, 
	[IdAddress] int not null, 
	CONSTRAINT [FK_UserAddress_IdUser] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([Id]),
	CONSTRAINT [FK_UserAddress_IdAddress] FOREIGN KEY ([IdAddress]) REFERENCES [dbo].[Address] ([Id]), 
    CONSTRAINT [PK_UserAddress] PRIMARY KEY ([Id])


)
