using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers;

[AllowAnonymous]
public class NewsLettersController : Controller
{
    INewsLetterService _newsLetterService;

    public NewsLettersController(INewsLetterService newsLetter)
    {
        _newsLetterService = newsLetter;
    }

    [HttpGet]
    public PartialViewResult SubscribeMail()
    {
        return PartialView(_newsLetterService.GetAll());
    }

    [HttpPost]
    public IActionResult SubscribeMail(NewsLetter newsLetter)
    {
        newsLetter.MailStatus = true;
        if (!_newsLetterService.GetAll().Contains(newsLetter))
        {
            _newsLetterService.Add(newsLetter);
        }
        return PartialView();
    }
}