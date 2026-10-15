using Microsoft.AspNetCore.Mvc;

namespace RaceDay.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
