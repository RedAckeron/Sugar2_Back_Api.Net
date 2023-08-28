using DAL.Models;

namespace DAL.Interfaces
{
    public interface ICmdRepo
    {
        int Create(CmdDal cmdDal);
		CmdDal Read(int IdCmd);
        int Update(CmdDal Cmd);
        int Delete(int IdCmd);
        int AddItemToCmd(int IdCmd, int IdItem, int Qt, int AddByUser);
        List<CmdDalLight> ReadAllCmdLight(int IDCust);

    }
}