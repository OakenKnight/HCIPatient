using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for PatientEditInfoPage.xaml
    /// </summary>

    public partial class PatientEditInfoPage : Page
    {
        public ObservableCollection<string> doctors
        {
            get;
            set;
        }
        public ObservableCollection<string> genders
        {
            get;
            set;
        }

        public ObservableCollection<int> years
        {
            get;
            set;
        }
        public ObservableCollection<String> months
        {
            get;
            set;
        }
        public ObservableCollection<int> days
        {
            get;
            set;
        }


        public PatientEditInfoPage(string chosenDoctor, string personName, string personLastname, string personParent, string personBirthDate, string personTelephone, string personGender, string personLivingCity, string personBirthCity, string personPin, MailAddress personEmail)
        {
            InitializeComponent();
            this.DataContext = this;

            doctors = new ObservableCollection<string>();
            genders = new ObservableCollection<string>();
            days = new ObservableCollection<int>();
            years = new ObservableCollection<int>();
            months = new ObservableCollection<String>();

            name.Text = personName;
            parent.Text = personParent;
            lastname.Text = personLastname;
            pin.Text = personPin;
            tel.Text = personTelephone;
            
            livingCity.Text = personLivingCity;
            birthCity.Text = personBirthCity;
            
            email.Text = personEmail.ToString();

            genders.Add("Ženski");
            genders.Add("Muški");
            genders.Add("Drugi...");

            doctors.Add("dr Zoran Radovanovic");
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");



            for (int i = 1; i < 32; i++)
            {
                days.Add(i);
            }

            months.Add(" ");
            months.Add("Januar");
            months.Add("Februar");
            months.Add("Mart");
            months.Add("April");
            months.Add("Maj");
            months.Add("Jun");
            months.Add("Jul");
            months.Add("Avgust");
            months.Add("Septembar");
            months.Add("Oktobar");
            months.Add("Novembar");
            months.Add("Decembar");



            int k = 2020;
            for (int i = 0; i < 120; i++)
            {

                k -= 1;
                years.Add(k);
            }

            string[] parts = personBirthDate.Split('/');


            day.SelectedItem = Convert.ToInt32(parts[0]);
            month.SelectedItem = parts[1];
            yrs.SelectedItem = Convert.ToInt32(parts[2]);
            gender.SelectedItem = personGender;
            doctor.SelectedItem = chosenDoctor;
            

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

        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));

        }


        private void EmergencyExamButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewExamButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void ScheduledExamsButton_Click(object sender, RoutedEventArgs e)
        {

        }



        private void DoctorsButton_Click(object sender, RoutedEventArgs e)
        {

        }



        private void RateDoctorButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BlogButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void PatientChartButton_Click(object sender, RoutedEventArgs e)
        {

        }


        private void TherapyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            string date = day.SelectedItem.ToString() + "/" + month.SelectedItem.ToString() + "/" + yrs.SelectedItem.ToString();
            NavigationService.Navigate(new PatientProfilePage(doctor.SelectedItem.ToString(), name.Text, lastname.Text, parent.Text, date, tel.Text, gender.SelectedItem.ToString(), livingCity.Text, birthCity.Text, pin.Text, new MailAddress(email.Text)));

        }
    }
}
