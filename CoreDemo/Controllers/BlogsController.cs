using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
