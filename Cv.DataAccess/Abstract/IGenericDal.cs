using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cv.DataAccess.Abstract
{
    public interface IGenericDal <T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetList();
        T GetById(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
