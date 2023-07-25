CREATE TABLE [dbo].[CustomerAdresse]
(
	[Id] INT NOT NULL identity PRIMARY KEY,
	[IdCustomer] int not null ,
	[AdrInfo] nvarchar(20) default(null),
	[AdrRue] nvarchar(100) default(null),
	[AdrNo] nvarchar(10) default(null),
	[AdrVille] nvarchar(100) default(null),
	[AdrCp] nvarchar(10) default(null),
	[AdrPays] nvarchar(50) default(null)
	
	    CONSTRAINT [FK_IdCustomer] FOREIGN KEY ([IdCustomer]) REFERENCES [dbo].[Customer] ([Id])
);
