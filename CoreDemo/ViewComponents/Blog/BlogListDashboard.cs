using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {

        IBlogService _blogService;

        public BlogListDashboard(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_blogService.IncludeCategory());
        }
    }
}
