using BLL.Models;

namespace BLL.Interfaces
{
    public interface IRprService
    {
        int Create(RprBll rprBll);
		RprBll Read(int IdRpr);
        int Update(RprBll rprBll);
        int Delete(int IdRpr);
        }

}