using PatientProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PatientProfilePage.xaml
    /// </summary>
    enum Gender
    {
        Ženski,
        Muški,
        Drugi
    }

    public partial class PatientProfilePage : Page
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

        private string personName = "Luka";
        private string personLastname = "Lukovic";
        private string personParent = "Pavle";
        private DateTime personBirthDate = new DateTime(2001,6,12);
        private string personTelephone = "0611717306";
        private string personGender = Gender.Muški.ToString();
        private string personLivingCity = "Bulevar Revolucije 2, Novi Sad, Srbija";
        private string personBirthCity = "Novi Sad";
        private string personPin = "1234567890123";
        private MailAddress personEmail = new MailAddress("luka.lukovic@gmail.com");

        private Notifications notifi = new Notifications();
        public Patient patient;

        public PatientProfilePage()
        {
            InitializeComponent();
            this.DataContext = this;
            doctors = new ObservableCollection<string>();
            
            notifications = notifi.notifications;
            patient = MainWindow.patient;


            doctors.Add("dr Zoran Radovanovic");
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");
            doctors.Add("dr Legenda Nestorovic");

            chosenDoctor.Text = patient.chosenDoctor;
            name.Text = patient.name;
            parent.Text = patient.parentName;
            lastname.Text = patient.lastname;
            pin.Text = patient.pin;
            tel.Text = patient.number;
            gender.Text = patient.gender;
            dtp.SelectedDate = patient.birth.Date;
            livingCity.Text = patient.living_city;
            birthCity.Text = patient.birth_city;
            email.Text = patient.email.ToString();

        }
        public PatientProfilePage(string doctor, string personName, string personLastname, string personParent, DateTime personBirthDate, string personTelephone, string personGender, string personLivingCity, string personBirthCity, string personPin, MailAddress personEmail) {

            InitializeComponent();
            this.DataContext = this;
            patient = MainWindow.patient;

            patient.name = personName;
            patient.parentName = personParent;
            patient.lastname = personLastname;
            patient.pin = personPin;
            patient.birth = personBirthDate;
            patient.living_city = personLivingCity;
            patient.birth_city = personBirthCity;
            patient.chosenDoctor = doctor;
            patient.email = personEmail;
            patient.gender = personGender;
            patient.number = personTelephone;

            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            chosenDoctor.Text = patient.chosenDoctor;
            name.Text = patient.name;
            parent.Text = patient.parentName;
            lastname.Text = patient.lastname;
            pin.Text = patient.pin;
            tel.Text = patient.number;
            gender.Text = patient.gender;
            dtp.SelectedDate = patient.birth.Date;
            livingCity.Text = patient.living_city;
            birthCity.Text = patient.birth_city;
            email.Text = patient.email.ToString();
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
            MessageBoxResult succesMessage = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da izadjete?", "Izlazak?", MessageBoxButton.YesNo);
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
            MessageBoxResult succesMessage = System.Windows.MessageBox.Show("Da li ste sigurni da zelite da se odjavite?", "Odjavljivanje?", MessageBoxButton.YesNo);
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
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleEmergencyExamPage.xaml", UriKind.Relative));

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
                NavigationService.Navigate(new PatientEditInfoPage(patient));

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

        }



    }
}

