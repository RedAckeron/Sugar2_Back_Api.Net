using ACTRL.Mappers;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using BLL.Services;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;


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
            Console.WriteLine("ODP ADD "+ odpRegisterForm.AddByUser+" "+odpRegisterForm.IdCustomer);
            return Ok(_odpService.Create(OdpControllerMapper.OdpRegisterFormToOdpBll(odpRegisterForm)));
        }

        [HttpGet("Read/{IdOdp}")]
        public IActionResult Read(int IdOdp)
        {
            return Ok(_odpService.Read(IdOdp));
        }

        [HttpPut("Update")]
        public IActionResult Update(OdpRegisterForm odpRegisterForm)
        {
            return Ok(_odpService.Update(OdpControllerMapper.OdpRegisterFormToOdpBll(odpRegisterForm)));
        }

        [HttpDelete("Delete/{IdItem}")]
        public IActionResult Delete(int IdOdp) {
            return Ok(_odpService.Delete(IdOdp));
        }

        [HttpGet("ReadAllOdpLight/{IdCust}")]
        public IActionResult ReadAllOdpLight(int IdCust)
        {
            return Ok(_odpService.ReadAllOdpLight(IdCust));
        }
    }
}
