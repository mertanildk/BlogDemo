using Business.Abstract;
using Entity.Concrete;
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
        public PartialViewResult PartialAddComment(int blogID)
        {
            ViewBag.BlogID = blogID;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.Status = true;
            comment.BlogId = 3;

            _commentService.Add(comment);
            return PartialView();
        }
        public PartialViewResult PartialCommentListByBlog(int id)
        {
            return PartialView(_commentService.GetById(id));
        }
    }

}
