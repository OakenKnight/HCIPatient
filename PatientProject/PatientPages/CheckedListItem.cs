using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.PatientPages
{
    public class CheckedListItem
    {
        private String name;
        private String id;

        public CheckedListItem(string id, string name)
        {
            this.name = name;
            this.id = id;

        }

        public String Name 
        {
            get { return name; }
            set { name =value; } 
        }
        public String Id 
        {
            get { return id; }
            set { id = value; }
        }

    }
}
