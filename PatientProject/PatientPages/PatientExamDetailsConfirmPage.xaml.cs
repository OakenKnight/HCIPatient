using System;
using System.Collections.Generic;
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
    public partial class PatientExamDetailsConfirmPage : Page
    {
        private string doctor;
        private string userChosenTime;
        private DateTime dateTime;
        public PatientExamDetailsConfirmPage()
        {
            InitializeComponent();
        }
        public PatientExamDetailsConfirmPage(string chosenDoctor1, DateTime dateTime, string userChosenTime)
        {
            InitializeComponent();
            this.DataContext = this;
            this.doctor = chosenDoctor1;
            this.userChosenTime = userChosenTime;
            this.dateTime = dateTime;


            chosenDoctor.Text = chosenDoctor1;
            dtp.SelectedDate = dateTime;
            dtp.Text = dateTime.Date.ToLocalTime().ToString();
            cbt.Text = userChosenTime;
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
                        NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
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
            NavigationService.Navigate(new PatientChooseTimePage(doctor, dateTime, userChosenTime));


        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            // NavigationService.Navigate(new PatientExamDetailsConfirmPage(chosenDoctor.Text, dateTime, chosenTime));
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
