using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        IWriterService _writerService;

        public WritersController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        [HttpGet("getall")]
        public IActionResult AllWriter()
        {
            return Ok(_writerService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetWriterById(int writerId)
        {
            return Ok(_writerService.GetById(writerId));
        }
        [HttpPost("add")]
        public IActionResult AddWriter(Writer writer)
        {
            _writerService.Add(writer);
            return Ok(writer);
        }
        [HttpDelete("delete")]
        public IActionResult DeleteWriter(int id)
        {
            var writerToDelete = _writerService.GetById(id);
            _writerService.Delete(writerToDelete);
            return Ok(writerToDelete);
        }
        [HttpPut("update")]
        public IActionResult UpdateWriter(Writer writer)
        {
            _writerService.Update(writer);
            return Ok(writer);
        }
        
        
    }
}
