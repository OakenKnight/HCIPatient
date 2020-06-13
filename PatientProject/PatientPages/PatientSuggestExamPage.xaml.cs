using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for PatientSuggestExamPage.xaml
    /// </summary>
    public partial class PatientSuggestExamPage : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public ObservableCollection<string> doctors
        {
            get;
            set;
        }
        public ObservableCollection<ScheduledExam> exams
        {
            get;
            set;
        }
        ScheduledExam exam = null;
        public PatientSuggestExamPage()
        {
            InitializeComponent();

            this.DataContext = this;
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;

            doctors = new ObservableCollection<string>();
            exams = new ObservableCollection<ScheduledExam>();
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");
            startDate.DisplayDateStart = DateTime.Today;
            endDate.DisplayDateStart = DateTime.Today;
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
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleExamPage.xaml", UriKind.Relative));

        }

        private void suggestExam_Click(object sender, RoutedEventArgs e)
        {
            //TODO za pocetak samo da kaze da nema termina

            if (startDate.SelectedDate != null && endDate.SelectedDate != null && doctorCB.SelectedItem != null)
            {
                //ovde se prikazuje kako izgleda kada nema nicega
                if (startDate.SelectedDate.Value > endDate.SelectedDate.Value)
                {
                    errorDateWrong.Text = "Datum pocekta ne moze biti posle datuma kraja! Izmenite datume i pokusajte opet!";
                }
                else
                {
                    int a = 0;

                    if (a == 0)
                    {
                        string[] parts = startDate.SelectedDate.Value.ToString().Split(' ');
                        string[] parts1 = endDate.SelectedDate.Value.ToString().Split(' ');
                        string doctor = doctorCB.SelectedValue.ToString();

                        string poruka = "Za lekara: " + doctor + " nema slobodnih termina u periodu od " + parts[0] + " do " + parts1[0];
                        unsuccessfullNum1.Text = poruka;


                        unsuccssfullPopup1.IsOpen = true;




                    }
                    else
                    {
                            exam = new ScheduledExam(DateTime.Today.Date, "id5", doctorCB.SelectedItem.ToString(), "17:30", "200");
                            exams.Add(exam);

                            itemControl.DataContext = null;
                            itemControl.DataContext = exams;
                            

                            Binding b = new Binding("exams")
                            {
                                Source = this
                            };
                            itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b);
                            itemControl.Items.Refresh();
                        

                        successPopup.IsOpen = true;
                    }


                    errorDateWrong.Text = "";


                }


            }
            else
            {
                if (startDate.SelectedDate == null)
                {
                    //TREBA DA SE POSTAVI ZA GRESKU NES
                    errorNoInputStart.Text = "Odaberite datum za pocetak perioda!";
                }
                else
                {
                    errorNoInputStart.Text = "";

                }

                if (endDate.SelectedDate == null)
                {
                    //TREBA DA SE POSTAVI ZA GRESKU NES
                    errorNoInputEnd.Text = "Odaberite datum za kraj perioda!";

                }
                else
                {
                    errorNoInputEnd.Text = "";

                }

                if (doctorCB.SelectedItem == null)
                {

                    //TREBA GRESKU ISPOISATI
                    errorNoInputDoctor.Text = "Odaberite lekara!";

                }
                else
                {
                    errorNoInputDoctor.Text = "";

                }

                errorDateWrong.Text = "";

            }


        }
        /*
        private void closePopup_Click(object sender, RoutedEventArgs e)
        {
            if (sender.ToString().Equals("unsuccssfullPopup1"))
            {
                unsuccssfullPopup1.IsOpen = false;

            }
            else if(sender.ToString().Equals("unsuccssfullPopup2"))
            {
                unsuccssfullPopup2.IsOpen = false;

            }else if (sender.ToString().Equals("successPopup"))
            {
                successPopup.IsOpen = false;
            }
        }
        */
        private void suggestExamPriority_Click(object sender, RoutedEventArgs e)
        {
            if(radioDoctor.IsChecked==true || radioTimePeriod.IsChecked==true)
            {
                errorNoRadioButton.Text = "";
                unsuccssfullPopup1.IsOpen = false;

                if (radioDoctor.IsChecked == true)
                {
                    //ovde cemo prikazati sta se desava kad se pokrene i recimo pronadje 

                    int a = 1;

                    if (a == 0)
                    {
                        
                        string doctor = doctorCB.SelectedValue.ToString();

                        string poruka = "Nazalost kod lekara: " + doctor + " nema slobodnih termina u narednom periodu! Mozete pokusati da zakazete pregled kod drugog lekara.";
                        unsuccessfullNum2.Text = poruka;




                        unsuccssfullPopup2.IsOpen = true;
                    }
                    else
                    {
                        exams.Clear();

                        exam = new ScheduledExam(DateTime.Today.Date, "id5", doctorCB.SelectedItem.ToString(), "17:30", "200");
                        exams.Add(exam);

                        itemControl.DataContext = null;
                        itemControl.DataContext = exams;


                        Binding b = new Binding("exams")
                        {
                            Source = this
                        };
                        itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b);
                        itemControl.Items.Refresh();


                        successPopup.IsOpen = true;
                    }
                }
                
                if(radioTimePeriod.IsChecked == true)
                {
                    //ovde cemo prikazati sta se desava kad se pokrene i recimo pronadje

                    int a = 1;

                    if (a == 0)
                    {

                        string[] parts = startDate.SelectedDate.Value.ToString().Split(' ');
                        string[] parts1 = endDate.SelectedDate.Value.ToString().Split(' ');
                        string poruka = "Nazalost u periodu izmedju: " + parts[0] + " i "+ parts1[0] +" nema slobodnih termina! Mozete pokusati da zakazete pregled u drugom periodu.";
                        unsuccessfullNum3.Text = poruka;




                        unsuccssfullPopup3.IsOpen = true;
                    }
                    else
                    {
                        exams.Clear();

                        exam = new ScheduledExam(DateTime.Today.Date, "id5", "dr Miodrag Djukic", "17:30", "200");
                        exams.Add(exam);

                        itemControl.DataContext = null;
                        itemControl.DataContext = exams;


                        Binding b = new Binding("exams")
                        {
                            Source = this
                        };

                        itemControl.SetBinding(ItemsControl.ItemsSourceProperty, b);
                        itemControl.Items.Refresh();


                        successPopup.IsOpen = true;
                    }

                }


            }
            else
            {
                errorNoRadioButton.Text = "Niste selektovali prioritet!";
            }

        }

        private void scheduleExam_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult areYouSureMessage = MessageBox.Show("Da li ste sigurni da zelite da zakazete pregled?", "Zakazivanje pregleda?", MessageBoxButton.YesNo);
            switch (areYouSureMessage)
            {
                case MessageBoxResult.Yes:
                    {
                        MessageBoxResult successMessage = MessageBox.Show("Uspesno ste zakazali pregled!","Uspesno!", MessageBoxButton.OK);
                        
                        break;
                    }

            }
        }

        private void backPopupClick(object sender, RoutedEventArgs e)
        {
            string[] parts = startDate.SelectedDate.Value.ToString().Split(' ');
            string[] parts1 = endDate.SelectedDate.Value.ToString().Split(' ');
            string doctor = doctorCB.SelectedValue.ToString();

            string poruka = "Za lekara: " + doctor + " nema slobodnih termina u periodu od " + parts[0] + " do " + parts1[0];
            unsuccessfullNum1.Text = poruka;



            unsuccssfullPopup1.IsOpen = true;

        }

    }
}
