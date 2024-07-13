using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _iblogdal;

        public BlogManager(IBlogDal iblogdal)
        {
            _iblogdal = iblogdal;
        }

        public void BlogAdd(Blog blog)
        {
            _iblogdal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _iblogdal.Delete(blog);
        }

        public List<Blog> BlogList()
        {
            return _iblogdal.GetList();
        }

        public List<Blog> BlogListWCategory()
        {
            return _iblogdal.BlogListWithCategory();
        }

        public void BlogUpdate(Blog blog)
        {
            _iblogdal.Update(blog);
        }

        public Blog GetByID(int id)
        {
            return _iblogdal.GetByID(x => x.BlogID == id);
        }

		
	}
}
