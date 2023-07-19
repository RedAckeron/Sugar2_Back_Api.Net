using DAL.Models;

namespace BLL.Interfaces
{
    public interface ICmdService
    {
        int Create(Cmd Cmd);
		Cmd Read(int IdCmd);
        int Update(Cmd Cmd);
        int Delete(int IdCmd);
        int AddItemToCmd(int IdCmd, int IdItem,int Qt,int AddByUser);
        }
}