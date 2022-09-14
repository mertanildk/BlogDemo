using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class DashboardController : Controller
    {
        ICategoryService _categoryService;
        IBlogService _blogService;

        public DashboardController(ICategoryService categoryService, IBlogService blogService)
        {
            _categoryService = categoryService;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            ViewBag.CategoryCount = _categoryService.GetAll().Count();
            ViewBag.BlogCount = _blogService.GetAll().Count();
            ViewBag.BlogCountByWriter = _blogService.GetAll().Where(x => x.WriterId == 3).Count();
            return View();
        }
    }
}
