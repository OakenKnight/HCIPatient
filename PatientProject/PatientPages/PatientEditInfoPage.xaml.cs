using PatientProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
        string nameEmpty = "Unesite ime...";
        string parentEmpty = "Unesite ime roditelja...";
        string lastnameEmpty = "Unesite prezime...";
        string pinEmpty = "Unesite jmbg...";
        string livingCityEmpty = "Odaberite grad stanovanja...";
        string birthCityEmpty = "Odaberite grad rodjenja...";
        string telEmpty = "Unesite telefon...";
        string emailEmpty = "Unesite e-mail...";

        string doctorEmpty = "Odaberite doktora...";
        string genderEmpty = "Odaberite pol...";
        string dateEmpty = "Odaberite datum rodjenja...";

        string nameWrong = "Ime mora sadrzati samo slova!";
        string parentWrong = "Ime mora sadrzati samo slova!";
        string lastnameWrong = "Prezime mora sadrzati samo slova!";
        string pinShort = "Jmbg mora sadrzati 13 brojeva...";
        string pinWrong = "Jmbg mora sadrzati samo cifre!";
        string emailWrong = "Email mora sadrzati @!";
        string telWrong = "Telefon mora sadrzati samo cifre!";
        string dateWrong = "Datum mora biti unet u formatu dd-mm-yyyy!";

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
        public Patient patient {
            get;
            set;
        }
        public ObservableCollection<string> cities
        {
            get;
            set;
        }
        public PatientEditInfoPage(Patient p)
        {
            InitializeComponent();
            this.DataContext = this;

            doctors = new ObservableCollection<string>();
            genders = new ObservableCollection<string>();
            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            cities = new ObservableCollection<string>();
            patient = p;


            name.Text = p.name;
            parent.Text = p.lastname ;
            lastname.Text = p.parentName;
            pin.Text = p.pin;
            tel.Text = p.number;
            
            
            
            email.Text = p.email.ToString();

            cities.Add("Novi Sad");
            cities.Add("Subotica");
            cities.Add("Zrenjanin");
            cities.Add("Kekenda");
            cities.Add("Mali Idjos");
            cities.Add("Vrsac");
            cities.Add("Sombor");
            cities.Add("Senta");
            cities.Add("Kula");
            cities.Add("Indjija");
            cities.Add("Sremska Mitrovica");
            cities.Add("Bajmok");
            cities.Add("Backa Topola");


            genders.Add("Ženski");
            genders.Add("Muški");
            genders.Add("Drugi...");

            doctors.Add("dr Zoran Radovanovic");
            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");
            doctors.Add("dr Legenda Nestorovic");

            livingCity.SelectedItem = p.living_city;
            birthCity.SelectedItem = p.birth_city;
            dtp.SelectedDate = p.birth;
            gender.SelectedItem = p.gender;
            doctor.SelectedItem = p.chosenDoctor;
            dtp.DisplayDateEnd = DateTime.Today;

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

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            // string date = day.SelectedItem.ToString() + "/" + month.SelectedItem.ToString() + "/" + yrs.SelectedItem.ToString();
            //string date = dtp.SelectedDate.ToString().Split(' ')[0];

            //Console.WriteLine(date);

            validateName();
            validateParentName();
            validateLastname();
            validateLCity();
            validateBCity();
            validateTel();
            validateEmail();
            validateDoctor();
            validateGender();
            validateDate();
            validatePin();

            if (validateName() && validateParentName() && validateLastname() && validateLCity() && validateBCity() && validateTel() && validateEmail() && validateDoctor() && validatePin() && validateDate() && validateGender())
            {
                MessageBoxResult succesMessage = MessageBox.Show("Potvrdite izmene podataka na nalogu!", "Potvrdite izmene?", MessageBoxButton.OKCancel);
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new PatientProfilePage(doctor.SelectedItem.ToString(), name.Text, lastname.Text, parent.Text, dtp.SelectedDate.Value, tel.Text, gender.SelectedItem.ToString(), livingCity.SelectedItem.ToString(), birthCity.SelectedItem.ToString(), pin.Text, new MailAddress(email.Text)));
                            break;
                        }
                }

            }

               
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
          //  string date = day.SelectedItem.ToString() + "/" + month.SelectedItem.ToString() + "/" + yrs.SelectedItem.ToString();
           // string date = dtp.SelectedDate.ToString();
            NavigationService.Navigate(new PatientProfilePage(patient.chosenDoctor, patient.name, patient.lastname, patient.parentName, patient.birth, patient.number, patient.gender, patient.living_city, patient.birth_city, patient.pin, patient.email));

        }



        public bool validateDoctor()
        {
            if (doctor.SelectedItem == null)
            {
                errorWrongDoctor.Text = doctorEmpty;
                return false;
            }
            else
            {
                errorWrongDoctor.Text = "";
                return true;
            }
        }
        public bool validateGender()
        {
            if (gender.SelectedItem == null)
            {
                errorWrongGender.Text = genderEmpty;
                return false;
            }
            else
            {
                errorWrongGender.Text = "";
                return true;
            }
        }

        public bool validateDate()
        {
            DateTime temp;
            if (!DateTime.TryParse(dtp.Text, out temp))
            {
                errorWrongDate.Text = dateWrong;
                return false;
            }
            else if (dtp.SelectedDate == null)
            {
                errorWrongDate.Text = dateEmpty;
                return false;
            }
            else
            {
                errorWrongDate.Text = "";
                return true;
            }
        }

        public bool validateEmail()
        {
            if (email.Text.Equals(""))
            {
                errorWrongEmail.Text = emailEmpty;
                return false;
            }
            else if (!emailIsValid(email.Text))
            {
                errorWrongEmail.Text = emailWrong;
                return false;
            }
            else
            {
                errorWrongEmail.Text = "";
                return true;
            }
        }


        public bool validateTel()
        {
            if (tel.Text.Equals(""))
            {
                errorWrongNumber.Text = telEmpty;
                return false;
            }
            else if (!tel.Text.All(char.IsDigit))
            {
                errorWrongNumber.Text = telWrong;
                return false;
            }
            else
            {
                errorWrongNumber.Text = "";
                return true;
            }
        }
        public bool validateLCity()
        {
            if (livingCity.SelectedItem == null)
            {
                errorWrongLCity.Text = livingCityEmpty;
                return false;
            }
            else
            {
                errorWrongLCity.Text = "";
                return true;
            }
        }
        public bool validateBCity()
        {
            if (birthCity.SelectedItem == null)
            {
                errorWrongBCity.Text = birthCityEmpty;
                return false;
            }
            else
            {
                errorWrongBCity.Text = "";
                return true;
            }
        }
        public bool validatePin()
        {
            if (pin.Text.Equals(""))
            {
                errorWrongPin.Text = pinEmpty;
                return false;
            }
            else if (!pin.Text.All(char.IsDigit))
            {
                errorWrongPin.Text = pinWrong;

                return false;
            }
            else
            {
                if (pin.Text.Length != 13)
                {
                    errorWrongPin.Text = pinShort;
                    return false;
                }
                else
                {
                    errorWrongPin.Text = "";
                    return true;
                }
            }
        }
        public bool validateLastname()
        {
            if (lastname.Text.Equals(""))
            {
                errorWrongLastname.Text = lastnameEmpty;

                return false;
            }
            else if (!Regex.IsMatch(lastname.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                errorWrongLastname.Text = lastnameWrong;
                return false;
            }
            else
            {
                errorWrongLastname.Text = "";
                return true;
            }

        }
        public bool validateParentName()
        {


            if (parent.Text.Equals(""))
            {
                errorWrongNameParent.Text = parentEmpty;

                return false;
            }

            else if (!Regex.IsMatch(parent.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                errorWrongNameParent.Text = parentWrong;
                return false;
            }
            else
            {
                errorWrongNameParent.Text = "";
                return true;
            }
        }

        public bool validateName()
        {
            if (name.Text.Equals(""))
            {
                errorWrongName.Text = nameEmpty;
                return false;
            }
            else if (!Regex.IsMatch(name.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                errorWrongName.Text = nameWrong;

                return false;
            }
            else
            {
                errorWrongName.Text = "";
                return true;
            }
        }

        public bool emailIsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }



    }
}
