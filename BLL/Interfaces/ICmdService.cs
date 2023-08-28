using BLL.Models;
using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICmdService
    {
        int Create(CmdBll cmdBll);
		CmdBll Read(int IdCmd);
        int Update(CmdBll Cmd);
        int Delete(int IdCmd);
        int AddItemToCmd(int IdCmd, int IdItem,int Qt,int AddByUser);
        List<CmdBllLight> ReadAllCmdLight(int IDCust);

    }
}