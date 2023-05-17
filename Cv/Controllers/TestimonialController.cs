using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class TestimonialController : Controller
	{
		TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
		public IActionResult Index()
		{
			var values = testimonialManager.TGetList();
			return View(values);
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var values = testimonialManager.TGetByID(id);
			testimonialManager.TDelete(values);
			return View("Index");	
		}
        [HttpGet]
        public IActionResult AddTestimonial()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {

            var values = testimonialManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
