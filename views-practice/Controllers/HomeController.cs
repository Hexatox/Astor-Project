using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using views_practice.Models;
using views_practice.Utility;

namespace views_practice.Controllers;

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

    public IActionResult Pricing()
    {
        return View();
    }


    public IActionResult Show()
    {
        

        return View();
    }

}
