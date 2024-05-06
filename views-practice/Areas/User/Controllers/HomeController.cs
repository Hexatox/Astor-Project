using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.User.Controllers
{
    [Area ("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
