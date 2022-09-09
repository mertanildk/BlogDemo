using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
