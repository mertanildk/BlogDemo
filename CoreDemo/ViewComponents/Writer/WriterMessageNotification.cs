﻿using Microsoft.AspNetCore.Mvc;

namespace MvcUI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
