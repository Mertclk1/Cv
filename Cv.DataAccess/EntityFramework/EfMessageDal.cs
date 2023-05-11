using Cv.DataAccess.Abstract;
using Cv.DataAccess.Repository;
using Cv.Entity.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.DataAccess.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>,IMessageDal
    {
    }
}
