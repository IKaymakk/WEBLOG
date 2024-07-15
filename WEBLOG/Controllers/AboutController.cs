using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
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
