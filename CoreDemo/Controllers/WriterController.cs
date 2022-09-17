using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {

        IWriterService _writerService;
        WriterValidation writerValidation = new();


        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            var writer = _writerService.GetByWriterMail(User.Identity.Name);
            ViewBag.UserMail = writer.Mail;
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        public IActionResult WriterEditProfile()
        {
            return View(_writerService.GetByWriterMail(User.Identity.Name));
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            ValidationResult result = writerValidation.Validate(writer);
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

            writer.Image = "asdsad";
            writer.Status = true;
            _writerService.Update(writer);
            return RedirectToAction("Index", "Dashboard");

        }
        public IActionResult WriterAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterAdd(Writer writer, IFormFile image)
        {
            if (image != null)
            {
                var extension = Path.GetExtension(image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                image.CopyTo(stream);
                writer.Image = newImageName;
                _writerService.Add(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}
