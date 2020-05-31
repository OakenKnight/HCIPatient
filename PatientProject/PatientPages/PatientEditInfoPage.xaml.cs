using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for PatientEditInfoPage.xaml
    /// </summary>

    public partial class PatientEditInfoPage : Page
    {
        public ObservableCollection<string> doctors
        {
            get;
            set;
        }
        public ObservableCollection<string> genders
        {
            get;
            set;
        }

        public ObservableCollection<int> years
        {
            get;
            set;
        }
        public ObservableCollection<String> months
        {
            get;
            set;
        }
        public ObservableCollection<int> days
        {
            get;
            set;
        }


        public PatientEditInfoPage(string chosenDoctor, string personName, string personLastname, string personParent, DateTime personBirthDate, string personTelephone, string personGender, string personLivingCity, string personBirthCity, string personPin, MailAddress personEmail)
        {
            InitializeComponent();
            this.DataContext = this;

            doctors = new ObservableCollection<string>();
            genders = new ObservableCollection<string>();
            days = new ObservableCollection<int>();
            years = new ObservableCollection<int>();
            months = new ObservableCollection<String>();

            name.Text = personName;
            parent.Text = personParent;
            lastname.Text = personLastname;
            pin.Text = personPin;
            tel.Text = personTelephone;
            
            livingCity.Text = personLivingCity;
            birthCity.Text = personBirthCity;
            
            email.Text = personEmail.ToString();

            genders.Add("Ženski");
            genders.Add("Muški");
            genders.Add("Drugi...");

            doctors.Add("dr Zoran Radovanovic");
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");

            String[] parts = personBirthDate.ToString().Split(' ');
            foreach (String part in parts) {
                Console.WriteLine(part);
            }
            /*
            day.SelectedItem = Convert.ToInt32(parts[0]);
            month.SelectedItem = parts[1];
            yrs.SelectedItem = Convert.ToInt32(parts[2]);
            */
            //Console.WriteLine(dtp.SelectedDate.ToString());
            dtp.SelectedDate = personBirthDate;
            gender.SelectedItem = personGender;
            doctor.SelectedItem = chosenDoctor;
            

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

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            // string date = day.SelectedItem.ToString() + "/" + month.SelectedItem.ToString() + "/" + yrs.SelectedItem.ToString();
            //string date = dtp.SelectedDate.ToString().Split(' ')[0];

            //Console.WriteLine(date);
            DateTime date = dtp.SelectedDate.Value;
            MessageBoxResult succesMessage = MessageBox.Show("Potvrdite izmene podataka na nalogu!", "Potvrdite izmene?", MessageBoxButton.OKCancel);
            switch (succesMessage)
            {
                case MessageBoxResult.OK:
                    {
                        NavigationService.Navigate(new PatientProfilePage(doctor.SelectedItem.ToString(), name.Text, lastname.Text, parent.Text, dtp.SelectedDate.Value, tel.Text, gender.SelectedItem.ToString(), livingCity.Text, birthCity.Text, pin.Text, new MailAddress(email.Text)));
                        break;
                    }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
          //  string date = day.SelectedItem.ToString() + "/" + month.SelectedItem.ToString() + "/" + yrs.SelectedItem.ToString();
           // string date = dtp.SelectedDate.ToString();
            NavigationService.Navigate(new PatientProfilePage(doctor.SelectedItem.ToString(), name.Text, lastname.Text, parent.Text, dtp.SelectedDate.Value, tel.Text, gender.SelectedItem.ToString(), livingCity.Text, birthCity.Text, pin.Text, new MailAddress(email.Text)));

        }
    }
}

/*
 <Grid Grid.Row="8" Grid.Column="2" Grid.ColumnSpan="3">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="31*"/>
                                <RowDefinition Height="13*"/>
                            </Grid.RowDefinitions>
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="65*"/>
                                <ColumnDefinition Width="104*"/>
                                <ColumnDefinition Width="90*"/>
                            </Grid.ColumnDefinitions>
                            <!-- TODO 1: uraditi comboboxeve svuda sa material designom  -->
                            
                            <ComboBox Grid.Column="0" Grid.Row="0" ItemsSource="{Binding Path= days}" Name="day" Width="47" HorizontalAlignment="Left" Height="24" />
                            <ComboBox Grid.Column="1" Grid.Row="0" ItemsSource="{Binding Path= months}" Name="month" Width="90" HorizontalAlignment="Center" Height="24"/>
                            <ComboBox Grid.Column="2" Grid.Row="0" ItemsSource="{Binding Path= years}" Name="yrs" Width="76" HorizontalAlignment="Center" Height="24" />

                            <TextBlock Grid.Row="1" Grid.Column="0" FontSize="10" HorizontalAlignment="Center" Margin="10,0,25,0" Width="34">Dan</TextBlock>
                            <TextBlock Grid.Row="1" Grid.Column="1" FontSize="10" HorizontalAlignment="Center" Margin="10,0,25,0" Width="34">Mesec</TextBlock>
                            <TextBlock Grid.Row="1" Grid.Column="2" FontSize="10" HorizontalAlignment="Center" Margin="10,0,25,0" Width="34">Godina</TextBlock>

                        </Grid>
*/