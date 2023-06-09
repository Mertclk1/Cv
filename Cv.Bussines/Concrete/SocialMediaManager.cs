﻿using Cv.Business.Abstract;
using Cv.DataAccess.Abstract;
using Cv.Entity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocialMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
           return _socialMediaDal.GetList();
        }

        public List<SocialMedia> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

		public List<SocialMedia> TGetListbyFilter(string p)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(SocialMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
