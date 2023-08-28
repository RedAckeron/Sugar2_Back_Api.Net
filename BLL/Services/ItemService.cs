using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class ItemService:IItemService
    { 
    private readonly IItemRepo _itemRepo;
    public ItemService(IItemRepo itemRepo)
    {
        _itemRepo = itemRepo;
    }
        
    public int Create(ItemDal Item)
        {
            return _itemRepo.Create(Item);
        }
    public ItemDal Read(int IdItem)
        {
            return _itemRepo.Read(IdItem);
        }
    public List<ItemDal>ReadAllOfCmd(int IdCmd)
        {
            return _itemRepo.ReadAllOfCmd(IdCmd);
        }
    public int Update(ItemDal Item) 
        {
            return _itemRepo.Update(Item);
        }  
    public int Delete(int IdItem) 
        {
            return _itemRepo.Delete(IdItem);
        }
    }
}
