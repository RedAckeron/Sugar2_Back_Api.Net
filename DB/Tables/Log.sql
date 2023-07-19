CREATE TABLE [dbo].[Log]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[DtIn] datetime2 not null default(GetDate()),
	[Priority] int not null,
	[AddByUser] int not null,
	[Msg] nvarchar(200),
	CONSTRAINT [FK_Log_AddByUser] FOREIGN KEY ([AddByUser]) REFERENCES [dbo].[User] ([Id]),

)
