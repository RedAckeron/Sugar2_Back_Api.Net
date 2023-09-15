using ACTRL.Mappers;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BLL.Services
{
    public class AddressService:IAddressService
    { 
    private readonly IAddressRepo _adresseRepo;
    public AddressService(IAddressRepo adresseRepo)
    {
        _adresseRepo= adresseRepo;
    }
        
    public int CreateCustomerAddress(int idUser)
        {
        return _adresseRepo.CreateCustomerAddress(idUser);
        }
    public int CreateUserAddress(int idCustomer)
        {
            return _adresseRepo.CreateCustomerAddress(idCustomer);
        }

        public AddressBll Read(int IdAdr)
        {
        return AdrBllMapper.AddressDalToAddressBll(_adresseRepo.Read(IdAdr));
        }
   
        public int Update(AddressBll adrBll) 
        {
        return _adresseRepo.Update(AdrBllMapper.AddressBllToAddressDal(adrBll));
        }  

    public int Delete(int idAddresss) 
        {
        return _adresseRepo.Delete(idAddresss);
        }

    }
}
