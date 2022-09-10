using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    //[Authorize]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
