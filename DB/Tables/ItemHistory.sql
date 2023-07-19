CREATE TABLE [dbo].[ItemHistory]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[IdItem] int not null,
	[Name] nvarchar(200),
	[Url] nvarchar(500),
	[PrxAchat] int not null default(0),
	[PrxVente] int not null default(0),
	[DtIn] int not null,
	[DtOut] int not null,
	[AddByUser] int not null,
		CONSTRAINT [FK_ItemHistory_AddByUser] FOREIGN KEY ([AddByUser]) REFERENCES [dbo].[User] ([Id]),
		CONSTRAINT [FK_ItemHistory_IdItem] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item] ([Id])
)