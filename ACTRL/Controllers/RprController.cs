using ACTRL.Mappers;
using ACTRL.Models.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACTRL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RprController : ControllerBase
    {

        [HttpPost("Create")]
        public IActionResult Create(CmdRegisterForm cmdRegisterForm)
        {
            return Ok(_rprService.Create(CmdControllerMapper.CmdRegisterFormToCmdBll(cmdRegisterForm)));
        }


    }
}
