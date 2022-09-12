using Business.Abstract;
using Entity.Concrete;
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
        public IActionResult BlogListByWriter(int id)
        {
            var blogOfWriter = _blogService.GetBlogListByWriterID(3);
            blogOfWriter = _blogService.IncludeCategory();
            return View(blogOfWriter);
        }

        public IActionResult AddBlogByWriter()
        {
            return View();
        }
        public IActionResult AddBlogByWriter(Blog blog
            )
        {
            return View();
        }
    }
}
