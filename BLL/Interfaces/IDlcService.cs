using BLL.Models;

namespace BLL.Interfaces
{
    public interface IDlcService
    {
        int Create(DlcBll dlcBll);
		DlcBll Read(int IdDlc);
        int Update(DlcBll dlcBll);
        int Delete(int IdDlc);
        List<DlcBllLight> ReadAllDlcLight(int IDCust);
    }
}