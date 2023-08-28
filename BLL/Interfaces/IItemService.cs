using DAL.Models;

namespace BLL.Interfaces
{
    public interface IItemService
    {
        int Create(ItemDal Item);
        ItemDal Read(int IdItem);
        List<ItemDal>ReadAllOfCmd(int IdCmd);
        int Update(ItemDal Item);
        int Delete(int IdItem);
        }
}