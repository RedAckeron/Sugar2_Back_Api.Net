using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAddressRepo
    {
        int CreateUserAddress(int idUser);
        int CreateCustomerAddress(int idCustomer);
        AdrDal Read(int IdAdr);
        int Update(AdrDal Adr);
        int Delete(int IdAdr);
        public List<AdrDalLight> ReadAllAdrLight(int IdCust);



    }
}
