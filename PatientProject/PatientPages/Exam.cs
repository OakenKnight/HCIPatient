using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatientProject.PatientPages
{
    public class Exam
    {
        

        public DateTime Date { get; set; }
        public string ItemId { get; set; }
        public string Doctor { get; set; }

        public Exam(DateTime date, string itemId, string doctor)
        {
            Date = date;
            ItemId = itemId;
            Doctor = doctor;
        }
    }
}
