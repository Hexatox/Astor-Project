using BLL.Services.IServices;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Humanizer.DateTimeHumanizeStrategy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using NuGet.Protocol;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens.Jwt;
using Utility.Enum;

namespace views_practice.Areas.Author.Controllers
{
    [Area("Author")]
	[Authorize(Roles = nameof(Roles.Auther))]
	public class ArticlesController : Controller
    {

        private readonly ICatigoryService catigoryService;
        private readonly IPostService postService;
		private readonly UserManager<ApplicationUser> userManager;
		private readonly IPostCatigoryService postCatigoryService;
        public ArticlesController(ICatigoryService catigoryService , IPostService postService , UserManager<ApplicationUser> userManager , IPostCatigoryService postCatigoryService)
        {
            this.catigoryService = catigoryService;
			this.postService = postService;
			this.userManager = userManager;
			this.postCatigoryService = postCatigoryService;
        }


        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Author")]
        public async Task<IActionResult> NewArticle()
        {
            IEnumerable<Catigory> ctgrList = await catigoryService.GetAllAsync();




            return View(ctgrList);
        }
		//      [HttpPost]
		//      public IActionResult AddPost(Post post , List<int> cgtrIds)
		//      {
		//	return Ok(new { message = post.Title });



		//}
		//     [HttpPost]
		//     [Area("Author")]
		//     public async Task<IActionResult> AddPost(Post post, List<int> categoryIds , IFormFile image)
		//     {


		//Post post = new Post
		//{
		//	Title = (string)jsonData["title"],
		//	Content = (string)jsonData["content"],
		//	Image = (string)jsonData["image"],
		//	Likes = new Collection<Like>(),
		//	PostDate = DateTime.Now,
		//	Samary = (string)jsonData["samary"],
		//	Catigories = new Collection<Catigory>(),
		//	IsAviable = true,
		//	PostType = PostType.Article,
		//	TotalLikes = 0,
		//};

		//if (ModelState.IsValid)
		//         {


		//             try
		//             {
		//               await postRepository.CreatePostAsync(post);
		//             }
		//             catch (Exception e)
		//             {

		//                 Console.WriteLine(e);
		//             }



		//             return Ok(new { success = true });
		//         }


		//         return BadRequest();


		//     }
		[HttpPost]
		public async Task<IActionResult> AddPost(Post post , List<int> categoryIds , IFormFile image)
		{
			post.PostDate = DateTime.Now;
			post.PostType = PostType.Article;
			post.Image = @"https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.vecteezy.com%2Fsystem%2Fresources%2Fthumbnails%2F002%2F115%2F431%2Fsmall_2x%2Fcoming-soon-business-sign-free-vector.jpg&tbnid=D7ssStfQjxl6OM&vet=12ahUKEwi0gerB4p2GAxWFdqQEHUIjAFwQMygFegQIARB8..i&imgrefurl=https%3A%2F%2Fwww.vecteezy.com%2Ffree-vector%2Fcoming-soon-sign&docid=QBgAzwDCrQLsFM&w=411&h=400&q=soon&ved=2ahUKEwi0gerB4p2GAxWFdqQEHUIjAFwQMygFegQIARB8";
			post.UserId = userManager!.GetUserId(User);
			await postService.AddPostAsync(post);
			await postCatigoryService.AssignPostToCatigoriesAsync(post.PostId, categoryIds);
			return RedirectToAction("Index");
		}


	}



}
