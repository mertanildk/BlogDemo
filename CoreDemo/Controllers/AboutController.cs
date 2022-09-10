using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class AboutController : Controller
    {
        IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            return View(_aboutService.GetAll());
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
