﻿using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cv.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
	{
        
        SkillManager skillManager = new SkillManager(new EfSkillDal());
		public IActionResult Index()
		{

			
			var values = skillManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSkill()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddSkill(Skill skill)
		{
			skillManager.TAdd(skill);

			return RedirectToAction("Index");
		}

		public IActionResult DeleteSkill(int id)
		{
			var values = skillManager.TGetByID(id);
			skillManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			
			var values = skillManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			skillManager.TUpdate(skill);
			return RedirectToAction("Index");
		}
	}
}
