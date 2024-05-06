using Microsoft.AspNetCore.Mvc;
using Utility.Enum;

namespace views_practice.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
