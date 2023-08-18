using ACTRL.Infrastructure;
using ACTRL.Models.Forms;
using BLL.Interfaces;
using BLL.Models;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Sugar_Back_V2.Controllers
{

    [Route("/[controller]/")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly TokenManager _tokenManager;        
        //injection du token

        public UserController(IUserService userService)
        {
            _userService = userService;
            _tokenManager = new TokenManager();
        }


        [HttpPost(nameof(Create))]
        public IActionResult Create(UserRegisterForm UserForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            UserBll userBll = new UserBll()
            {
                Email = UserForm.Email,
                Password = UserForm.Password,
                FirstName = UserForm.FirsName,
                LastName = UserForm.FirsName,
            };
            return Ok(_userService.Create(userBll));
        }

        [HttpPost("Login")]
        public IActionResult Read(LoginForm LoginForm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            UserBll userBll = new UserBll()
            {
                Email = LoginForm.Email,
                Password = LoginForm.Password,
                FirstName = "",
                LastName = "",
            };
            return Ok(_userService.Login(userBll));
        }

        [HttpGet("Read/{IdUser}")]
        public IActionResult Read(int IdUser)
        {
            return Ok(_userService.Read(IdUser));
        }

        /*
        [HttpPut("Update")]
        public IActionResult Update(UserWithToken User)
        {
            return Ok(_userService.Update(User));
        }
        */

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