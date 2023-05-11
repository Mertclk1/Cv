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
	public class TodoListManager : IToDoListService
	{
		IToDoListDal _toDoListDal;

		public TodoListManager(IToDoListDal toDoListDal)
		{
			_toDoListDal = toDoListDal;
		}

		public void TAdd(ToDoList t)
		{
			_toDoListDal.Insert(t);		
		}

		public void TDelete(ToDoList t)
		{
			_toDoListDal.Delete(t);
		}

		public ToDoList TGetByID(int id)
		{
			return _toDoListDal.GetById(id);
		}

		public List<ToDoList> TGetList()
		{
			return _toDoListDal.GetList();
		}

		public List<ToDoList> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(ToDoList t)
		{
			_toDoListDal.Update(t);
		}
	}
}
