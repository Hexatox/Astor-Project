using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.Author.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
