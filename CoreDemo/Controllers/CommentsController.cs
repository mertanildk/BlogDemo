using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
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
        [HttpGet]
        public PartialViewResult PartialAddComment(int blogID)
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.Status = true;
            _commentService.Add(comment);
            return PartialView();
        }
        public PartialViewResult PartialCommentListByBlog(int id)
        {
            return PartialView(_commentService.GetAllByBlogId(id));
        }
    }

}
