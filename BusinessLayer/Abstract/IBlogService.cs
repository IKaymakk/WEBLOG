using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogDelete(Blog blog);
		void BlogUpdate(Blog blog);
		List<Blog> BlogList();
		List<Blog> BlogList(int id);
		Blog GetByID(int id);
		List<Blog> BlogListWCategory();
		List<Blog> BlogListAuthorID(int id);
	}
}
