using Cv.Business.Concrete;
using Cv.DataAccess.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class AdminMessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager (new EfWriterMessageDal());

		[HttpGet]
		public IActionResult AdminMessageSend()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdminMessageSend(WriterMessage p)
		{
			p.Sender = "Admin@gmail.com";
			p.SenderName = "Admin";
			p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			Context c = new Context();
			var userNameSurname = c.Users.Where(x=>x.Email == p.Recever).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
			p.ReceverName = userNameSurname;

			writerMessageManager.TAdd(p);

			return RedirectToAction("SenderMessageList");
		}


		public IActionResult ReceiverMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListReceiverMessage(p);
			return View(values);
		}
		public IActionResult SenderMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListSenderMessage(p);
			return View(values);
		}
		//Gönderilen mesaj Bölümü
		public IActionResult DeleteSenderAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			writerMessageManager.TDelete(values);
			return RedirectToAction("SenderMessageList");
		}

		public IActionResult DetailsSenderAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			return View(values);
		}

		// Alınan Mesaj Bölümü
		public IActionResult DeleteReceiverAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			writerMessageManager.TDelete(values);
			return RedirectToAction("ReceiverMessageList");
		}

		public IActionResult DetailsReceiverAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			return View(values);
		}
	}
}
