using ACTRL.Mappers;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ACTRL.Controllers
{
    [Route("/[controller]/")]
    [ApiController]

    public class DlcController : Controller
    {

        private readonly IDlcService _dlcService;
        public DlcController(IDlcService dlcService)
        {
            _dlcService = dlcService;
        }

        [HttpPost("Create")]
        public IActionResult Create(DlcRegisterForm dlcRegisterForm)
        {
            return Ok(_dlcService.Create(DlcControllerMapper.DlcRegisterFormToDlcBll(dlcRegisterForm)));
        }
    }
}
