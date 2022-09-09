using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class ErrorPageController : Controller
    {
       
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
