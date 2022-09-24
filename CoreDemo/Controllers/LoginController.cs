using Business.Abstract;
using Entities.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcUI.Models;
using System.Security.Claims;

namespace MvcUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel appUser)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return RedirectToAction("Index", "Login");

        }
        
    }
}


//[HttpPost]
//[AllowAnonymous]
//public async Task<IActionResult> Index(Writer writer)
//{
//    var writerToFind = _writerService.GetAll()
//        .FirstOrDefault(x => x.Mail == writer.Mail && x.Password == writer.Password);

//    if (writerToFind is not null)
//    {
//        var claims = new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name,writer.Mail)
//                };
//        var userIdentity = new ClaimsIdentity(claims, "login");//Neden 2.parametre olarak değer gönderiyoruz.
//        ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
//        await HttpContext.SignInAsync(principal);
//        return RedirectToAction("Index", "Dashboard");
//    }
//    return View();
//}