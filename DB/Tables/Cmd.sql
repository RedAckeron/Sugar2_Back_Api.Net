CREATE TABLE [dbo].[Cmd]
(
	[Id] INT NOT NULL IDENTITY,
	[AddByUser] int not null ,
	[IdCustomer] int not null, 
    [DtIn] DATETIME2 NOT NULL,
	
	CONSTRAINT [FK_Cmd_AddByUser] FOREIGN KEY ([AddByUser]) REFERENCES [dbo].[User] ([Id]),
	CONSTRAINT [FK_Cmd_IdCustomer] FOREIGN KEY ([IdCustomer]) REFERENCES [dbo].Customer ([Id]), 
    CONSTRAINT [PK_Cmd] PRIMARY KEY ([Id])

)
