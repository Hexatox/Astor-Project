using Microsoft.AspNetCore.Mvc;

namespace views_practice.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
