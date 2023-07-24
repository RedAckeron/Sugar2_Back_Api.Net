using DAL.Models;

namespace DAL.Interfaces
{
    public interface ICmdRepo
    {
        int Create(Cmd Cmd);
		Cmd Read(int IdCmd);
        int Update(Cmd Cmd);
        int Delete(int IdCmd);
        int AddItemToCmd(int IdCmd, int IdItem, int Qt, int AddByUser);
        List<CmdLight> ReadAllCmdLight(int IDCust);

    }
}