using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace views_practice.Controllers
{
    public class DirectorController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        public IActionResult Index()
        {
            return View();
        }
    }
}
