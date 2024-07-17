using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WEBLOG.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Author p)
        {
            Context c = new Context();
            var datavalue = c.Authors.FirstOrDefault(x => x.AuthorMail == p.AuthorMail && x.AuthorPassword == p.AuthorPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.AuthorMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Author");
            }
            else
            {
                return View();
            }
        }
    }
}


//Context c = new Context();
//var values = c.Authors.FirstOrDefault(x => x.AuthorMail == p.AuthorMail && x.AuthorPassword == p.AuthorPassword);
//if (values != null)
//{
//    HttpContext.Session.SetString("username", p.AuthorMail);
//    return RedirectToAction("Index", "Author");
//}
//else
//{
//    return View();
//}

