using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;


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
        
        [HttpPost("CreateCustomerAddress")]
        public IActionResult CreateCustomerAddress(CustomerAddressDal Adr)
        {
            return Ok(_addressService.CreateCustomerAddress(Adr));
        }

        [HttpGet("ReadCustomerAddress/{IdAdr}")]
        public IActionResult ReadCustomerAddress(int IdAdr)
        {
            return Ok(_addressService.ReadCustomerAddress(IdAdr));
        }

        [HttpGet("ReadCustomerAllAddress/{IdCust}")]
        public IActionResult ReadCustomerAllAddress(int IdCust)
        {
            return Ok(_addressService.ReadCustomerAllAddress(IdCust));
        }

        [HttpPut("UpdateCustomerAddress")]
        public IActionResult UpdateCustomerAddress(CustomerAddressDal Adr)
        {
            return Ok(_addressService.UpdateCustomerAddress(Adr));
        }

        [HttpPost("DeleteCustomerAddress/{IdAdr}")]
        public IActionResult DeleteCustomerAddress(int IdAdr)
        {
            return Ok(_addressService.DeleteCustomerAddress(IdAdr));
        }

        [HttpPost("CreateUserAddress")]
        public IActionResult CreateUserAddress(UserAddressDal Adr)
        {
            return Ok(_addressService.CreateUserAddress(Adr));
        }

        [HttpGet("ReadUserAddress/{IdAdr}")]
        public IActionResult ReadUserAddress(int IdCust)
        {
            return Ok(_addressService.ReadUserAddress(IdCust));
        }

        [HttpPut("UpdateUserAddress")]
        public IActionResult UpdateUserAddress(UserAddressDal Adr)
        {
            return Ok(_addressService.UpdateUserAddress(Adr));
        }

        [HttpPost("DeleteUserAddress/{IdAdr}")]
        public IActionResult DeleteUserAddress(int IdAdr)
        {
            return Ok(_addressService.DeleteUserAddress(IdAdr));
        }
        
    }
}
