using ACTRL.Models.Forms;
using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;


namespace Sugar_Back_V2.Controllers
{

    [Route("/[controller]/")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Create")]
        public IActionResult Create(User User)
        {
            return Ok(_userService.Create(User));
        }

        [HttpPost("Login")]
        public IActionResult Read(LoginForm form)
        {
            return Ok(_userService.Login(form.Email,form.Password));
        }

        [HttpGet("Read/{IdUser}")]
        public IActionResult Read(int IdUser)
        {
            return Ok(_userService.Read(IdUser));
        }

        [HttpPut("Update")]
        public IActionResult Update(User User)
        {
            return Ok(_userService.Update(User));
        }

        [HttpPatch("Enable/{IdUser}")]
        public IActionResult Enable(int IdUser)
        {
            return Ok(_userService.Enable(IdUser));
        }

        [HttpPatch("Disable/{IdUser}")]
        public IActionResult Disable(int IdUser)
        {
            return Ok(_userService.Disable(IdUser));
        }

        [HttpDelete("Delete/{IdUser}")]
        public IActionResult Delete(int IdUser) {
            return Ok(_userService.Delete(IdUser));
        }
    }
}
