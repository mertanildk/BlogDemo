using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        IBlogService _blogService;

        public WriterLastBlog(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var writers = _blogService.GetBlogListByWriterID(2);
            return View(writers);
        }
    }
}
