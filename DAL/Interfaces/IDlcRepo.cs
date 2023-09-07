using DAL.Models;

namespace DAL.Interfaces
{
    public interface IDlcRepo
    {
        int Create(DlcDal dlcDal);
        DlcDal Read(int IdDlc);
        int Update(DlcDal dlcDal);
        int Delete(int IdDlc);
        List<DlcDalLight> ReadAllDlcLight(int IdCust);

    }
}