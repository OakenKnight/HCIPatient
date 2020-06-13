using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProject.PatientPages
{
    public class QuestionAnswer
    {
        public string Question
        {
            get;
            set;
        }
        public string Answer
        {
            get;
            set;
        }

        public QuestionAnswer(string q,string a) {
            Question = q;
            Answer = a;
        }

    }
}
