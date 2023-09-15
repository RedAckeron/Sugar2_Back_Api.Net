using ACTRL.Mappers;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using BLL.Services;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace ACTRL.Controllers
{
    
    [Route("/[controller]/")]
    [ApiController]

    public class CmdController : ControllerBase
    {
        private readonly ICmdService _cmdService;
        public CmdController(ICmdService cmdService)
        {
			_cmdService = cmdService;
        }
        
        [HttpPost("Create")]
        public IActionResult Create(CmdRegisterForm cmdRegisterForm)
        {
            return Ok(_cmdService.Create(CmdControllerMapper.CmdRegisterFormToCmdBll(cmdRegisterForm)));
        }
        
        [HttpGet("Read/{IdCmd}")]
        public IActionResult Read(int IdCmd)
        {
            return Ok(_cmdService.Read(IdCmd));
        }
        /*
        [HttpPut("Update")]
        public IActionResult Update(CmdDal Cmd)
        {
            return Ok(_cmdService.Update(Cmd));
        }
        */
        [HttpDelete("Delete/{IdCmd}")]
        public IActionResult Delete(int IdCmd) {
            return Ok(_cmdService.Delete(IdCmd));
        }

        [HttpPost("AddItemToCmd")]
        public IActionResult AddItemToCmd(int IdCmd,int IdItem,int Qt,int AddByUser)
        {
            return Ok(_cmdService.AddItemToCmd(IdCmd ,IdItem,Qt,AddByUser));
        }
        [HttpGet("ReadAllCmdLight/{IdCust}")]
        public IActionResult ReadAllCmdLight(int IdCust)
        {
            return Ok(_cmdService.ReadAllCmdLight(IdCust));
        }
    }
}
