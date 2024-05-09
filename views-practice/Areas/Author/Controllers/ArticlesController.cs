using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.Author.Controllers
{
    [Area("Author")]
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewArticle ()
        {
            return View();
        }
    }



  
}
