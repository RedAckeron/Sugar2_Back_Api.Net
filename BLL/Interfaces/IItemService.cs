using DAL.Models;

namespace BLL.Interfaces
{
    public interface IItemService
    {
        int Create(Item Item);
        Item Read(int IdItem);
        List<Item>ReadAllOfCmd(int IdCmd);
        int Update(Item Item);
        int Delete(int IdItem);
        }
}