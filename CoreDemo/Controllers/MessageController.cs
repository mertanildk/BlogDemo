using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class MessageController : Controller
    {
        IMessageWithWriterService _messageWithWriterService;
        IWriterService _writerService;

        public MessageController(IMessageWithWriterService messageWithWriterService, IWriterService writerService)
        {
            _messageWithWriterService = messageWithWriterService;
            _writerService = writerService;
        }

        public IActionResult Inbox()
        {
            var writerId = _writerService.GetByWriterMail(User.Identity.Name).WriterId;
            return View(_messageWithWriterService.GetListWithMessageByWriter(writerId));
        }
        public IActionResult MessageDetails(int id)
        {
            return View(_messageWithWriterService.GetById(id));
        }
    }
}
