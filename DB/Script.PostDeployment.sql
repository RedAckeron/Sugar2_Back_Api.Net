--insert into [User] (Email,Password,FirstName,LastName,DtIn)values('redackeron@gmail.com','囎ퟔ긋옭ꩈ᪰佮憟ﺺ䴉瀨F⊛䓿⌠汦㎬宐浍湸꥚忒俄㷚퉟�䂧皁','Admin','Admin','2023-06-26T11:49:12.512Z');
--insert into [User] (Email,Password,FirstName,LastName,DtIn)values('devilder.d@gmail.com','囎ퟔ긋옭ꩈ᪰佮憟ﺺ䴉瀨F⊛䓿⌠汦㎬宐浍湸꥚忒俄㷚퉟�䂧皁','David','De Vilder','2023-06-26T11:49:12.512Z');

exec SP_User_Create 
@LastName='Administrator',
@FirstName='Administrator',
@Email='redackeron@gmail.com',
@Password='strike';


exec SP_Log_Create
@Priority =3,
@AddByUser=1,
@Msg='Creation de l utilisateur Administrateur';

exec SP_User_Create 
@LastName='De Vilder',
@FirstName='David',
@Email='devilder.d@gmail.com',
@Password='strike';

exec SP_Log_Create
@Priority =1,
@AddByUser=1,
@Msg='Creation de l utilisateur David De Vilder';

exec SP_Customer_Create
@FirstName='Jean',
@LastName='Brouille',
@AddByUser=1;

exec SP_Log_Create
@Priority =1,
@AddByUser=1,
@Msg='Creation du client Jean Brouille';

exec SP_Customer_Create
@FirstName='Jerry',
@LastName='Khan',
@AddByUser=1;

exec SP_Log_Create
@Priority =1,
@AddByUser=1,
@Msg='Creation du client Jerry Khan';

exec SP_Customer_Create
@FirstName='Jeanne',
@LastName='Dark',
@AddByUser=1

exec SP_Log_Create
@Priority =1,
@AddByUser=1,
@Msg='Creation du client Jeanne Dark';

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


