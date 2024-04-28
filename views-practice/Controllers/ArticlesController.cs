using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using views_practice.Models;

namespace views_practice.Controllers
{
	public class ArticlesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public string LoadMoreArticlesCards(int count) {



            Article article = new Article();
            article.Id = 023;
            article.Title = "How to get fucked with JS";
            article.Description = "Adnane will explain how to get fucked by js in visual studion 2022 ";




            return article.ToString() ; 



			}
	}
}
