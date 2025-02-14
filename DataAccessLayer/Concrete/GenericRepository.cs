﻿using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(Expression<Func<T, bool>> filter)
        {
			return _object.SingleOrDefault(filter);
		}

		public List<T> GetList(Expression<Func<T, bool>> filter)
		{
            return c.Set<T>().Where(filter).ToList();
		}

		public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            c.Update(t);
            c.SaveChanges();
        }
    }
}
