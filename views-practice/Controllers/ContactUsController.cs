using Microsoft.AspNetCore.Mvc;

namespace views_practice.Controllers
{
	public class ContactUsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
