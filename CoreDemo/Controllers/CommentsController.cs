using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class CommentsController : Controller
    {
        ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View(_commentService.GetAll());
        }
        public PartialViewResult PartialAddCommand()
        {
            return PartialView();
        }
        public PartialViewResult PartialCommentListByBlog(int id)
        {
            return PartialView(_commentService.GetById(id));
        }
    }
}
