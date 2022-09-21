using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
