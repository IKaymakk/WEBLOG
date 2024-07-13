using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult P_AddComment()
		{
			return PartialView();
		}
		public PartialViewResult P_BlogComments(int id)
		{
			var values = cm.CommentList(id);
			return PartialView(values);
		}
	}
}
