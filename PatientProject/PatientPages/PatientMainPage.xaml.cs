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
    /// Interaction logic for PatientMainPage.xaml
    /// </summary>
    public partial class PatientMainPage : Page
    {
        public PatientMainPage()
        {
            InitializeComponent();
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

        private void ScheduledExamsText_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {
            MenuPopup.IsOpen = false;
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

        }
    }
}
