using Microsoft.AspNetCore.Mvc;

namespace DemoMVC;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName)
    {
        string ps = "Hello " + FullName;
        ViewBag.thongbao = ps;
        return View();
    }
}