using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
     public IActionResult Giaiptb2()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Giaiptb2(string hesoA, string hesoB, string hesoC)
    {
        double delta, x1, x2, a=0, b=0, c=0;
        string ketqua;
        if(!String.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!String.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(!String.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
        if(a==0) ketqua = "Khong phai phuong trinh bac 2";
        else{
            //tinh delta
            delta = Math.Pow(b,2) - 4*a*c;
            // Giai phuong trinh
            if(delta<0) ketqua ="Phuong trinh vo nghiem";
            else if(delta==0)
            {
                x1 = -b/(2*a);
                ketqua ="Phuong trinh co nghiem kep = "+ x1;
            }
            else 
            {
                x1= (-b + Math.Sqrt(delta))/(2*a);
                x2= (-b - Math.Sqrt(delta))/(2*a);
                ketqua = "Phuong trinh co 2 nghiem phan biet: x1= "+ x1 + ", x2= "+x2;
            }
        }
        ViewBag.gpt = ketqua;
        return View();
    }
    public IActionResult Tinhluong()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Tinhluong(string Luongcb, string heSo, string Phucap)
    {
        double cb =0, hs =0, pc =0, luong = 0;
        string trave;
        if(!String.IsNullOrEmpty(Luongcb)) cb = Convert.ToDouble(Luongcb);
        if(!String.IsNullOrEmpty(heSo)) hs = Convert.ToDouble(heSo);
        if(!String.IsNullOrEmpty(Phucap)) pc = Convert.ToDouble(Phucap);
        luong = cb*hs+pc;
        trave = "Lương của bạn hiện tại là: " + luong;
        ViewBag.tl = trave;
        return View();
    }
}
