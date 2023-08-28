using BLL.Interfaces;
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
        
    public int CreateCustomerAddress(CustomerAddressDal Adr)
        {
        return _adresseRepo.CreateCustomerAddress(Adr);
        }

    public CustomerAddressDal ReadCustomerAddress(int IdAdr)
        {
        return _adresseRepo.ReadCustomerAddress(IdAdr);
        }
    public List<CustomerAddressDal> ReadCustomerAllAddress(int IdCust)
        {
            return _adresseRepo.ReadCustomerAllAddress(IdCust);
        }
        public int UpdateCustomerAddress(CustomerAddressDal Adr) 
        {
        return _adresseRepo.UpdateCustomerAddress(Adr);
        }  

    public int DeleteCustomerAddress(int id) 
        {
        return _adresseRepo.DeleteCustomerAddress(id);
        }

    public int CreateUserAddress(UserAddressDal Adr)
        {
        return _adresseRepo.CreateUserAddress(Adr);
        }

    public UserAddressDal ReadUserAddress(int IdAdr)
        {
            return _adresseRepo.ReadUserAddress(IdAdr);
        }

    public int UpdateUserAddress(UserAddressDal Adr)
        {
            return _adresseRepo.UpdateUserAddress(Adr);
        }

    public int DeleteUserAddress(int IdAdr)
        {
            return _adresseRepo.DeleteUserAddress(IdAdr);
        }
    }
}
