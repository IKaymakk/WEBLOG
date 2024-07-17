using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
	{
		AboutManager manager = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
			var values = manager.GetList();
			return View(values);
		}
	}
}
