CREATE TABLE [dbo].[ItemOdp]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[IdItem] int not null,
	[IdOdp] int not null,
	[Qt] int not null,
		CONSTRAINT [FK_ItemsOdp_IdItem] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item] ([Id]),
		CONSTRAINT [FK_ItemsOdp_IdOdp] FOREIGN KEY ([IdOdp]) REFERENCES [dbo].[Odp] ([Id])
)
