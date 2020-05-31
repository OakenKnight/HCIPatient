using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for PatientChooseTimePage.xaml
    /// </summary>
    /// 
        public static class DateTimeHelper
        {
        public static IEnumerable<DateTime> GetHalfHours(this DateTime dt)
        {
            TimeSpan ts = TimeSpan.FromMinutes(30);
            DateTime time = dt;
            while (true)
            {
                yield return time;
                time.Add(ts);
            }
        }
    }

    public partial class PatientChooseTimePage : Page
    {
        public DateTime tomorrowsDate = DateTime.Now.AddDays(1);
        private DateTime _date;
        private DateTime _time;
        private DateTime dateTime;
        private string _validatingTime;
        private DateTime? _futureValidatingDate;
        private string doctor;
        private string timeOfExam;
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<string> time
        {
            get;
            set;
        }
        protected virtual void OnPropertyChanged(Object name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name.ToString()));
            }
        }
        public PatientChooseTimePage(string doctor, DateTime dateTime)
        {
            InitializeComponent();
            this.DataContext = this;
            this.dateTime = dateTime;
            this.doctor = doctor;
            Date = DateTime.Now;
            Time = DateTime.Now;

            dtp.SelectedDate = dateTime.Date;
            chosenDoctor.Text = doctor;

            time = new ObservableCollection<string>();

            DateTime startShift = new DateTime(2020, 5, 11, 7, 00, 0);
            DateTime endShift = new DateTime(2020, 5, 11, 18, 00, 0);
            
            IEnumerable<DateTime> listOfHours = Enumerable.Range(0, 24).Select(h => startShift.AddHours(h));

            foreach (DateTime hour in listOfHours) {
                if (hour.Hour >= 7 && hour.Hour<=18) {
                    time.Add(hour.TimeOfDay.ToString().Substring(0,hour.TimeOfDay.ToString().Length-3));
                    time.Add(hour.AddMinutes(30).TimeOfDay.ToString().Substring(0,hour.TimeOfDay.ToString().Length - 3));
                }
            }

        }
        public PatientChooseTimePage(string doctor, DateTime dateTime, string userChosenTime)
        {
            InitializeComponent();
            this.DataContext = this;
            this.dateTime = dateTime;
            this.doctor = doctor;
            this.timeOfExam = userChosenTime;
            Console.WriteLine(timeOfExam);
            Date = DateTime.Now;
            Time = DateTime.Now;

            dtp.SelectedDate = dateTime.Date;
            chosenDoctor.Text = doctor;
            cbt.SelectedItem = userChosenTime;

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

        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged(_date);

            }
        }

        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged(_time);
            }
        }

        public string ValidatingTime
        {
            get { return _validatingTime; }
            set
            {
                _validatingTime = value;
                OnPropertyChanged(_validatingTime);
            }
        }

        public DateTime? FutureValidatingDate
        {
            get { return _futureValidatingDate; }
            set
            {
                _futureValidatingDate = value;
                OnPropertyChanged(_futureValidatingDate);
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientFeedbackPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }


        private void EmergencyExamButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO 1: mora da se uradi ovde
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleEmergemcyExamPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }

        private void NewExamButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }


        private void ScheduledExamsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientScheduledExamsPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }



        private void DoctorsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientSeeDoctorsPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }



        private void RateDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientRateDoctorPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }

        private void BlogButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientBlogPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }


        private void PatientChartButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientChartPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }


        private void TherapyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientTherapyPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da napustite zakazivanja pregleda?", "Napustate?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                        break;
                    }

            }
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PatientChooseDateExamPage(doctor,dateTime));


        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (cbt.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas izaberite datum za pregled!", "Izaberite datum!", MessageBoxButton.OK);
            }
            else
            {
                NavigationService.Navigate(new PatientExamDetailsConfirmPage(chosenDoctor.Text, dateTime, cbt.SelectedItem.ToString()));
                Console.WriteLine(cbt.SelectedItem.ToString());
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
