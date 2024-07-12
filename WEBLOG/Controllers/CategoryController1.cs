using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
