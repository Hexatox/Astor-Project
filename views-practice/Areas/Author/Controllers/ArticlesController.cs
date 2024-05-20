using BLL.Services.IServices;
using DAL.Entities;
using DAL.Repositories.IRepositories;
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
    public class ArticlesController : Controller
    {

        private readonly ICatigoryService catigoryService;
        private readonly IPostService postRepository; 

        public ArticlesController(ICatigoryService catigoryService)
        {
            this.catigoryService = catigoryService;
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
        [HttpPost]
        [Area("Author")]
        public async Task<IActionResult> AddPost([FromBody] JObject jsonData)
        {


			Post post = new Post
			{
				Title = (string)jsonData["title"],
				Content = (string)jsonData["content"],
				Image = (string)jsonData["image"],
				Likes = new Collection<Like>(),
				PostDate = DateTime.Now,
				Samary = (string)jsonData["samary"],
				Catigories = new Collection<Catigory>(),
				IsAviable = true,
				PostType = PostType.Article,
				TotalLikes = 0,
			};

			if (ModelState.IsValid)
            {

                
                try
                {
                  await postRepository.CreatePostAsync(post);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
                

                return Ok(new { success = true });
            }
            
               
            return BadRequest();
           
           
        }


    }



  
}
