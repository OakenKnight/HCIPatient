using PatientProject.Model;
using PatientProject.PatientPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace PatientProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Dictionary<String, String> korisnici
        {
            get;
            set;
        }
        public static ObservableCollection<ScheduledExam> exams
        {
            get;
            set;
        }
        public static Dictionary<DateTime, string> scheduledExamsNames
        {
            get;
            set;
        }
        public static ObservableCollection<ScheduledExam> examsForToday
        {
            get;
            set;
        }
        public static ObservableCollection<ScheduledExam> examsForTomorrow
        {
            get;
            set;
        }
        public static ObservableCollection<ScheduledExam> examsForTmrw2
        {
            get;
            set;
        }
        public static ObservableCollection<ScheduledExam> examsForTmrw3
        {
            get;
            set;
        }
        public static Patient patient;
        public static int idKeyboard;
        public DateTime dns = DateTime.Today;
        public DateTime tmrw = DateTime.Today;
        public DateTime dayaftertmrw2 = DateTime.Today;
        public DateTime dayaftertmrw = DateTime.Today;
        public MainWindow()
        {
            InitializeComponent();
            //radi
            var path64 = Path.Combine(Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "winsxs"), "amd64_microsoft-windows-osk_*")[0], "osk.exe");
            var path32 = @"C:\windows\system32\osk.exe";
            var path = (Environment.Is64BitOperatingSystem) ? path64 : path32;
            if (File.Exists(path))
            {
                idKeyboard = Process.Start(path).Id;
                Process.Start(path);
            }
            exams = new ObservableCollection<ScheduledExam>();
            scheduledExamsNames = new Dictionary<DateTime, string>();

            korisnici = new Dictionary<string, string>();
            korisnici["pera"] = "pera";

            patient = new Patient("Pera", "Peric", "Perica", "02131241", "Novi Sad", "Novi Sad", "1234567890123", "dr Legenda Nestorovic", new DateTime(1992, 12, 12).Date, "Muški", new System.Net.Mail.MailAddress("pera.peric@gmail.com"));


            dns = DateTime.Today;

            tmrw = dns.AddDays(1);
            dayaftertmrw = dns.AddDays(2);
            dayaftertmrw2 = dns.AddDays(3);

            ScheduledExam exam1 = new ScheduledExam(dns, "id1", "dr Jovan Prodanov", "12:30", "217");
            ScheduledExam exam2 = new ScheduledExam(dns, "id2", "dr Legenda Nestorovic", "13:30", "237");

            ScheduledExam exam3 = new ScheduledExam(tmrw, "id3", "dr Jelena Klasnjar", "11:30", "211");
            ScheduledExam exam4 = new ScheduledExam(tmrw, "id4", "dr Goran Stevanovic", "13:30", "420");

            ScheduledExam exam5 = new ScheduledExam(dayaftertmrw, "id5", "dr Legenda Nestorovic", "17:30", "200");
            ScheduledExam exam6 = new ScheduledExam(dayaftertmrw, "id6", "dr Legenda Nestorovic", "9:30", "12");

            ScheduledExam exam7 = new ScheduledExam(dayaftertmrw2, "id7", "dr Legenda Nestorovic", "16:30", "666");

            ScheduledExam exam8 = new ScheduledExam(new DateTime(2020,5,12), "id8", "dr Jelena Klasnjar", "16:30", "666");
            ScheduledExam exam9 = new ScheduledExam(new DateTime(2020, 5, 16), "id9", "dr Legenda Nestorovic", "16:30", "666");
            ScheduledExam exam10 = new ScheduledExam(new DateTime(2020, 4, 16), "id10", "dr Goran Stevanovic", "16:30", "666");
            ScheduledExam exam11 = new ScheduledExam(new DateTime(2020, 4, 6), "id11", "dr Legenda Nestorovic", "16:30", "666");
            ScheduledExam exam12 = new ScheduledExam(new DateTime(2020, 3, 16), "id12", "dr Legenda Nestorovic", "16:30", "666");
           



            examsForToday = new ObservableCollection<ScheduledExam>();
            examsForTomorrow = new ObservableCollection<ScheduledExam>();
            examsForTmrw2 = new ObservableCollection<ScheduledExam>();
            examsForTmrw3 = new ObservableCollection<ScheduledExam>();

            examsForToday.Add(exam1);
            examsForToday.Add(exam2);

            examsForTomorrow.Add(exam3);
            examsForTomorrow.Add(exam4);

            examsForTmrw3.Add(exam5);
            examsForTmrw3.Add(exam6);

            examsForTmrw2.Add(exam7);

            exams.Add(exam1);
            exams.Add(exam2);
            exams.Add(exam3);
            exams.Add(exam4);
            exams.Add(exam5);
            exams.Add(exam6);
            exams.Add(exam7); 
            exams.Add(exam8);
            exams.Add(exam9);
            exams.Add(exam10);
            exams.Add(exam11);
            exams.Add(exam12);

            scheduledExamsNames[dns.Date] = nameof(examsForToday);
            scheduledExamsNames[tmrw.Date] = nameof(examsForTomorrow);
            scheduledExamsNames[dayaftertmrw2.Date] = nameof(examsForTmrw3);
            scheduledExamsNames[dayaftertmrw.Date] = nameof(examsForTmrw2);

        }

        public static bool proveriPostojanje(string user) {
            if (korisnici.Values.Contains(user))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool ispravanaKorisnik(string user, string pass) {

            try
            {

                if (proveriPostojanje(user))
                {
                    if (korisnici[user].Equals(pass))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch { 
            
            }
            return false;


        }
    }
}
