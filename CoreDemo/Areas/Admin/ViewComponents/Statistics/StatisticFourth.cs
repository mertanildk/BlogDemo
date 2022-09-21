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
            ViewBag.AdminName = _adminService.GetById(1).Name;
            return View();
        }
    }
}
