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
    /// Interaction logic for PatientFeedbackPage.xaml
    /// </summary>
    public partial class PatientFeedbackPage : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public PatientFeedbackPage()
        {
            InitializeComponent();
            this.DataContext = this;
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
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
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientFeedbackPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientFeedbackPage.xaml", UriKind.Relative));

            }
        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));

            }



        }


        private void EmergencyExamButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO 1: mora da se uradi ovde
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleEmergemcyExamPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleEmergemcyExamPage.xaml", UriKind.Relative));

            }
        }

        private void NewExamButton_Click(object sender, RoutedEventArgs e)
        {
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));

            }

        }


        private void ScheduledExamsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduledExamsPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientScheduledExamsPage.xaml", UriKind.Relative));

            }


        }



        private void DoctorsButton_Click(object sender, RoutedEventArgs e)
        {
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientSeeDoctorsPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientSeeDoctorsPage.xaml", UriKind.Relative));

            }
        }



        private void RateDoctorButton_Click(object sender, RoutedEventArgs e)
        {

            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se napustite ostavljanje komentara?", "Napustate?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientRateDoctorPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientRateDoctorPage.xaml", UriKind.Relative));

            }
        }

        private void BlogButton_Click(object sender, RoutedEventArgs e)
        {
            if (feedback.Text.Equals(""))
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientBlogPage.xaml", UriKind.Relative));

            }
            else
            {

                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite unos vaseg komentara!", "Potvrdite unos!", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientBlogPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }

        }


        private void PatientChartButton_Click(object sender, RoutedEventArgs e)
        {
            if (feedback.Text.Equals(""))
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientChartPage.xaml", UriKind.Relative));

            }
            else
            {

                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite unos vaseg komentara!", "Potvrdite unos!", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientChartPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }


        }


        private void TherapyButton_Click(object sender, RoutedEventArgs e)
        {
            if (feedback.Text.Equals(""))
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientTherapyPage.xaml", UriKind.Relative));

            }
            else
            {

                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite unos vaseg komentara!", "Potvrdite unos!", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientTherapyPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }

        }

        private void HomePageButton_Click(object sender, RoutedEventArgs e)
        {

            if (feedback.Text.Equals(""))
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

            }
            else
            {

                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite unos vaseg komentara!", "Potvrdite unos!", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }



        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (!feedback.Text.Equals(""))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite da se vratite nazad?", "Povratak?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {

                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

            }
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {

            if (feedback.Text.Equals(""))
            {
               
                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                
            }
            else
            {

                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite unos vaseg komentara!", "Potvrdite unos!", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }

            
        }
    }
}
