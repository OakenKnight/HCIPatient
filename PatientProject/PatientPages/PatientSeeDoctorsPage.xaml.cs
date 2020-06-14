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
    /// Interaction logic for PatientSeeDoctorsPage.xaml
    /// </summary>
    
    public partial class PatientSeeDoctorsPage : Page
    {
        public ObservableCollection<ExpandersItem> doctors 
        {
            get;
            set;
        }
        public PatientSeeDoctorsPage()
        {
            InitializeComponent();
            this.DataContext = this;
            doctors = new ObservableCollection<ExpandersItem>();

            string nestorovic = "Doktor Legenda Nestorovic, u narodu poznat kao doktor estrogenije, poznat po svojim veoma avangardnim stavovima o Covid19 i Nikoli Tesli. Da, dobro ste procitali! O Nikoli Tesli!";
            string stevanovic = "Doktor Goran Stevanovic, Rođen je 1972. godine u Beogradu. Osnovnu i srednju školu završio je u Beogradu, kako ističe u biografiji priloženoj uz doktorsku disertaciju, sa odličnim uspehom. Medicinski fakultet u Beogradu upisao je školske 1990 / 91.i diplomirao 1.jula 1996.godine sa prosečnom ocenom 9,42.Tokom studija, navodi, objavio je nekoliko stručnih radova na studentskim kongresima i časopisu „Medicinski podmladak\" ";
            string petrovic = "Doktor Petar Petrovic, izmisljena licnost. Ima specijalne moci da izleci osobu od depresije i ftna.";
            string prodanov = "Doktor Jovan Prodanov, legenda Novog Sada. Lekar koji zagovara skakanje po blatnjavim baricama i jedenje mrava zarad viseg cilja";
            string klasnjar = "Doktor Jelena Klasnjar, Jako dobar lekar. Vec mi ponestaje ideja za ovo";
            string djukic = "Doktor Miodrag Djukic. Lik koji je zasluzan za smanjenej broja rokova studentima. Predaje SPPURV, predmet koji nikog ne zanima, predmet koji smo svi prepisivali sa slika od prethodnih godina. Srbenda.";
            doctors.Add(new ExpandersItem("dr Legenda Nestorovic", "id1", nestorovic));
            doctors.Add(new ExpandersItem("dr Goran Stevanovic", "id2", stevanovic));
            doctors.Add(new ExpandersItem("dr Petar Petrovic", "id3", petrovic));
            doctors.Add(new ExpandersItem("dr Jovan Prodanov", "id4", prodanov));
            doctors.Add(new ExpandersItem("dr Jelena Klasnjar", "id5", klasnjar));
            doctors.Add(new ExpandersItem("dr Miodrag Djukic", "id6", djukic));

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
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

        }



 

    }
}
