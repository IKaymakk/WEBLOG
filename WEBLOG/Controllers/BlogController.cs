using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
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
			var values = bm.GetByID(id);
			return View(values);
		}
	}
}
