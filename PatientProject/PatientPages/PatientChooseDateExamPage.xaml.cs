using System;
using System.Collections.Generic;
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
    /// Interaction logic for PatientChooseDateExamPage.xaml
    /// </summary>
    /// 


    public partial class PatientChooseDateExamPage : Page, INotifyPropertyChanged
    {
        public DateTime tomorrowsDate = DateTime.Now.AddDays(1);
        private DateTime _date;
        private DateTime _time;
        private string _validatingTime;
        private DateTime? _futureValidatingDate;
        private string doctor;
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(Object name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name.ToString()));
            }
        }

        public PatientChooseDateExamPage(string doctor)
        {
            InitializeComponent();
            this.DataContext = this;
            this.doctor = doctor;
            Date = DateTime.Now;
            Time = DateTime.Now;
            
            chosenDoctor.Text = doctor;

            //ovako ces prikazivati samo dozvoljene datume
            var dates = new List<DateTime>
            {
                DateTime.Now.AddDays(1),
                new DateTime(2020, 5, 15),
                new DateTime(2020, 5, 16),
                new DateTime(2020, 5, 28),
                new DateTime(2020, 5, 29),
                new DateTime(2020, 6, 9),
                new DateTime(2020, 6, 12),
                new DateTime(2020, 6, 13),
                new DateTime(2020, 6, 17),
                new DateTime(2020, 6, 18)
            };

            var firstDate = dates.First();
            var lastDate = dates.Last();
            var dateCounter = firstDate;

            foreach (var d in dates.Skip(1))
            {
                if (d.AddDays(-1).Date != dateCounter.Date)
                {
                    dtp.BlackoutDates.Add(
                        new CalendarDateRange(dateCounter.AddDays(1), d.AddDays(-1)));
                }

                dateCounter = d;
            }


            dtp.DisplayDateStart = firstDate;
            dtp.DisplayDateEnd = lastDate;
        }
        public PatientChooseDateExamPage(string doctor,DateTime dateTime)
        {
            InitializeComponent();
            this.DataContext = this;
            this.doctor = doctor;
            Date = DateTime.Now;
            Time = DateTime.Now;

            dtp.Text = dateTime.Date.ToShortDateString();
            chosenDoctor.Text = doctor;
            dtp.SelectedDate = dateTime.Date;
            //ovako ces prikazivati samo dozvoljene datume
            var dates = new List<DateTime>
            {
                DateTime.Now.AddDays(1),
                new DateTime(2020, 5, 15),
                new DateTime(2020, 5, 16),
                new DateTime(2020, 5, 28),
                new DateTime(2020, 5, 29),
                new DateTime(2020, 6, 9),
                new DateTime(2020, 6, 12),
                new DateTime(2020, 6, 13),
                new DateTime(2020, 6, 17),
                new DateTime(2020, 6, 18)
            };

            var firstDate = dates.First();
            var lastDate = dates.Last();
            var dateCounter = firstDate;

            foreach (var d in dates.Skip(1))
            {
                if (d.AddDays(-1).Date != dateCounter.Date)
                {
                    dtp.BlackoutDates.Add(
                        new CalendarDateRange(dateCounter.AddDays(1), d.AddDays(-1)));
                }

                dateCounter = d;
            }
            dtp.DisplayDateStart = firstDate;
            dtp.DisplayDateEnd = lastDate;
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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

            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
        }

        private void NewExamButton_Click(object sender, RoutedEventArgs e)
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


        private void ScheduledExamsButton_Click(object sender, RoutedEventArgs e)
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



        private void DoctorsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
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
            NavigationService.Navigate(new PatientChooseDoctorPage(doctor));


        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (dtp.SelectedDate == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas izaberite datum za pregled!", "Izaberite datum!", MessageBoxButton.OK);
            }
            else
            {
                NavigationService.Navigate(new PatientChooseTimePage(doctor, dtp.SelectedDate.Value));
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
