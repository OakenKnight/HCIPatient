using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatientProject.PatientPages
{
    public class Diagnosis
    {
        

        public string Header { get; set; }
        public string ItemId { get; set; }
        public string Content { get; set; }
        public string TimePeriod { get; set; }


        public Diagnosis(string header, string itemId, string content,string timeperiod)
        {
            Header = header;
            ItemId = itemId;
            Content = content;
            TimePeriod = timeperiod;
        }
    }
}
