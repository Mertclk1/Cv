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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessage;

        public WriterMessageManager(IWriterMessageDal writerMessage)
        {
            _writerMessage = writerMessage;
        }

		public List<WriterMessage> GetListReceiverMessage(string p)
		{
			return _writerMessage.GetByFilter(x => x.Recever == p);
		}

		public List<WriterMessage> GetListSenderMessage(string p)
		{
			return _writerMessage.GetByFilter(x => x.Sender == p);
		}

		public void TAdd(WriterMessage t)
        {
            _writerMessage.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessage.Delete(t);
        }

        public WriterMessage TGetByID(int id)
        {
            return _writerMessage.GetById(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writerMessage.GetList();
        }        

		public List<WriterMessage> TGetListbyFilter()
		{
			throw new NotImplementedException();
		}

		public List<WriterMessage> TGetListbyFilter(string p)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(WriterMessage t)
        {
            _writerMessage.Update(t);
        }
    }
}
