using Microsoft.AspNetCore.Mvc;

namespace RaceDay.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
