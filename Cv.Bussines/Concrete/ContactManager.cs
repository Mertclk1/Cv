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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
           return _contactDal.GetList();
        }

        public List<Contact> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
