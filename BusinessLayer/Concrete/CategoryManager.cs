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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _icategorydal;

        public CategoryManager(ICategoryDal icategorydal)
        {
            _icategorydal = icategorydal;
        }

        public void CategoryAdd(Category category)
        {
            _icategorydal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
        _icategorydal.Delete(category);
        }

        public List<Category> CategoryList()
        {
            return _icategorydal.GetList();
        }

        public void CategoryUpdate(Category category)
        {
            _icategorydal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _icategorydal.GetByID(id);
        }
    }
}
