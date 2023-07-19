CREATE TABLE [dbo].[ItemCmd]
(
	[Id] INT NOT NULL IDENTITY,
	[IdItem] int not null,
	[IdCmd] int not null,
	[Qt] int not null,
	[DtIn] DATETIME2 not null,
	[AddByUser] int not null
		CONSTRAINT [FK_ItemsCmd_AddByUser] FOREIGN KEY ([AddByUser]) REFERENCES [dbo].[User] ([Id]),
		CONSTRAINT [FK_ItemsCmd_IdItem] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item] ([Id]),
		CONSTRAINT [FK_ItemsCmd_Idcmd] FOREIGN KEY ([IdCmd]) REFERENCES [dbo].[Cmd] ([Id]), 
		CONSTRAINT [PK_ItemCmd] PRIMARY KEY ([Id])
)
