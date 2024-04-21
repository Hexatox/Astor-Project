using Microsoft.AspNetCore.Mvc;

namespace views_practice.Controllers
{
    public class SignIn : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
