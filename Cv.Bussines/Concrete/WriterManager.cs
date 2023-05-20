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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TAdd(WriterUser t)
        {
           _writerDal.Insert(t);
        }

        public void TDelete(WriterUser t)
        {
            _writerDal.Delete(t);
        }

        public WriterUser TGetByID(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<WriterUser> TGetList()
        {
           return _writerDal.GetList();
        }

        public List<WriterUser> TGetListbyFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            _writerDal.Update(t);
        }
    }
}
