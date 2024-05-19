using BLL.Services.IServices;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using views_practice.Models;

namespace views_practice.Areas.User.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IPostService postService;
        public HomeController(IPostService postService)
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
    }
}
