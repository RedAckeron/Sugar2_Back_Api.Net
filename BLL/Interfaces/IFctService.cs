using BLL.Models;

namespace BLL.Interfaces
{
    public interface IFctService
    {
        int Create(FctBll fctBll);
        FctBll Read(int IdFct);
        int Update(FctBll fctBll);
        int Delete(int IdFct);
        }
}