using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Utility.Enum;

namespace views_practice.Areas.Identity.Pages.Account
{
    [Area("Identity")]
    public class DirectorController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public DirectorController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            ApplicationUser? user = await userManager.GetUserAsync(User);
            if (signInManager.IsSignedIn(User) && User.IsInRole (nameof ( Roles.Admin)))
            {
                return RedirectToAction("Index" , "Home" , new {Area = "Admin"});
            }
            if (signInManager.IsSignedIn(User) && User.IsInRole(nameof(Roles.Auther)))
            {
                return RedirectToAction("Index", "Home", new { area = "Author" });
            }
            return RedirectToAction("Index", "Home", new { area = "User" });
        }
    }
}
