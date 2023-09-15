using BLL.Models;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface IAddressService
    {
        int CreateUserAddress(int idUser );
        int CreateCustomerAddress(int idCustomer); 
    
    AddressBll Read(int idAdr);
    int Update(AddressBll adrDal);
    int Delete(int IdAdr);
   
    }
}
