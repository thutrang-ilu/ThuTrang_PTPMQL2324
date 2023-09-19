using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Create()
        {
          return View();
        }
        [HttpPost]
        public IActionResult Create(string FName)
        {
            ViewBag.thongtin = "Xin chào " +FName;
            return View();
        }
    }
}