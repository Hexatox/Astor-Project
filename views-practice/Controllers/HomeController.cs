using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using views_practice.Models;
using views_practice.Utility;

namespace views_practice.Controllers;

public class HomeController : Controller
{

    



    private readonly ILogger<HomeController> _logger;
    private readonly UploadFileBlob uploadFileBlob;
    public HomeController(ILogger<HomeController> logger , UploadFileBlob uploadFileBlob)
    {
        _logger = logger;
       this.uploadFileBlob = uploadFileBlob;
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

    [HttpPost]
    public string? Upload(IFormFile file)
    {
        return uploadFileBlob.Upload (file).GetAwaiter().GetResult();
    }

}
