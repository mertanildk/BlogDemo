using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class MessageController : Controller
    {
        IMessageWithWriterService _messageWithWriterService;

        public MessageController(IMessageWithWriterService messageWithWriterService)
        {
            _messageWithWriterService = messageWithWriterService;
        }

        public IActionResult Inbox()
        {
            return View(_messageWithWriterService.GetListWithMessageByWriter(3));
        }
        public IActionResult MessageDetails(int id)
        {
            return View(_messageWithWriterService.GetById(id));
        }
    }
}
