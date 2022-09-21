using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace MvcUI.Areas.Admin.ViewComponents.Statistics
{
    public class StatisticFirst:ViewComponent
    {
        IBlogService _blogService;
        IMessageService _messageService;
        ICommentService _commentService;

        public StatisticFirst(IBlogService blogService, IMessageService messageService, ICommentService commentService)
        {
            _blogService = blogService;
            _messageService = messageService;
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.BlogCount = _blogService.GetAll().Count;
            ViewBag.MessageCount = _messageService.GetAll().Count;
            ViewBag.CommentCount = _commentService.GetAll().Count;

            string apiKey = "55bae1403626b66bc18e2e5cd5af55ab";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=mersin&mode=xml&units=metric&appid=" + apiKey;
            XDocument document = XDocument.Load(connection);

            ViewBag.City = document.Descendants("city").Attributes("name").FirstOrDefault().Value;
            var cityDegree = document.Descendants("temperature").Attributes("value").FirstOrDefault().Value;
            ViewBag.Degree = cityDegree.Substring(0, cityDegree.IndexOf('.'));

            return View();
        }
    }
}
