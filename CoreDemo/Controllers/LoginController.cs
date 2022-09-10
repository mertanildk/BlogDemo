using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        IWriterService _writerService;

        public LoginController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            var writerToFind= _writerService.GetAll()
                .FirstOrDefault(x => x.Mail == writer.Mail && x.Password==writer.Password);

            if (writerToFind is not null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.Mail)
                };
                var userIdentity = new ClaimsIdentity(claims, "login");//Neden 2.parametre olarak değer gönderiyoruz.
                ClaimsPrincipal principal= new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            return View();
        }


    }
}
