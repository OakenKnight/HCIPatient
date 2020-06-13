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
    /// Interaction logic for PatientExamDetailsConfirmPage.xaml
    /// </summary>
    public partial class PatientExamDetailsConfirmPriorityDatePage : Page
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
        public string userChosenTime;
        public DateTime dateTime;
        public PatientExamDetailsConfirmPriorityDatePage()
        {
            InitializeComponent();
        }
        public PatientExamDetailsConfirmPriorityDatePage(DateTime dateTime, string chosenDoctor1, string userChosenTime)
        {
            InitializeComponent();
            this.DataContext = this;

            this.doctor = chosenDoctor1;
            this.userChosenTime = userChosenTime;
            this.dateTime = dateTime;

            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            doctorCB.SelectedItem = chosenDoctor1;
            datePicker.SelectedDate = dateTime;
            Console.WriteLine(userChosenTime);
            timeCB.SelectedItem = userChosenTime;

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
            NavigationService.Navigate(new PatientDatePriorityTimePage(this.dateTime, this.doctor, this.userChosenTime));
        
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            MessageBoxResult succesMessage = MessageBox.Show("Molim Vas potvrdite zakazivanje pregleda!", "Potvrdite zakazivanje!", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        i= 1;
                       break;
                    }
                case MessageBoxResult.No: {

                        i = 0;
                        break;
                }
            }

            if (i == 1) {

                ScheduledExam scheduledExam = new ScheduledExam(dateTime, "1214124", doctor, userChosenTime, "222");
                MainWindow.exams.Add(scheduledExam);
                MessageBoxResult successMsg = MessageBox.Show("Uspesno ste zakazali pregled!", "Uspesno zakazivanje!", MessageBoxButton.OK);
                
                switch (successMsg)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                            break;
                        }
                }
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
