using BLL.Services.IServices;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace views_practice.Areas.Author.Controllers
{
    [Area("Author")]
    public class ArticlesController : Controller
    {

        private readonly ICatigoryService catigoryService; 

        public ArticlesController(ICatigoryService catigoryService)
        {
            this.catigoryService = catigoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

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
        public IActionResult AddPost(Post post, List<int> categoryIds)
        {
            if (ModelState.IsValid)
            
                return Ok(new { message = post.PostType });
            return BadRequest();
           
           
        }


    }



  
}
