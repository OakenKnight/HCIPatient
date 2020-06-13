using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.PatientPages
{
    public class Notification
    {
        public string Header { get; set; }
        public string ItemId { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public Notification(string header, string itemId, string content,string date)
        {
            Header = header;
            ItemId = itemId;
            Content = content;
            Date = date;
        }
    }
}
