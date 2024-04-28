using Microsoft.AspNetCore.Mvc;

namespace views_practice.Controllers
{
    public class SignUp : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
