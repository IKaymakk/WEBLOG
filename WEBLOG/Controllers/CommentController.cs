using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult P_AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult P_AddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 2;
            cm.CommentAdd(p);
            Response.Redirect("/Blog/AllBlogs/");
            return PartialView();
        }
        public PartialViewResult P_BlogComments(int id)
        {
            var values = cm.CommentList(id);
            return PartialView(values);
        }
    }
}
