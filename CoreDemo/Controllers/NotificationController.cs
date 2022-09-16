using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class NotificationController : Controller
    {
        INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
