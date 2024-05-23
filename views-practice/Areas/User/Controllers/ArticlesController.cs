
using BLL.Services.IServices;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using Utility.Enum;
using views_practice.Models;

namespace views_practice.Areas.User.Controllers
{
	public class ArticlesController : Controller
	{
		private readonly IPostService postService;
		public ArticlesController(IPostService postService)
		{
			this.postService = postService;
		}





		[Area("User")]
		public async Task<IActionResult> Index()
		{
			IEnumerable<Post> posts = await postService.GetPageAsync(0);
			HomePageMV homePageMV = new HomePageMV
			{
				PageNumber = 0,
				Posts = posts
			};
			return View(homePageMV);




		}

		[HttpGet]
		[Area("User")]
		public async Task<IActionResult> LoadMoreArticlesCards(int page = 1, int pageSize = 5)
		{


			if (ModelState.IsValid)
			{
				var records = await postService.GetPageAsync(page);


				return PartialView("_PostsPartialView", records);
			}


			return BadRequest();



		}
	}
}
