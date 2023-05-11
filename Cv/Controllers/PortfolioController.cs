using Cv.Business.Concrete;
using Cv.Business.ValidationRules;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class PortfolioController : Controller
	{

		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		public IActionResult Index()
		{

			ViewBag.v1 = "Projeler Listesi";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "projeler Listesi";
			var values = portfolioManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
			ViewBag.v1 = "Projeler Ekleme";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Projeler Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
			PortfolioValidator validator = new PortfolioValidator();
			ValidationResult result = validator.Validate(portfolio);
			if (result.IsValid)
			{
				portfolioManager.TAdd(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
			
		}

		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetByID(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditPortfolio(int id)
		{
			ViewBag.v1 = "Projeler Düzenle";
			ViewBag.v2 = "Projeler";
			ViewBag.v3 = "Projeler Düzenle";
			var values = portfolioManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditPortfolio(Portfolio portfolio)
		{
			PortfolioValidator validator = new PortfolioValidator();
			ValidationResult result = validator.Validate(portfolio);
			if (result.IsValid)
			{
				portfolioManager.TUpdate(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();

		}
	}
}
