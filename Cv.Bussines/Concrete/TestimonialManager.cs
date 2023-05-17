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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            testimonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.Delete(t);
        }

        public Testimonial TGetByID(int id)
        {
           return testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return testimonialDal.GetList();
        }

        public List<Testimonial> TGetListbyFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.Update(t);
        }
    }
}
