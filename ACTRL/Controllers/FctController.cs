using Microsoft.AspNetCore.Mvc;

namespace ACTRL.Controllers
{
    public class FctController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
