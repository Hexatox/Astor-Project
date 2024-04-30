using System.Diagnostics;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Utility.Enum;
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
