using ACTRL.Models;
using Bll.Models;
using BLL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace Sugar_Back_V2.Controllers
{

    [Route("/[controller]/")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("Create")]
        public IActionResult Create(CustomerForm custForm)
            {
            return Ok(_customerService.Create(CustomerControllerMapper.CustomerFormToCustomerBll(custForm)));
            }

        [HttpGet("Read/{IdCust}")]
		public IActionResult Read(int IdCust)
            {
            if(IdCust!=0) return Ok(_customerService.Read(IdCust));
            else return BadRequest("L id du client ne peut pas etre 0");
        }

        [HttpPut("Update")]
        public IActionResult Update(CustomerForm custForm)
            {
                return Ok(_customerService.Update(CustomerControllerMapper.CustomerFormToCustomerBll(custForm)));
        }

        [HttpPost("Delete/{IdCust}")]
        public IActionResult Delete(int IdCust) 
            {
                return Ok(_customerService.Delete(IdCust));
            }

        [HttpGet("FindCustomer/{cust}")]
        public IActionResult FindCustomer(string cust)
        {
            return Ok(_customerService.FindCustomer(cust));
        }

        [HttpGet("ReadCustomerSummary/{IdCust}")]
        public IActionResult ReadCustomerSummary(int IdCust)
        {
            return Ok(_customerService.ReadCustomerSummary(IdCust));
        }

        [HttpGet("ReadLastCustomer")]
        public IActionResult ReadLastCustomer()
        {
            return Ok(_customerService.ReadLastCustomer());
        }

    }
}
