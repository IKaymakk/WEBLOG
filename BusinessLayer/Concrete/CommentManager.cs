using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _icommentdal;

        public CommentManager(ICommentDal icommentdal)
        {
            _icommentdal = icommentdal;
        }

        public void CommentAdd(Comment comment)
        {
            _icommentdal.Insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _icommentdal.Delete(comment);
        }

        public List<Comment> CommentList(int id)
        {
            return _icommentdal.GetList(x=>x.BlogID == id);
        }

        public void CommentUpdate(Comment comment)
        {
            _icommentdal.Update(comment);
        }
    }
}
