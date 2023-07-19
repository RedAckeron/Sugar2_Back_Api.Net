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
        
    public int Create(Item Item)
        {
            return _itemRepo.Create(Item);
        }
    public Item Read(int IdItem)
        {
            return _itemRepo.Read(IdItem);
        }
    public List<Item>ReadAllOfCmd(int IdCmd)
        {
            return _itemRepo.ReadAllOfCmd(IdCmd);
        }
    public int Update(Item Item) 
        {
            return _itemRepo.Update(Item);
        }  
    public int Delete(int IdItem) 
        {
            return _itemRepo.Delete(IdItem);
        }
    }
}
