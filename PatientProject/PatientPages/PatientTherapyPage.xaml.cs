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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Binding = System.Windows.Data.Binding;
using MessageBox = System.Windows.MessageBox;

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PatientTherapyPage.xaml
    /// </summary>
    public partial class PatientTherapyPage : Page
    {
        public ObservableCollection<ExpandersItem> drugs
        {
            get;
            set;
        }
        public ObservableCollection<ExpandersItem> drugs1 
        {
            get;
            set;
        }
        public ObservableCollection<ExpandersItem> drugs2
        {
            get;
            set;
        }
        public ObservableCollection<ExpandersItem> drugs3
        {
            get;
            set;
        }


        private Dictionary<DateTime, string> drugsListNames
        {
            get;
            set;
        }
        public DateTime dns = DateTime.Today;
        public DateTime tmrw = DateTime.Today;
        public DateTime ystrdy = DateTime.Today;
        public DateTime dayaftertmrw = DateTime.Today;

        public PatientTherapyPage()
        {
            InitializeComponent();

            
            this.DataContext = this;
            drugs = new ObservableCollection<ExpandersItem>();
            drugs1 = new ObservableCollection<ExpandersItem>();
            drugs2 = new ObservableCollection<ExpandersItem>();
            drugs3 = new ObservableCollection<ExpandersItem>();

            drugsListNames = new Dictionary<DateTime, string>();

            drugs.Add(new ExpandersItem("Lek1", "L1", "Pije se tri puta dnevno"));
            drugs.Add(new ExpandersItem("Lek2", "L2", "Pije se jednom dnevno"));
            drugs.Add(new ExpandersItem("Lek3", "L3", "Pije se tri puta dnevno"));
            drugs.Add(new ExpandersItem("Lek4", "L4", "Pije se dva puta dnevno"));

            drugs1.Add(new ExpandersItem("Lek2", "L2", "Pije se jednom dnevno"));
            drugs1.Add(new ExpandersItem("Lek3", "L3", "Pije se tri puta dnevno"));
            drugs1.Add(new ExpandersItem("Lek4", "L4", "Pije se dva puta dnevno"));
            
            drugs2.Add(new ExpandersItem("Lek420", "L420", "Pije se jednom dnevno"));
            drugs2.Add(new ExpandersItem("Lek666", "L666", "Pije se tri puta dnevno"));
            drugs2.Add(new ExpandersItem("Lek42", "L42", "Pije se dva puta dnevno"));

            drugs3.Add(new ExpandersItem("Lek1312", "L1312", "Pije se jednom dnevno"));
            drugs3.Add(new ExpandersItem("Lek66669", "L66669", "Pije se tri puta dnevno"));
            drugs3.Add(new ExpandersItem("Lek420", "L420", "Pije se dva puta dnevno"));
            dns = DateTime.Today;

            tmrw = dns.AddDays(1);
            dayaftertmrw = dns.AddDays(2);
            ystrdy = dns.AddDays(-1);
            
            drugsListNames[dns.Date] = nameof(drugs);
            drugsListNames[tmrw.Date] = nameof(drugs1);
            drugsListNames[ystrdy.Date] = nameof(drugs2);
            drugsListNames[dayaftertmrw.Date] = nameof(drugs3);

            foreach (DateTime datum in drugsListNames.Keys) {
                Console.WriteLine(drugsListNames[datum]);            
            }

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



        private void CalendarDayButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gridContainer.Focus();

            dateText.Text = calendar.SelectedDate.Value.Date.ToString();

            Console.WriteLine(sender.ToString());
            /*
            if (sender.ToString().Equals(dns.Date.ToString()))
            {
                itemControl.DataContext = null;
                itemControl.DataContext = drugs;
                Binding b = new Binding("drugs")
                {
                    Source = this
                };
                itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b);
                itemControl.Items.Refresh();
            }
            else
            {
                Console.WriteLine("PIJNPIJNBJIPBUJIOPBUIOP");
                itemControl.DataContext = null;
                itemControl.DataContext = drugs1;
                Binding b1 = new Binding("drugs1")
                {
                    Source = this
                };
                itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b1);
                itemControl.Items.Refresh();

            }
            */


            itemControl.DataContext = null;
            itemControl.DataContext = drugs;
            Binding b1 = new Binding("drugs")
            {
                Source = this
            };
            itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b1);
            itemControl.Items.Refresh();

            
            foreach (DateTime datum in drugsListNames.Keys) {
                if (sender.ToString().Equals(datum.Date.ToString()))
                {
                    itemControl.DataContext = null;
                    itemControl.DataContext = drugsListNames[datum.Date];
                    Console.WriteLine(drugsListNames[datum.Date]);
                    Binding b = new Binding(drugsListNames[datum.Date].ToString())
                    {
                        Source = this
                    };
                    itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b);
                    itemControl.Items.Refresh();
                }
            }

            TherapyPopup.IsOpen = true;
            
        }
        private void closePopup_Click(object sender, RoutedEventArgs e)
        {
            TherapyPopup.IsOpen = false;
            itemControl.DataContext = null;
        }
    }
}
