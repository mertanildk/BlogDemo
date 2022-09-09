using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class NewLettersController : Controller
    {
        INewsLetterService _newsLetterService;

        public NewLettersController(INewsLetterService newsLetterService)
        {
            _newsLetterService = newsLetterService;
        }

        public PartialViewResult SubsribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubsribeMail(NewsLetter newsLatter)
        {
            newsLatter.MailStatus = true;
            _newsLetterService.Add(newsLatter);
            return PartialView();
        }

    }
}
