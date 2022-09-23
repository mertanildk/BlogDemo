using Business.Abstract;
using Entity.Concrete;
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
            var jsonWriters = JsonConvert.SerializeObject(_writerService.GetAll());
            return Json(jsonWriters);
        }
        
        public IActionResult GetWriterById(int writerId)
        {
            var jsonWriter = JsonConvert.SerializeObject(_writerService.GetById(writerId));
            return Json(jsonWriter);
        }
        
        [HttpPost]
        public IActionResult AddWriter(Writer writer)
        {
            _writerService.Add(writer);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }
        
        public IActionResult DeleteWriter(int writerId)
        {
            var writerToDelete = _writerService.GetById(writerId);
            _writerService.Delete(writerToDelete);
            return Json(writerToDelete);
        }
        public IActionResult UpdateWriter(Writer writer)
        {
            _writerService.Update(writer);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }

    }
}
