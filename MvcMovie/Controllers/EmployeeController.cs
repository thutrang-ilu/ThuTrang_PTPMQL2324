using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return View();
        }
    }
}