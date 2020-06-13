using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.PatientPages
{
    public class DrugsThreapy
    { 
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string drug { get; set; }
        public string description { get; set; }

        
        public DrugsThreapy(string startDate, string endDate, string drug, string description)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.drug = drug;
            this.description = description;
        }

        
    }
}
