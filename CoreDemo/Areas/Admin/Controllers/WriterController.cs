using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterListAll()
        {
            var jsonBlogs = JsonConvert.SerializeObject(_writerService.GetAll());
            return Json(jsonBlogs);
        }
        
        public IActionResult GetWriterById(int writerId)
        {
            var jsonBlogs = JsonConvert.SerializeObject(_writerService.GetById(writerId));
            return Json(jsonBlogs);
        }

    }
}
