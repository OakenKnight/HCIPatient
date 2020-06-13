using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.Model
{
    public class Patient
    {
        public string name { get; set; }
        public string lastname { get; set; }
        public string parentName { get; set; }
        public string number { get; set; }
        public string living_city { get; set; }
        public string birth_city { get; set; }
        public string pin { get; set; }
        public string chosenDoctor { get; set; }
        public DateTime birth { get; set; }
        public string gender { get; set; }
        public MailAddress email { get; set; }

        public Patient(string name, string lastname, string parentName, string number, string living_city, string birth_city, string pin, string chosenDoctor, DateTime birth, string gender, MailAddress email)
        {
            this.name = name;
            this.lastname = lastname;
            this.parentName = parentName;
            this.number = number;
            this.living_city = living_city;
            this.birth_city = birth_city;
            this.pin = pin;
            this.chosenDoctor = chosenDoctor;
            this.birth = birth;
            this.gender = gender;
            this.email = email;
        }
    }
}
