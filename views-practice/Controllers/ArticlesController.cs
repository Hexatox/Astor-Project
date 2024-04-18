using Microsoft.AspNetCore.Mvc;

namespace views_practice.Controllers
{
	public class ArticlesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
