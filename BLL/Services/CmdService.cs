using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Data.Common;

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
    #region Create
        public int Create(CmdBll cmdBll)
        {
            return _cmdRepo.Create(CmdServiceMapper.CmdBllToCmdDal(cmdBll));
        }
        #endregion
    #region Read
        public CmdBll Read(int IdCmd)
        {
            CmdBll Cmd = CmdServiceMapper.CmdDalToCmdBll(_cmdRepo.Read(IdCmd));
            Cmd.Basket = _itemRepo.ReadAllOfCmd(IdCmd);
            return Cmd;
        }
    #endregion
    #region Update
        public int Update(CmdBll cmdBll)
        {
            return _cmdRepo.Update(CmdServiceMapper.CmdBllToCmdDal(cmdBll) );
        }
    #endregion
    #region Delete
        public int Delete(int IdCmd)
        {
            return _cmdRepo.Delete(IdCmd);
        }
        #endregion
    #region AddItemToCmd
        public int AddItemToCmd(int IdCmd, int IdItem, int Qt, int AddByUser)
        {
            return _cmdRepo.AddItemToCmd(IdCmd, IdItem, Qt, AddByUser);
        }
        #endregion
    #region ReadAllCmdLight
        public List<CmdBllLight> ReadAllCmdLight(int IdCust)
        {
            return CmdServiceMapper.CmdDalLightToCmdBllLight(_cmdRepo.ReadAllCmdLight(IdCust));
        }
    #endregion
    }
}
