using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv.Entity.Classes
{
    public class WriterMessage
    {
        [Key]
        public int WtiterMessageId { get; set; }
        public string Sender { get; set; }
        public string SenderName { get; set; }
        public string Recever { get; set; }
        public string ReceverName { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
