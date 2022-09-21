using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Areas.Admin.ViewComponents.Statistics
{
    public class StatisticFourth:ViewComponent
    {
        IAdminService _adminService;

        public StatisticFourth(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IViewComponentResult Invoke()
        {
            var admin = _adminService.GetById(1);
            ViewBag.AdminName = admin.Name;
            ViewBag.AdminImage = admin.ImageURL;
            ViewBag.AdminDescription = admin.ShortDescription;
            return View();
        }
    }
}
