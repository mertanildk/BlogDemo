using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class BlogsController : Controller
    {
        IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View(_blogService.GetAll()) ;
        }
    }
}
