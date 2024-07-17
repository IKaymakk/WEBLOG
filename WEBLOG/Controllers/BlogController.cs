using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult AllBlogs()
		{
			var values = bm.BlogListWCategory();
			return View(values);
		}
		public IActionResult BlogDetail(int id)
		{
			ViewBag.BlogID = id;
			var values = bm.BlogList(id);
			return View(values);
		}
	}
}
