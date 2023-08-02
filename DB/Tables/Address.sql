CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL identity,
	[AdrInfo] nvarchar(20) default(null),
	[AdrRue] nvarchar(100) default(null),
	[AdrNo] nvarchar(10) default(null),
	[AdrVille] nvarchar(100) default(null),
	[AdrCp] nvarchar(10) default(null),
	[AdrPays] nvarchar(50) default(null), 
    CONSTRAINT [PK_Address] PRIMARY KEY ([Id])
	
);
