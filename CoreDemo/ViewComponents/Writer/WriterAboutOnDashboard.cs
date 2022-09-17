using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        IWriterService _writerService;

        public WriterAboutOnDashboard(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_writerService.GetByWriterMail(User.Identity.Name));
        }
    }
}
