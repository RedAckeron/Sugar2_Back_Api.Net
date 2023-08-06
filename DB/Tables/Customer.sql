CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	--[type] nvarchar(3) NOT NULL DEFAULT 'B2C',
	[FirstName] nvarchar(50) default(null),
	[LastName] nvarchar(100) default(null),
	[Email] nvarchar(300) default(null),
	[Call1] nvarchar(50) default(null),
	[Call2] nvarchar(50) default(null),
	[DtIn] datetime not null,
	[AddByUser] int not null,
	    CONSTRAINT [FK_AddByUser] FOREIGN KEY ([AddByUser]) REFERENCES [dbo].[User] ([Id])
);
