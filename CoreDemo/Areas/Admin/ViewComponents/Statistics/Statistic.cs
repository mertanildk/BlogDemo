using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic:ViewComponent
    {
        IBlogService _blogService;

        public Statistic(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = _blogService.GetAll().Count;
            return View();
        }
    }
}
