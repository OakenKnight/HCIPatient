using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
    /// Interaction logic for PatientSeeDoctorsPage.xaml
    /// </summary>
    public partial class PatientScheduledExamsChart : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public Dictionary<int, int> mesecBroj {
            get;
            set;
        }
        public int januar;
        public int februar;
        public int mart;
        public int april;
        public int maj;
        public int jun;
        public int jul;
        public int avgust;
        public int septembar;
        public int oktobar;
        public int novembar;
        public int decembar;

        public PatientScheduledExamsChart()
        {
            InitializeComponent();
            mesecBroj = new Dictionary<int, int>();
            ucitajDatumePregleda();

            LoadColumnChartData();

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

        private void LoadColumnChartData()
        {
            ((BarSeries)mcChart.Series[0]).ItemsSource =
                new KeyValuePair<string, int>[]{
                new KeyValuePair<string, int>(" januar", mesecBroj[1]),
                new KeyValuePair<string, int>("februar", mesecBroj[2]),
                new KeyValuePair<string, int>("mart", mesecBroj[3]),
                new KeyValuePair<string, int>("april", mesecBroj[4]),
                new KeyValuePair<string, int>("maj", mesecBroj[5]),
                new KeyValuePair<string, int>("jun", mesecBroj[6]),
                new KeyValuePair<string, int>("jul", mesecBroj[7]),
                new KeyValuePair<string, int>("avgust", mesecBroj[8]),
                new KeyValuePair<string, int>("septembar", mesecBroj[9]),
                new KeyValuePair<string, int>("oktobar", mesecBroj[10]),
                new KeyValuePair<string, int>("novembar", mesecBroj[11]),
                new KeyValuePair<string, int>("decembar", mesecBroj[12]) };

        }
        public void ucitajDatumePregleda() {
               
                mesecBroj[1] = 0;
                mesecBroj[2] = 0;
                mesecBroj[3] = 0;
                mesecBroj[4] = 0;
                mesecBroj[5] = 0;
                mesecBroj[6] = 0;
                mesecBroj[7] = 0;
                mesecBroj[8] = 0;
                mesecBroj[9] = 0;
                mesecBroj[10] = 0;
                mesecBroj[11] = 0;
                mesecBroj[12] = 0;
           


                foreach (ScheduledExam exam in MainWindow.exams) {
                    mesecBroj[exam.Date.Month] += 1;
                }


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
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduledExamsPage.xaml", UriKind.Relative));

        }




    }
}