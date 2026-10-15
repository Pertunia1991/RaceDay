using Microsoft.AspNetCore.Mvc;

namespace RaceDay.Controllers
{
    public class EnrolmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
