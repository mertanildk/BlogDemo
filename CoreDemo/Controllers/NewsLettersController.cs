using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers;

public class NewsLettersController : Controller
{
    INewsLetterService _newsLetter;

    public NewsLettersController(INewsLetterService newsLetter)
    {
        _newsLetter = newsLetter;
    }

    [HttpGet]
    public PartialViewResult SubscribeMail()
    {
        return PartialView(_newsLetter.GetAll()) ;
    }

    [HttpPost]
    public PartialViewResult SubscribeMail(NewsLetter newsLetter)
    {
        newsLetter.MailStatus = true;
        _newsLetter.Add(newsLetter);
        return PartialView();
    }
}