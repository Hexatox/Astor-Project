using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
