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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetList()
        {
           return _featureDal.GetList();
        }

        public List<Feature> TGetListbyFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature t)
        {
           _featureDal.Update(t);
        }
    }
}
