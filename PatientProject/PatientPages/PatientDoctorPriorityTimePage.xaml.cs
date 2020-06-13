using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PatientDatePriorityPage.xaml
    /// </summary>
    public partial class PatientDoctorPriorityTimePage : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public ObservableCollection<string> doctors
        {
            get;
            set;
        }
        public ObservableCollection<string> time
        {
            get;
            set;
        }
        public string doctor;
        public DateTime datum;
        public string termin;
        public PatientDoctorPriorityTimePage(string doctor)
        {
            InitializeComponent();
            this.DataContext = this;
            this.doctor = doctor;
            doctorCB.SelectedValue = doctor;

            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            doctors = new ObservableCollection<string>();
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");

            time = new ObservableCollection<string>();

            DateTime startShift = new DateTime(2020, 5, 11, 7, 00, 0);
            DateTime endShift = new DateTime(2020, 5, 11, 18, 00, 0);

            IEnumerable<DateTime> listOfHours = Enumerable.Range(0, 24).Select(h => startShift.AddHours(h));

            foreach (DateTime hour in listOfHours)
            {
                if (hour.Hour >= 7 && hour.Hour <= 18)
                {
                    time.Add(hour.TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                    time.Add(hour.AddMinutes(30).TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                }
            }

        }
        public PatientDoctorPriorityTimePage(string doctor, DateTime date)
        {
            InitializeComponent();
            this.DataContext = this;
            this.datum = date;
            this.doctor = doctor;
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            datePicker.DisplayDateStart = DateTime.Today.AddDays(1);
            datePicker.SelectedDate = date;
            doctorCB.SelectedValue = doctor;

            doctors = new ObservableCollection<string>();
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");

            time = new ObservableCollection<string>();

            DateTime startShift = new DateTime(2020, 5, 11, 7, 00, 0);
            DateTime endShift = new DateTime(2020, 5, 11, 18, 00, 0);

            IEnumerable<DateTime> listOfHours = Enumerable.Range(0, 24).Select(h => startShift.AddHours(h));

            foreach (DateTime hour in listOfHours)
            {
                if (hour.Hour >= 7 && hour.Hour <= 18)
                {
                    time.Add(hour.TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                    time.Add(hour.AddMinutes(30).TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                }
            }
        }
        public PatientDoctorPriorityTimePage(string doctor, DateTime date,string term)
        {
            InitializeComponent();
            this.DataContext = this;
            this.datum = date;
            this.doctor = doctor;
            this.termin = term;

            datePicker.DisplayDateStart = DateTime.Today.AddDays(1);
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            datePicker.SelectedDate = date;
            doctorCB.SelectedItem = doctor;
            timeCB.SelectedItem = term;

            doctors = new ObservableCollection<string>();
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");

            time = new ObservableCollection<string>();

            DateTime startShift = new DateTime(2020, 5, 11, 7, 00, 0);
            DateTime endShift = new DateTime(2020, 5, 11, 18, 00, 0);

            IEnumerable<DateTime> listOfHours = Enumerable.Range(0, 24).Select(h => startShift.AddHours(h));

            foreach (DateTime hour in listOfHours)
            {
                if (hour.Hour >= 7 && hour.Hour <= 18)
                {
                    time.Add(hour.TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                    time.Add(hour.AddMinutes(30).TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                }
            }
        }

        private void displayMenu_Click(object sender, RoutedEventArgs e)
        {

        }
        private void displayOptions_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bell_Click(object sender, RoutedEventArgs e)
        {

        }


        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Izlazak?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        try
                        {
                            System.Diagnostics.Process.GetProcessById(MainWindow.idKeyboard).Kill();

                        }
                        catch
                        {

                        }
                        Environment.Exit(0);
                        break;
                    }

            }
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {


            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da se odjavite?", "Odjavljivanje?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientSignInPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }

        private void FeedbackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientFeedbackPage.xaml", UriKind.Relative));

        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));

        }


        private void EmergencyExamButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO 1: mora da se uradi ovde
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleEmergemcyExamPage.xaml", UriKind.Relative));

        }

        private void NewExamButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
        }


        private void ScheduledExamsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduledExamsPage.xaml", UriKind.Relative));

        }



        private void DoctorsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientSeeDoctorsPage.xaml", UriKind.Relative));

        }



        private void RateDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientRateDoctorPage.xaml", UriKind.Relative));

        }

        private void BlogButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientBlogPage.xaml", UriKind.Relative));
        }


        private void PatientChartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientChartPage.xaml", UriKind.Relative));

        }


        private void TherapyButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientTherapyPage.xaml", UriKind.Relative));

        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

        }

        
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (timeCB.SelectedItem != null)
            {
                this.termin = timeCB.SelectedValue.ToString();

            }

            if (this.datum != null && this.doctor != null && this.termin != null)
            {
                NavigationService.Navigate(new PatientDoctorPriorityDatePage(this.doctor, this.datum, this.termin));
            }
            else
            {
                NavigationService.Navigate(new PatientDoctorPriorityDatePage(this.doctor, this.datum));

            }

        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (timeCB.SelectedItem != null)
            {
                this.termin = timeCB.SelectedValue.ToString();

                NavigationService.Navigate(new PatientExamDetailsConfirmPriorityDatePage(this.datum, this.doctor, this.termin));

            }
            else
            {
                errorNoInput.Text = "Odaberite termin!";
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }
    }
}
