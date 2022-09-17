using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {

        IMessageService _messageService;

        public WriterMessageNotification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_messageService.GetInboxListByWriter("mertanildeke@gmail.com"));
        }
    }
}
