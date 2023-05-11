using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class ToDoList : ViewComponent
	{
		TodoListManager TodoListManager = new TodoListManager(new EfToDoListDal());
		public IViewComponentResult Invoke()
		{
			var value = TodoListManager.TGetList();
			return View(value);
		}
	}
}
