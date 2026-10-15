using Microsoft.AspNetCore.Mvc;

namespace RaceDay.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
