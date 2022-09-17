using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {

        IMessageWithWriterService _messageService;

        public WriterMessageNotification(IMessageWithWriterService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_messageService.GetListWithMessageByWriter(3));
        }
    }
}
