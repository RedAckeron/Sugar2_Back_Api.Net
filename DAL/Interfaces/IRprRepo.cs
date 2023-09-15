using DAL.Models;

namespace DAL.Interfaces
{
    public interface IRprRepo
    {
        int Create(RprDal rprDal);
        RprDal Read(int IdRpr);
        int Update(RprDal rprDal);
        int Delete(int IdRpr);
        List<RprDalLight> ReadAllRprLight(int IDCust);

    }
}