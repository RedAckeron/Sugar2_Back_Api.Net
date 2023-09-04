using ACTRL.Mappers;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACTRL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RprController : ControllerBase
    {
        private readonly IRprService _rprService;
        public RprController(IRprService rprService)
        {
            _rprService = rprService;
        }


        [HttpPost("Create")]
        public IActionResult Create(RprRegisterForm rprRegisterForm)
        {
            return Ok(_rprService.Create(RprControllerMapper.RprRegisterFormToRprBll(rprRegisterForm)));
        }
    }
}
