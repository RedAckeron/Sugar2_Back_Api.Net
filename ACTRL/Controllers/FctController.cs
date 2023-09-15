using ACTRL.Mappers;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace ACTRL.Controllers
{
    [Route("/[controller]/")]
    [ApiController]
    public class FctController : Controller
    {
        private readonly IFctService _fctService;
        public FctController(IFctService fctService)
        {
            _fctService = fctService;
        }

        [HttpPost("Create")]
        public IActionResult Create(FctRegisterForm fctRegisterForm)
        {
            return Ok(_fctService.Create(FctControllerMapper.FctRegisterFormToCmdBll(fctRegisterForm)));
        }
    }
}
