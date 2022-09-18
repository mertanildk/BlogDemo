using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdmimNavbarPartial()
        {
            return PartialView();
        }
    }
}
