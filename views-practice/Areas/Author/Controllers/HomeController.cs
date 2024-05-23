using BLL.Services.IServices;
using DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Utility.Enum;

namespace views_practice.Areas.Author.Controllers
{
    [Area ("Author")]
	[Authorize(Roles = nameof(Roles.Auther))]
	public class HomeController : Controller
    {
        private readonly IPostService postService;
        private readonly UserManager<ApplicationUser> userManager;
        public HomeController(IPostService postService , UserManager<ApplicationUser> userManager)
        {
            this.postService = postService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            
            var userId = userManager.GetUserId(User) ;
            if (userId == null)
            {
				return NotFound(); // Any handling
			}
            var posts = postService.GetPostsByAuthorId(userId);
            return View(posts);
        }
    }
}
