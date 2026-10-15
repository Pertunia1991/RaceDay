using Microsoft.AspNetCore.Mvc;

namespace RaceDay.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
