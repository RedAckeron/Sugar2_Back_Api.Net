--Creation de 3 Utilisateurs avec une adresse
exec SP_User_Create @LastName='Administrator',@FirstName='Administrator',@Email='redackeron@gmail.com',@Password='strike';
exec Sp_Address_CreateUserAddress @IdUser=1, @AdrInfo='Domicile',@AdrRue='Avenue des oiseaux',@AdrNo=10, @AdrVille='Bruxelles',@AdrCp='1000',@AdrPays='Belgique';
exec SP_Log_Create @Priority =3,@AddByUser=1,@Msg='Creation de l utilisateur Administrateur';

exec SP_User_Create @LastName='De Vilder',@FirstName='David',@Email='devilder.d@gmail.com',@Password='strike';
exec Sp_Address_CreateUserAddress @IdUser=2, @AdrInfo='Domicile',@AdrRue='Avenue des oiseaux',@AdrNo=10, @AdrVille='Bruxelles',@AdrCp='1000',@AdrPays='Belgique';
exec SP_Log_Create @Priority =1,@AddByUser=1,@Msg='Creation de l utilisateur David De Vilder';

exec SP_User_Create @LastName='Test',@FirstName='Test',@Email='test@test.com',@Password='test';
exec Sp_Address_CreateUserAddress @IdUser=3, @AdrInfo='Domicile',@AdrRue='Avenue des oiseaux',@AdrNo=10, @AdrVille='Bruxelles',@AdrCp='1000',@AdrPays='Belgique';
exec SP_Log_Create @Priority =1,@AddByUser=1,@Msg='Creation de l utilisateur Test test';


--Creation de 3 clients avec leur adresse 
exec SP_Customer_Create @FirstName='Jean', @LastName='Brouille', @Email='jb@skynet.be',@Call1='0494568745',@Call2='0497878485',@AddByUser=1;
exec Sp_Address_CreateCustomerAddress @IdCustomer=1, @AdrInfo='Domicile',@AdrRue='Avenue des oiseaux',@AdrNo=10, @AdrVille='Bruxelles',@AdrCp='1000',@AdrPays='Belgique';
exec Sp_Address_CreateCustomerAddress @IdCustomer=1, @AdrInfo='Travail',@AdrRue='Rue de la defense',@AdrNo=68, @AdrVille='Mons',@AdrCp='5020',@AdrPays='Belgique';
exec SP_Log_Create @Priority =1, @AddByUser=1, @Msg='Creation du client Jean Brouille';

exec SP_Customer_Create @FirstName='Jerry', @LastName='Khan',@Email='jb@skynet.be',@Call1='0494568745',@Call2='0497878485',@AddByUser=1;
exec Sp_Address_CreateCustomerAddress @IdCustomer=2,@AdrInfo='Domicile',@AdrRue='Avenue des oiseaux',@AdrNo=12, @AdrVille='Bruxelles',@AdrCp='1000',@AdrPays='Belgique';
exec SP_Log_Create @Priority =1, @AddByUser=1, @Msg='Creation du client Jerry Khan';

exec SP_Customer_Create @FirstName='Jeanne', @LastName='Dark',@Email='jb@skynet.be',@Call1='0494568745',@Call2='0497878485',@AddByUser=1;
exec Sp_Address_CreateCustomerAddress @IdCustomer=3,@AdrInfo='Domicile',@AdrRue='Avenue des oiseaux',@AdrNo=14, @AdrVille='Bruxelles',@AdrCp='1000',@AdrPays='Belgique';
exec SP_Log_Create @Priority =1, @AddByUser=1, @Msg='Creation du client Jeanne Dark';


--creation des items
exec SP_Item_Create
@Label='Disque dur SSD 250 GB',
@Url='www.test.com/disque dur',
@PrxAchat=39.32,
@PrxVente=59.99,
@AddByUser=1;

exec SP_Item_Create
@Label='Disque dur SSD 500 GB',
@Url='www.test.com/disque dur',
@PrxAchat=65.82,
@PrxVente=99.99,
@AddByUser=1;

exec SP_Item_Create
@Label='Disque dur SSD 1To',
@Url='www.test.com/disque dur',
@PrxAchat=102.65,
@PrxVente=129.99,
@AddByUser=1;

exec SP_Item_Create
@Label='CPU Intel I7 13700K',
@Url='www.test.com/disque dur',
@PrxAchat=292.98,
@PrxVente=399.99,
@AddByUser=1;

exec SP_Item_Create
@Label='CPU Amd Ryzen 7 5700X',
@Url='www.test.com/disque dur',
@PrxAchat=261.78,
@PrxVente=359.99,
@AddByUser=1;

--On creez une commande pour le client 1
exec SP_Cmd_Create
@AddByUser=1,
@IdCustomer=1;

exec SP_Log_Create
@Priority =1,
@AddByUser=1,
@Msg='Creation d une commande pour customer 1';

--On rajoute des items dans la commande 


