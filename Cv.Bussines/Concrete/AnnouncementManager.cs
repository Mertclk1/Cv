using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Business.Concrete
{
	public class AnnouncementManager : IAnnouncementService
	{
		IAnnouncementDal _announcementDal;

		public AnnouncementManager(IAnnouncementDal announcementDal)
		{
			_announcementDal = announcementDal;
		}

		public void TAdd(Announcement t)
		{
			_announcementDal.Insert(t);
		}

		public void TDelete(Announcement t)
		{
		       _announcementDal.Delete(t);
		}

		public Announcement TGetByID(int id)
		{
			return _announcementDal.GetById(id);
		}

		public List<Announcement> TGetList()
		{
			return _announcementDal.GetList();
		}

		public List<Announcement> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public List<Announcement> TGetListbyFilter(string p)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Announcement t)
		{
			_announcementDal.Update(t);
		}
	}
}
