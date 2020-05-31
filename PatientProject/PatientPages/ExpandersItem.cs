using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatientProject.PatientPages
{
    public class ExpandersItem
    {
        

        public string Header { get; set; }
        public string ItemId { get; set; }
        public string Content { get; set; }

        public ExpandersItem(string header, string itemId, string content)
        {
            Header = header;
            ItemId = itemId;
            Content = content;
        }
    }
}
