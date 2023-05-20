using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cv.UI.Controllers
{
    public class WriterUserController : Controller
    {
        WriterManager WriterManager = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult UserList() 
        {
            var values = JsonConvert.SerializeObject(WriterManager.TGetList());

            return Json (values);

        }
        
    }
}
