using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
    public class BlogsController : Controller
    {
        IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            
            return View(_blogService.IncludeCategory()) ;
        }

        public IActionResult BlogDetails(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }
       
    }
}
