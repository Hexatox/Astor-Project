using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;
using Utility.Enum;
using views_practice.Models;

namespace views_practice.Controllers
{
	public class ArticlesController : Controller
	{
        
        public ArticlesController()
        {

        }
        public IActionResult Index()
		{
            


            return View();
		}

		[HttpGet]
		public string LoadMoreArticlesCards(int count) {



            Article article = new Article();
            article.Id = 023;
            article.Title = "Article Title from DB";
            article.Description = "This is a description of article :) ";


			

            return article.ToString() ; 



			}
	}
}
