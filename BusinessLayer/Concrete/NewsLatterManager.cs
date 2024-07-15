using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLatterManager : INewsLatterService
    {
        INewsLatterDal _inewslatter;

        public NewsLatterManager(INewsLatterDal inewslatter)
        {
            _inewslatter = inewslatter;
        }

        public void AddNewsLatter(NewsLatter newslatter)
        {
            _inewslatter.Insert(newslatter);
        }
    }
}
