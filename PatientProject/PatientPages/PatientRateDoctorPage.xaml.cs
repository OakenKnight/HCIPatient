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
    /// Interaction logic for PatientRateDoctorPage.xaml
    /// </summary>
    public partial class PatientRateDoctorPage : Page
    {
        public ObservableCollection<string> doctors
        {
            get;
            set;
        }
        public ObservableCollection<int> ratings
        {
            get;
            set;
        }
        public PatientRateDoctorPage()
        {
            InitializeComponent();
            this.DataContext = this;

            ratings = new ObservableCollection<int>();
            doctors = new ObservableCollection<string>();

            for (int i = 1; i < 11; i++) {
                ratings.Add(i);
            }

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
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientFeedbackPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientFeedbackPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientProfilePage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
        }


        private void EmergencyExamButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO 1: mora da se uradi ovde
        }

        private void NewExamButton_Click(object sender, RoutedEventArgs e)
        {
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
        }


        private void ScheduledExamsButton_Click(object sender, RoutedEventArgs e)
        {
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }


        }



        private void DoctorsButton_Click(object sender, RoutedEventArgs e)
        {
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientSeeDoctorsPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientSeeDoctorsPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }


        }



        private void RateDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientRateDoctorPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientRateDoctorPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }


        }

        private void BlogButton_Click(object sender, RoutedEventArgs e)
        {
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientBlogPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
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
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientChartPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
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
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientTherapyPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
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
            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
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

            if (doctor.SelectedItem == null && rating.SelectedItem == null)
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null)
            {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);

            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Zelite li da napustite ocenjivanje lekara?", "Napustate ocenjivanje?", MessageBoxButton.OKCancel);
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

        private void Accept_Click(object sender, RoutedEventArgs e)
        {

            if (doctor.SelectedItem == null && rating.SelectedItem == null && feedback.Text == "")
            {
                NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

            }
            else if (doctor.SelectedItem == null || rating.SelectedItem == null) {
                MessageBoxResult succesMessage = MessageBox.Show("Molim Vas popunite polja za ocenu i izbor lekara!", "Popunite obavezna polja!", MessageBoxButton.OK);
                
            }
            else
            {
                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite ocenu lekara!", "Potvrdite ocenu!", MessageBoxButton.OKCancel);
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
