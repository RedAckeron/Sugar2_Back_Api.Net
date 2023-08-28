using DAL.Models;


namespace DAL.Interfaces
{
    public interface IItemRepo
    {
        int Create(ItemDal Item);
        ItemDal Read(int id);
        List<ItemDal> ReadAllOfCmd(int IdCmd);
        int Update(ItemDal Item);
        int Delete(int id);
    }
}