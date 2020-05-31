using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace PatientProject.PatientPages
{
    public class ScheduledExam
    {
        public DateTime Date { get; set; }
        public string Id { get; set; }
        public string Doctor { get; set; }
        public string Time { get; set; }
        public string Room { get; set; }


        public ScheduledExam(DateTime date, string itemId, string doctor, string time, string room)
        {
            Date = date;
            Id = itemId;
            Doctor = doctor;
            Time = time;
            Room = room;
        }
    }
}
