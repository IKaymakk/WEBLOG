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
	public class AboutManager : IAboutService
	{
		IAboutDal _iaboutdal;

		public AboutManager(IAboutDal iaboutdal)
		{
			_iaboutdal = iaboutdal;
		}

		public List<About> GetList()
		{
			return _iaboutdal.GetList();
		}
	}
}
