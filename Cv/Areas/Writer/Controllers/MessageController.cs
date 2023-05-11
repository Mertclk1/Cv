﻿using Cv.Business.Concrete;
using Cv.DataAccess.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class MessageController : Controller
	{
		WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

		private readonly UserManager<WriterUser> _userManager;

		public MessageController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IActionResult> ReciverMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = _writerMessageManager.GetListReceiverMessage(p);
			return View(messageList);
		}

		public async Task<IActionResult> SenderMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = _writerMessageManager.GetListSenderMessage(p);
			return View(messageList);
		}

		public IActionResult MessageDetails(int id)
		{
			var values = _writerMessageManager.TGetByID(id);
			return View(values);
		}

		public IActionResult ReciverMessageDetails(int id)
		{
			var values = _writerMessageManager.TGetByID(id);
			return View(values);
		}
		[HttpGet]
		public IActionResult SendMessage()
		{
			return View();
		}
		[HttpPost]
		public async Task <IActionResult> SendMessage(WriterMessage p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			string mail = values.Email;
			string name = values.Name + " " + values.Surname;	
			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			p.Sender= mail;
			p.SenderName= name;
			Context c = new Context();
			var userNameSurname = c.Users.Where(x => x.Email == p.Recever).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			p.ReceverName = userNameSurname;

			_writerMessageManager.TAdd(p);
			return RedirectToAction("SenderMessage");
		}
	}
}
