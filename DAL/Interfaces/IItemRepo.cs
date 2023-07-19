using DAL.Models;


namespace DAL.Interfaces
{
    public interface IItemRepo
    {
        int Create(Item Item);
        Item Read(int id);
        List<Item> ReadAllOfCmd(int IdCmd);
        int Update(Item Item);
        int Delete(int id);
    }
}