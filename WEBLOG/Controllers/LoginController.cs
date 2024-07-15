using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
