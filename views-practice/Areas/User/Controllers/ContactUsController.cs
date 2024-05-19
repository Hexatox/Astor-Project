using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.User.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
