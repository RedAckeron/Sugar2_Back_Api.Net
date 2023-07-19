using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace Sugar_Back_V2.Controllers
{

    [Route("/[controller]/")]
    [ApiController]

    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost("Create")]
        public IActionResult Create(Item Item)
        {
            return Ok(_itemService.Create(Item));
        }


        [HttpGet("Read/{IdItem}")]
        public IActionResult Read(int IdItem)
        {
            return Ok(_itemService.Read(IdItem));
        }

		[HttpGet("ReadAllOfCmd/{IdCmd}")]
		public IActionResult ReadAllOfCmd(int IdCmd)
		{
			return Ok(_itemService.ReadAllOfCmd(IdCmd));
		}

		[HttpPut("Update")]
        public IActionResult Update(Item Item)
        {
            return Ok(_itemService.Update(Item));
        }

        [HttpDelete("Delete/{IdItem}")]
        public IActionResult Delete(int IdItem) {
            return Ok(_itemService.Delete(IdItem));
        }
    }
}
