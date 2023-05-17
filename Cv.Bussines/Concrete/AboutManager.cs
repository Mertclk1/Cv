using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
           _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }       

		public List<About> TGetListbyFilter(string p)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
