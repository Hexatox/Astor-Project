using BLL.Services.IServices;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using views_practice.Models;

namespace views_practice.Areas.User.Controllers
{
    [Area ("User")]
    public class HomeController : Controller
    {
        private readonly IPostService postService;
        public HomeController(IPostService postService)
        {
            this.postService = postService;
        }
        public IActionResult Index()
        {
            IEnumerable<Post> posts = postService.GetPage(0);
            HomePageMV homePageMV  = new HomePageMV
            {
                PageNumber = 0,
                Posts = posts
            };
            return View(homePageMV);
        }
    }
}
