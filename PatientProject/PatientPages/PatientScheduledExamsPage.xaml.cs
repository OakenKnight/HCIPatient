using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
    /// Interaction logic for PatientScheduledExamsPage.xaml
    /// </summary>
    public partial class PatientScheduledExamsPage : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public ObservableCollection<ScheduledExam> examsForToday
        {
            get;
            set;
        }
        public ObservableCollection<ScheduledExam> examsForTomorrow
        {
            get;
            set;
        }
        public ObservableCollection<ScheduledExam> examsForTmrw2
        {
            get;
            set;
        }
        public ObservableCollection<ScheduledExam> examsForTmrw3
        {
            get;
            set;
        }
        public Dictionary<DateTime, string> scheduledExamsNames {
            get;
            set;
        }
        public ObservableCollection<ScheduledExam> exams
        {
            get;
            set;
        }
        public ScheduledExam selectedExam { 
            get;
            set;

        }
        public DateTime dns = DateTime.Today;
        public DateTime tmrw = DateTime.Today;
        public DateTime dayaftertmrw2 = DateTime.Today;
        public DateTime dayaftertmrw = DateTime.Today;
        public ObservableCollection<string> doctors
        {
            get;
            set;
        }

        public ObservableCollection<string> vremena
        {
            get;
            set;
        }

        public PatientScheduledExamsPage()
        {
            InitializeComponent();


            this.DataContext = this;

            examsForToday = new ObservableCollection<ScheduledExam>();
            examsForTomorrow = new ObservableCollection<ScheduledExam>();
            examsForTmrw2 = new ObservableCollection<ScheduledExam>();
            examsForTmrw3 = new ObservableCollection<ScheduledExam>();
            doctors = new ObservableCollection<string>();
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klasnjar");
            doctors.Add("dr Miodrag Đukic");
            doctors.Add("dr Petar Petrovic");
            doctors.Add("dr Legenda Nestorovic");

            vremena = new ObservableCollection<string>();

            DateTime startShift = new DateTime(2020, 5, 11, 7, 00, 0);
            DateTime endShift = new DateTime(2020, 5, 11, 18, 00, 0);

            IEnumerable<DateTime> listOfHours = Enumerable.Range(0, 24).Select(h => startShift.AddHours(h));

            foreach (DateTime hour in listOfHours)
            {
                if (hour.Hour >= 7 && hour.Hour <= 18)
                {
                    vremena.Add(hour.TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                    vremena.Add(hour.AddMinutes(30).TimeOfDay.ToString().Substring(0, hour.TimeOfDay.ToString().Length - 3));
                }
            }

            scheduledExamsNames = new Dictionary<DateTime, string>();
            calendarStackPanel.Visibility = Visibility.Hidden;
            dns = DateTime.Today;

            tmrw = dns.AddDays(1);
            dayaftertmrw = dns.AddDays(2);
            dayaftertmrw2 = dns.AddDays(3);
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            ScheduledExam exam1 = new ScheduledExam(dns, "id1", "dr Jovan Prodanov","12:30","217");
            ScheduledExam exam2 = new ScheduledExam(dns, "id2", "dr Legenda Nestorovic", "13:30", "237");

            ScheduledExam exam3 = new ScheduledExam(tmrw, "id3", "dr Jelena Klasnjar", "11:30", "211");
            ScheduledExam exam4 = new ScheduledExam(tmrw, "id4", "dr Goran Stevanovic", "13:30", "420");

            ScheduledExam exam5 = new ScheduledExam(dayaftertmrw, "id5", "dr Legenda Nestorovic", "17:30", "200");
            ScheduledExam exam6 = new ScheduledExam(dayaftertmrw, "id6", "dr Legenda Nestorovic", "9:30", "12");

            ScheduledExam exam7 = new ScheduledExam(dayaftertmrw2, "id7", "dr Legenda Nestorovic", "16:30", "666");

            exams = MainWindow.exams;

            selectedExam = null;

            examsForToday.Add(exam1);
            examsForToday.Add(exam2);

            examsForTomorrow.Add(exam3);
            examsForTomorrow.Add(exam4);

            examsForTmrw3.Add(exam5);
            examsForTmrw3.Add(exam6);

            examsForTmrw2.Add(exam7);


            scheduledExamsNames[dns.Date] = nameof(examsForToday);
            scheduledExamsNames[tmrw.Date] = nameof(examsForTomorrow);
            scheduledExamsNames[dayaftertmrw2.Date] = nameof(examsForTmrw3);
            scheduledExamsNames[dayaftertmrw.Date] = nameof(examsForTmrw2);

            calendar.DisplayDateStart = DateTime.Today;
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

            try
            {
                string[] parts = calendar.SelectedDate.Value.Date.ToString().Split(' ');

                dateText.Text = parts[0];


                List<DateTime> dates = new List<DateTime>();

                foreach (DateTime date in scheduledExamsNames.Keys)
                {
                    dates.Add(date);
                }





                if (!dates.Contains(Convert.ToDateTime(sender.ToString())))
                {
                    ExamsPopup.IsOpen = false;

                }
                else
                {
                    foreach (DateTime date in dates)
                    {
                        if (sender.ToString().Equals(date.Date.ToString()))
                        {
                            itemControl.DataContext = null;
                            itemControl.DataContext = scheduledExamsNames[date.Date];
                            Console.WriteLine(scheduledExamsNames[date.Date]);

                            Binding b = new Binding(scheduledExamsNames[date.Date].ToString())
                            {
                                Source = this
                            };
                            itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b);
                            itemControl.Items.Refresh();
                        }


                    }

                    ExamsPopup.IsOpen = true;

                }
            }
            catch
            {
            }

            






        }
        private void closePopup_Click(object sender, RoutedEventArgs e)
        {
            ExamsPopup.IsOpen = false;
            itemControl.DataContext = null;
            
        }

        private void calendarView_Click(object sender, RoutedEventArgs e)
        {
            listViewStackPanel.Visibility = Visibility.Hidden; 
            calendarStackPanel.Visibility = Visibility.Visible;

        }

        private void list_Click(object sender, RoutedEventArgs e)
        {
            listViewStackPanel.Visibility = Visibility.Visible;
            calendarStackPanel.Visibility = Visibility.Hidden;

        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
                if (listView.SelectedItems.Count > 0)
                {
                    selectedExam = (ScheduledExam)listView.SelectedItems[0];
                    doktor.SelectedItem = selectedExam.Doctor;
                    time.SelectedItem = selectedExam.Time;
                    date.SelectedDate = selectedExam.Date;
                    room.Text = selectedExam.Room;
                    if (selectedExam.Date > DateTime.Today) {
                        selectedExamPopup.IsOpen = true;

                    }
                }
            
        }

        private void reschedule_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da izmenite pregled?", "Izmena?", MessageBoxButton.YesNo);
            switch (succesMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        selectedExam.Date = date.SelectedDate.Value;
                        selectedExam.Doctor = doktor.SelectedItem.ToString();
                        selectedExam.Time = time.SelectedItem.ToString();

                        foreach (ScheduledExam eX in MainWindow.exams)
                        {
                            if (eX.Id.Equals(selectedExam.Id))
                            {
                                eX.Date = selectedExam.Date;
                                eX.Doctor = selectedExam.Doctor;
                                eX.Time = selectedExam.Time;
                            }

                        }

                        exams = MainWindow.exams;

                        ICollectionView view = CollectionViewSource.GetDefaultView(exams);
                        view.Refresh();

                        selectedExamPopup.IsOpen = false;
                        break;

                    }

            }


            

        }

        private void showChart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduledExamsChart.xaml", UriKind.Relative));
        }

        private void selectedExit_Click(object sender, RoutedEventArgs e)
        {
            selectedExamPopup.IsOpen = false;
        }
    }
}