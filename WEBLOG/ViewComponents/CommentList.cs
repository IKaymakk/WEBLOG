using Microsoft.AspNetCore.Mvc;
using WEBLOG.Models;

namespace WEBLOG.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID =1,
                    UserName="KAYMAK"
                },
                new UserComment
                {
                    ID = 2,
                    UserName="MURATOÇDAĞ"
                }
            };
            return View(commentvalues);
        }
    }
}
