using ACTRL.Mappers;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Sugar_Back_V2.Controllers
{

    [Route("/[controller]/")]
    [ApiController]

    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("CreateUserAddress")]
        public IActionResult CreateUserAddress(int idUser)
        {
            return Ok(_addressService.CreateUserAddress(idUser));
        }

        [HttpPost("CreateCustomerAddress")]
        public IActionResult CreateCustomerAddress(int idCustomer)
        {
            return Ok(_addressService.CreateCustomerAddress(idCustomer));
        }

        [HttpGet("Read/{IdAdr}")]
        public IActionResult Read(int IdAdr)
        {
            return Ok(_addressService.Read(IdAdr));
        }
        [HttpPut("Update")]
        public IActionResult Update(AddressForm adrForm)
        {
            return Ok(_addressService.Update(AdrControllerMapper.AddressFormToAddressBll(adrForm)));
        }

        [HttpPost("Delete/{IdAdr}")]
        public IActionResult Delete(int IdAdr)
        {
            return Ok(_addressService.Delete(IdAdr));
        }
    }
}
