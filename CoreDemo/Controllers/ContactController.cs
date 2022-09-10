using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View(_contactService.GetAll());
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.Status = true;
            _contactService.Add(contact);
            return RedirectToAction("Index", "Blogs");
        }

    }
}
