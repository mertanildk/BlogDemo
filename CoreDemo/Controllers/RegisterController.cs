using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Entity.Concrete;
using FluentValidation.Results;
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
            WriterValidation writerValidation = new();
            ValidationResult result = writerValidation.Validate(writer);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
            writer.Status = true;
            writer.About = "Master";
            writer.Image = "image.jpg";
            _writerService.Add(writer);
            return RedirectToAction("Index","Blogs");
        }
    }
}
