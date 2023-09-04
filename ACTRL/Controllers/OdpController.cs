using ACTRL.Models.Forms;
using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace Sugar_Back_V2.Controllers
{

    [Route("/[controller]/")]
    [ApiController]

    public class OdpController : ControllerBase
    {
        private readonly IOdpService _odpService;
        public OdpController(IOdpService odpService)
        {
            _odpService = odpService;
        }

        [HttpPost("Create")]
        public IActionResult Create(OdpRegisterForm odpRegisterForm)
        {
            return Ok(_odpService.Create(Odp));
        }

        [HttpGet("Read/{IdOdp}")]
        public IActionResult Read(int IdOdp)
        {
            return Ok(_odpService.Read(IdOdp));
        }

        [HttpPut("Update")]
        public IActionResult Update(OdpDal Odp)
        {
            return Ok(_odpService.Update(Odp));
        }

        [HttpDelete("Delete/{IdItem}")]
        public IActionResult Delete(int IdOdp) {
            return Ok(_odpService.Delete(IdOdp));
        }
    }
}
