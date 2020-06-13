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
    public partial class PatientDoctorPriorityPage : Page
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
        public DateTime? date;
        public string term;
        public string izabraniLekar;
        public PatientDoctorPriorityPage()
        {
            InitializeComponent();
            this.DataContext = this;
            izabraniLekar = "dr Petar Petrović";
            chosenDoctor.Text = izabraniLekar;

            doctors = new ObservableCollection<string>();
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");

        }
        public PatientDoctorPriorityPage(string doctor)
        {
            InitializeComponent();
            this.DataContext = this;

            this.doctor = doctor;
            doctorCB.SelectedItem = doctor;
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            doctors = new ObservableCollection<string>();
            izabraniLekar = "dr Petar Petrović";
            chosenDoctor.Text = izabraniLekar;
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");
        }

        public PatientDoctorPriorityPage(string doctor, DateTime date)
        {
            InitializeComponent();
            this.DataContext = this;
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            if (!date.Equals(DateTime.MinValue))
            {
                this.date = date;

            }
            this.doctor = doctor;

            doctorCB.SelectedItem = doctor;

            doctors = new ObservableCollection<string>();
            izabraniLekar = "dr Petar Petrović";
            chosenDoctor.Text = izabraniLekar;
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");

        }
        public PatientDoctorPriorityPage(string doctor, DateTime date, string term)
        {
            InitializeComponent();
            this.DataContext = this;
            Notifications notifications = new Notifications();

            this.date = date;
            this.doctor = doctor;
            this.term = term;
            izabraniLekar = "dr Petar Petrović";
            chosenDoctor.Text = izabraniLekar;

            doctorCB.SelectedItem = doctor;
            doctors = new ObservableCollection<string>();

            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");
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

        private void EditInfoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage", UriKind.Relative));

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (doctorCB.SelectedItem != null)
            {
                this.doctor = doctorCB.SelectedValue.ToString();
            }

            if (this.doctor!=null || this.term!=null || this.date != null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da odustanete do zakazivanja pregleda?", "Odustajete?", MessageBoxButton.YesNo);
                switch (succesMessage)
                {
                    case MessageBoxResult.Yes:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientPrioritySchedulePage.xaml", UriKind.Relative));
                            break;
                        }

                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientPrioritySchedulePage.xaml", UriKind.Relative));

            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {

            if (doctorCB.SelectedItem != null) {
                string doctor = doctorCB.SelectedValue.ToString();
                this.doctor = doctor;
            
                if(this.date!=null && this.doctor!=null && this.term != null)
                {
                    NavigationService.Navigate(new PatientDoctorPriorityDatePage(this.doctor, this.date.Value, this.term));
                }
                else
                {
                    if(this.date == null && this.term == null)
                    {
                        NavigationService.Navigate(new PatientDoctorPriorityDatePage(doctorCB.SelectedValue.ToString()));

                    }
                    else if (this.date != null && !this.date.Equals(DateTime.MinValue))
                    {
                        Console.WriteLine(this.date);
                        NavigationService.Navigate(new PatientDoctorPriorityDatePage(this.doctor, this.date.Value));
                        
                    }
                    else 
                    {
                        NavigationService.Navigate(new PatientDoctorPriorityDatePage(doctorCB.SelectedValue.ToString()));

                    }

                }
            }
            else
            {
                errorNoInput.Text = "Odaberite lekara!";
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

        private void continueChosenDoctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PatientDoctorPriorityDatePage(izabraniLekar));
        }
    }
}
