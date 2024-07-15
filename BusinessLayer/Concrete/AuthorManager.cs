using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _iauthordal;

        public AuthorManager(IAuthorDal iauthordal)
        {
            _iauthordal = iauthordal;
        }

        public void AuthorAdd(Author author)
        {
            _iauthordal.Insert(author);
        }
    }
}
