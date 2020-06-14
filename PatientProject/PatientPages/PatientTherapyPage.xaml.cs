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
using System.Windows.Xps;
using System.Windows.Xps.Packaging;
using System.IO;
using MaterialDesignThemes.Wpf.Converters;

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PatientTherapyPage.xaml
    /// </summary>
    public partial class PatientTherapyPage : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
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
        public ObservableCollection<ExpandersItem> drugs4
        {
            get;
            set;
        }


        private Dictionary<DateTime, string> drugsListNames
        {
            get;
            set;
        }

        public ObservableCollection<DrugsThreapy> drugsTherapy
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
            drugs4 = new ObservableCollection<ExpandersItem>();
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            
            
            dataGridTherapy.Visibility = Visibility.Visible;
            calendarStackPanel.Visibility = Visibility.Hidden;

            drugsListNames = new Dictionary<DateTime, string>();
            drugsTherapy = new ObservableCollection<DrugsThreapy>();
            drugs.Add(new ExpandersItem("Lek1", "L1", "Pije se tri puta dnevno"));

            drugs1.Add(new ExpandersItem("Lek2", "L2", "Pije se jednom dnevno"));

            drugs2.Add(new ExpandersItem("Lek3", "L420", "Pije se jednom dnevno"));

            drugs3.Add(new ExpandersItem("Lek4", "L1312", "Pije se jednom dnevno"));

            drugs4.Add(new ExpandersItem("Lek5", "L420", "Pije se dva puta dnevno"));



            drugsTherapy.Add(new DrugsThreapy("1.6.2020","4.6.2020.","Lek1", "Pije se tri puta dnevno"));
            drugsTherapy.Add(new DrugsThreapy("4.6.2020", "8.6.2020.", "Lek2", "Pije se jednom  dnevno"));
            drugsTherapy.Add(new DrugsThreapy("9.6.2020", "13.6.2020.", "Lek3", "Pije se jednom dnevno"));
            drugsTherapy.Add(new DrugsThreapy("14.6.2020", "27.6.2020.", "Lek4", "Pije se tri puta dnevno"));
            drugsTherapy.Add(new DrugsThreapy("5.7.2020", "12.7.2020.", "Lek5", "Pije se dva puta dnevno"));




            drugsListNames[new DateTime(2020, 6, 1)] = nameof(drugs);
            drugsListNames[new DateTime(2020, 6, 2)] = nameof(drugs);
            drugsListNames[new DateTime(2020, 6, 3)] = nameof(drugs);
            drugsListNames[new DateTime(2020, 6, 4)] = nameof(drugs); 

            drugsListNames[new DateTime(2020, 6, 5)] = nameof(drugs1);
            drugsListNames[new DateTime(2020, 6, 6)] = nameof(drugs1);
            drugsListNames[new DateTime(2020, 6, 7)] = nameof(drugs1);
            drugsListNames[new DateTime(2020, 6, 8)] = nameof(drugs1);

            drugsListNames[new DateTime(2020, 6, 9)] = nameof(drugs2);
            drugsListNames[new DateTime(2020, 6, 10)] = nameof(drugs2);
            drugsListNames[new DateTime(2020, 6, 11)] = nameof(drugs2);
            drugsListNames[new DateTime(2020, 6, 12)] = nameof(drugs2);
            drugsListNames[new DateTime(2020, 6, 13)] = nameof(drugs2);

            drugsListNames[new DateTime(2020, 6, 14)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 15)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 16)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 17)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 18)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 19)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 20)] = nameof(drugs3); 
            drugsListNames[new DateTime(2020, 6, 21)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 22)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 23)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 24)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 25)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 26)] = nameof(drugs3);
            drugsListNames[new DateTime(2020, 6, 27)] = nameof(drugs3);

            drugsListNames[new DateTime(2020, 7, 5)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 6)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 7)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 8)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 9)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 10)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 11)] = nameof(drugs4);
            drugsListNames[new DateTime(2020, 7, 12)] = nameof(drugs4);


            

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



        private void CalendarDayButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            try {
                string[] parts = calendar.SelectedDate.Value.Date.ToString().Split(' ');

                dateText.Text = parts[0];

                Console.WriteLine(sender.ToString());

                if (!drugsListNames.Keys.Contains(Convert.ToDateTime(sender.ToString())))
                {
                    TherapyPopup.IsOpen = false;

                }
                else
                {
                    foreach (DateTime datum in drugsListNames.Keys)
                    {
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

            }
            catch
            {
            }

            


            
            
        }
        private void closePopup_Click(object sender, RoutedEventArgs e)
        {
            TherapyPopup.IsOpen = false;
            itemControl.DataContext = null;
        }

        private void list_Click(object sender, RoutedEventArgs e)
        {
            calendarStackPanel.Visibility = Visibility.Hidden;
            dataGridTherapy.Visibility = Visibility.Visible;
        }

        private void calendarView_Click(object sender, RoutedEventArgs e)
        {
            calendarStackPanel.Visibility = Visibility.Visible;
            dataGridTherapy.Visibility = Visibility.Hidden;

        }

        private void generisi_Click(object sender, RoutedEventArgs e)
        {
            PreviewZaStampu win = new PreviewZaStampu();
            win.Show();

        }
        

        

    }
}
