using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
