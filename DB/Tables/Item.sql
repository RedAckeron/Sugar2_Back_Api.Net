CREATE TABLE [dbo].[Item]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	[Label] nvarchar(200),
	[Url] nvarchar(500),
	[PrxAchat] float not null default(0),
	[PrxVente] float not null default(0),
	[DtIn] datetime2 ,
	[AddByUser] int not null,
		CONSTRAINT [FK_Items_AddByUser] FOREIGN KEY ([AddByUser]) REFERENCES [dbo].[User] ([Id])
)
