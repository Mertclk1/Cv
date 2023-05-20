using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cv.UI.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult UserList() 
        {
            var values = JsonConvert.SerializeObject(writerManager.TGetList());

            return Json (values);

        }
        [HttpPost]
        public IActionResult AddUser(WriterUser p) 
        {
            writerManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json (values);
        }
    }
}
