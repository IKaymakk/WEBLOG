using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager am = new AuthorManager(new EfAuthorRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Author author)
        {
            AuthorValidator av = new AuthorValidator();
            ValidationResult results = av.Validate(author);
            if (results.IsValid)
            {
                author.AuthorStatus = true;
                author.AuthorAbout = " ";
                am.AuthorAdd(author);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName,x.ErrorMessage);
                }
            }
            return View();
        }
    }
}
