using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        INotificationService _notificationService;

        public WriterNotification(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IViewComponentResult Invoke()
        {
            
            return View(_notificationService.GetAll()) ;
        }
    }
}
