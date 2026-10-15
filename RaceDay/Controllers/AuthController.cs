using Microsoft.AspNetCore.Mvc;

namespace RaceDay.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
