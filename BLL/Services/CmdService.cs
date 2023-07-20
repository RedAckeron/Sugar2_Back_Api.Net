using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using DAL.Repositories;
using Microsoft.Data.SqlClient;
using System;

namespace BLL.Services
{
    public class CmdService:ICmdService
    {
    private readonly ICmdRepo _cmdRepo;
    private readonly IItemRepo _itemRepo;

    public CmdService(ICmdRepo cmdRepo,IItemRepo itemRepo)
        {
			_cmdRepo = cmdRepo;
            _itemRepo = itemRepo;
        }
    public int Create(Cmd Cmd)
        {
            return _cmdRepo.Create(Cmd);
        }
    public Cmd Read(int IdCmd)
        {
            Cmd Cmd = _cmdRepo.Read(IdCmd);
            Cmd.Basket=_itemRepo.ReadAllOfCmd(IdCmd);
			return Cmd;
        }
    public int Update(Cmd Cmd) 
        {
            return _cmdRepo.Update(Cmd);
        }
    public int Delete(int IdCmd) 
        {
            return _cmdRepo.Delete(IdCmd);
        }
    public int AddItemToCmd(int IdCmd, int IdItem ,int Qt,int AddByUser) 
        {
            return _cmdRepo.AddItemToCmd(IdCmd,IdItem,Qt,AddByUser);
        }
    }
}
