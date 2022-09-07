using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddCommand()
        {
            return PartialView();
        }
        public PartialViewResult PartialCommandListByBlog()
        {
            return PartialView();
        }
    }
}
