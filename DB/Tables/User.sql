CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL identity ,
	[Email]nvarchar(250) not null,
	[Password]binary(64) not null,
	[FirstName] nvarchar(50) not null,
	[LastName] nvarchar(100) not null,
	[IsActive] Bit not null default(1),
	[DtIn] datetime not null, 
	[DtOut] datetime default(null),
	[SecurityStamp] uniqueidentifier null,
	[RefreshToken] nvarchar(255) null,
	[RefreshTokenExpiration] datetime2 null,
	[IsAdmin] bit not null default 0,


    CONSTRAINT [PK_User] PRIMARY KEY ([Id]),
	CONSTRAINT [Email_Unique] unique(Email),
	--[MainAdrRue] nvarchar(150)not null,
	--[MainAdrNo]int not null,
	--[MainAdrCp]int not null,
	--[MainAdrVille]nvarchar(100),
	--[MainAdrPays]nvarchar(50),
	--[LivrAdrRue] nvarchar(150)not null,
	--[LivrAdrNo]int not null,
	--[LivrAdrCp]int not null,
	--[LivrAdrVille]nvarchar(100),
	--[LivrAdrPays]nvarchar(50)
	);
  /*
  `adresse` text DEFAULT NULL,
  `cp` varchar(10) DEFAULT NULL,
  `ville` varchar(50) DEFAULT NULL,
  `adresse_livraison` text DEFAULT NULL,
  `cp_livraison` varchar(10) DEFAULT NULL,
  `ville_livraison` varchar(50) DEFAULT NULL,
  `call1` varchar(15) DEFAULT NULL,
  `call2` varchar(15) DEFAULT NULL,
  `call3` varchar(15) DEFAULT NULL,
  `mail1` varchar(100) NOT NULL DEFAULT 'no@mail.com',
  `mail2` varchar(100) NOT NULL,
  `mail3` varchar(100) NOT NULL,
  `no_tva` varchar(25) DEFAULT NULL,
  `reduction` int(11) NOT NULL DEFAULT 0,
  `dt_insert` int(11) NOT NULL DEFAULT 0,
  `dt_acces` int(11) NOT NULL DEFAULT 0,
  `dt_modif` int(11) NOT NULL DEFAULT 0,
  `tech_in` int(11) NOT NULL DEFAULT 0,
  `id_shop` int(11) NOT NULL DEFAULT 3,
  `info_add` text NOT NULL,
  `migrated` int(11) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`)
  */
  