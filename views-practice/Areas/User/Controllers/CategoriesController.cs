using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.User.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
