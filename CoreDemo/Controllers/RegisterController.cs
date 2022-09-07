using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class RegisterController : Controller
    {
        IWriterService _writerService;

        public RegisterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.Status = true;
            writer.About = "Master";
            writer.Image = "image.jpg";
            _writerService.Add(writer);
            return RedirectToAction("Index","Blogs");
        }
    }
}
