using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Blog
{
    public class BlogLast3Posts:ViewComponent
    {
        IBlogService _blogService;

        public BlogLast3Posts(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            return View(_blogService.GetAll().Take(3).ToList());
        }
    }
}
