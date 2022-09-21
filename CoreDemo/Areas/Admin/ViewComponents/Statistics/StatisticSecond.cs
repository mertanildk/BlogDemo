using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Admin.ViewComponents.Statistics
{
    public class StatisticSecond:ViewComponent
    {
        IBlogService _blogService;

        public StatisticSecond(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var Last5Blogs = _blogService.GetAll().OrderByDescending(x => x.CreateDate).Take(3).ToList();
            ViewBag.LastBlogName = _blogService.GetAll().OrderByDescending(x => x.CreateDate).FirstOrDefault().Title;
            return View(Last5Blogs);
        }
    }
}
