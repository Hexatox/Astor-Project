using Microsoft.AspNetCore.Mvc;

namespace views_practice.Areas.User.Controllers
{
    public class ContactUsController : Controller
    {

		[Area("User")]
		public IActionResult Index()
        {
            return View();
        }
    }
}
