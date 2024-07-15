using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WEBLOG.Controllers
{
    public class NewsLatterController : Controller
    {
        NewsLatterManager manager = new NewsLatterManager(new EfNewsLatterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLatter p)
        {
            p.MailStatus = true;
            manager.AddNewsLatter(p);
            Response.Redirect("/Blog/AllBlogs/");
            return PartialView();
        }
    }
}
