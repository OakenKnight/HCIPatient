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
    /// Interaction logic for PatientChartPage.xaml
    /// </summary>
    public partial class PatientChartPage : Page
    {
        public ObservableCollection<ExpandersItem> alergies
        {
            get;
            set;
        }
        public ObservableCollection<ExpandersItem> drugs
        {
            get;
            set;
        }
        public ObservableCollection<Exam> examinations
        {
            get;
            set;
        }
        public ObservableCollection<Diagnosis> diagnosis
        {
            get;
            set;
        }
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public PatientChartPage()
        {
            InitializeComponent();
            this.DataContext = this;
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            alergies = new ObservableCollection<ExpandersItem>();
            drugs = new ObservableCollection<ExpandersItem>();
            diagnosis = new ObservableCollection<Diagnosis>();
            examinations = new ObservableCollection<Exam>();
            string personName = "Luka";
            string personLastname = "Lukovic";
            string personParent = "Pavle";
            DateTime personBirthDate = new DateTime(2001, 6, 12);
            string personLivingCity = "Bulevar Revolucije 2, Novi Sad, Srbija";
            string personPin = "1234567890123";

            name.Text = personName;
            parent.Text = personParent;
            lastname.Text = personLastname;
            pin.Text = personPin;
            livingCity.Text = personLivingCity;

            //header id content
            alergies.Add(new ExpandersItem("Sefilosporinc","alerg1", "Koza nakon uzimanja sefilosporinca bukne i bude poprilicno tesko resiti to."));
            alergies.Add(new ExpandersItem("Penicilin", "alerg2", "Koza nakon uzimanja penicilina bukne i javlja se osip i svrab."));
            alergies.Add(new ExpandersItem("Kikiriki", "alerg3", "Otok, groznica i temperatura."));
            alergies.Add(new ExpandersItem("Mlecni proizvodi", "alerg4", "Dijareja, bol u stomaku."));
            alergies.Add(new ExpandersItem("Polen", "alerg5", "Kasljanje i grebanje u grlu, curenje nosa."));
            alergies.Add(new ExpandersItem("Voda", "alerg6", "Lik ne sme da dotakne vodu"));

            drugs.Add(new ExpandersItem("Lek420", "L420", "17.5.2019-25.6.2019."));
            drugs.Add(new ExpandersItem("Lek666", "L666", "17.5.2019 - 25.6.2019."));
            drugs.Add(new ExpandersItem("Lek42", "L42", "17.5.2020-25.6.2020."));
            drugs.Add(new ExpandersItem("Lek1312", "L1312", "12.6.2019-25.6.2019."));
            drugs.Add(new ExpandersItem("Lek66669", "L66669", "20.5.2020-31.5.2020."));
            drugs.Add(new ExpandersItem("Lek420", "L420", "15.3.2020-25.3.2020."));

            diagnosis.Add(new Diagnosis("COVID-19","diag1","Pacijent je imao tesku pneumoniju, bol u grlu i kasljanje kao zmaj.","19.3.2020 - 4.4.2020."));
            diagnosis.Add(new Diagnosis("AIDS", "diag2", "Pacijent je zakacio aids.", "19.3.2019 - "));
            diagnosis.Add(new Diagnosis("Bol u stomaku", "diag3", "Pacijent je imao grceve u stomaku, povracanje i dijareju.", "12.2.2020 - 15.2.2020."));


            examinations.Add(new Exam(new DateTime(2020, 2, 4), "pregled1", "Dr Nebojsa Stojanovic"));
            examinations.Add(new Exam(new DateTime(2020, 2, 4), "pregled2", "Dr Nenad Katic"));
            examinations.Add(new Exam(new DateTime(2020, 2, 5), "pregled3", "Dr Pera Peric"));
            examinations.Add(new Exam(new DateTime(2020, 2, 6), "pregled4", "Dr Vukadin Vuk Mob"));
            examinations.Add(new Exam(new DateTime(2020, 3, 4), "pregled5", "Dr Goran Stevanovic"));
            examinations.Add(new Exam(new DateTime(2020, 2, 7), "pregled6", "Dr Legenda Nestorovic"));
            examinations.Add(new Exam(new DateTime(2020, 8, 7), "pregled7", "Dr Marko Kon"));
            examinations.Add(new Exam(new DateTime(2020, 2, 4), "pregled1", "Dr Nebojsa Stojanovic"));
            examinations.Add(new Exam(new DateTime(2020, 2, 4), "pregled2", "Dr Nenad Katic"));
            examinations.Add(new Exam(new DateTime(2020, 2, 5), "pregled3", "Dr Pera Peric"));
            examinations.Add(new Exam(new DateTime(2020, 2, 6), "pregled4", "Dr Vukadin Vuk Mob"));
            examinations.Add(new Exam(new DateTime(2020, 3, 4), "pregled5", "Dr Goran Stevanovic"));
            examinations.Add(new Exam(new DateTime(2020, 2, 7), "pregled6", "Dr Legenda Nestorovic"));
            examinations.Add(new Exam(new DateTime(2020, 8, 7), "pregled7", "Dr Marko Kon"));


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

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

        }

        private void showDrugs_Click(object sender, RoutedEventArgs e)
        {
            DrugsPopup.IsOpen = true;
        }



        private void showAlergies_Click(object sender, RoutedEventArgs e)
        {
            AlergiesPopup.IsOpen = true;
        }

        private void showExaminations_Click(object sender, RoutedEventArgs e)
        {
            ExamsPopup.IsOpen = true;
        }

        private void showDiagnosis_Click(object sender, RoutedEventArgs e)
        {
            DiagnosisPopup.IsOpen = true;
        }


        private void alergiesExit_Click(object sender, RoutedEventArgs e)
        {
            AlergiesPopup.IsOpen = false;
        }

        private void drugsExit_Click(object sender, RoutedEventArgs e)
        {
            DrugsPopup.IsOpen = false;
        }

        private void examsPopup_Click(object sender, RoutedEventArgs e)
        {
            ExamsPopup.IsOpen = false;
        }

        private void diagnosis_Click(object sender, RoutedEventArgs e)
        {
            DiagnosisPopup.IsOpen = false;
        }
    }
}
