using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatientProject.PatientPages
{
    public class BlogArticle
    {
        

        public string Header { get; set; }
        public string ItemId { get; set; }
        public string Content { get; set; }
        public ObservableCollection<ExpandersItem> Comments { get; set; }
        public BlogArticle(string header, string itemId, string content, ObservableCollection<ExpandersItem> comments)
        {
            Header = header;
            ItemId = itemId;
            Content = content;
            Comments = comments;
        }
    }
}
