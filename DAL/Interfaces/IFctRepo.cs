using DAL.Models;

namespace DAL.Interfaces
{
    public interface IFctRepo
    {
        
        int Create(FctDal fctDal);
		FctDal Read(int IdFct);
        int Update(FctDal fctDal);
        int Delete(int IdFct);
        
        }
}