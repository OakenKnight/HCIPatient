using PatientProject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Xml;

namespace HCZdravo.PatientPages
{
    /// <summary>
    /// Interaction logic for PatientInfoInputPage.xaml
    /// </summary>
    public partial class PatientInfoInputPage : Page
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
        string cityWrong = "Grad ne sme sadrzati cifre u nazivu!";
        string emailWrong = "Email mora sadrzati @!";
        string telWrong = "Telefon mora sadrzati samo cifre!";
        string dateWrong = "Datum mora biti unet u formatu dd-mm-yyyy!";
        

        public ObservableCollection<string> doctors
        {
            get;
            set;
        }
        public ObservableCollection<string> cities
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
        public PatientInfoInputPage()
        {
            InitializeComponent();
            this.DataContext = this;

            doctors = new ObservableCollection<string>();
            genders = new ObservableCollection<string>();
            cities = new ObservableCollection<String>();

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
            genders.Add("Drugi");

            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");
            doctors.Add("dr Legenda Nestorovic");

            dtp.DisplayDateEnd = DateTime.Today;

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientRegistrationPage.xaml", UriKind.Relative));
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            // ispraviti validaciju na ovome
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
                MessageBoxResult succesMessage = MessageBox.Show("Uspešno ste kreirali nalog!", "Uspešno!", MessageBoxButton.OKCancel);
                errorWrongInput.Text = "";
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else {
                errorWrongInput.Text = "Polja sa zvezdicom moraju biti popunjena";
            }






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

        public bool validateDate() {

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
            if (livingCity.SelectedItem == null) {
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
            if (birthCity.SelectedItem==null)
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


            if (parentName.Text.Equals(""))
            {
                errorWrongNameParent.Text = parentEmpty;

                return false;
            }

            else if (!Regex.IsMatch(parentName.Text, @"^[\p{L}\p{M}' \.\-]+$"))
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
        private void name_GotFocus(object sender, RoutedEventArgs e)
        {

            //System.Diagnostics.Process.Start("osk.exe");
            if (name.Text.Equals(nameEmpty))
            {
                name.Text = "";
            }
            else if (name.Text.Equals(nameWrong))
            {
                name.Text = "";
            }
        }

        private void parentName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (parentName.Text.Equals(parentEmpty))
            {
                parentName.Text = "";
            }
            else if (parentName.Text.Equals(parentWrong))
            {
                parentName.Text = "";
            }
        }

        private void lastname_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastname.Text.Equals(lastnameEmpty))
            {
                lastname.Text = "";
            }
            else if (lastname.Text.Equals(lastnameWrong))
            {
                lastname.Text = "";
            }
        }

        private void pin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pin.Text.Equals(pinEmpty))
            {
                pin.Text = "";
            }
            else if (pin.Text.Equals(pinShort))
            {
                pin.Text = "";
            }
            else if (pin.Text.Equals(pinWrong))
            {
                pin.Text = "";
            }
        }
        private void livingCity_GotFocus(object sender, RoutedEventArgs e)
        {
            if (livingCity.Text.Equals(livingCityEmpty))
            {
                livingCity.Text = "";
            }
            else if (livingCity.Text.Equals(cityWrong))
            {
                livingCity.Text = "";
            }
        }

        private void birthCity_GotFocus(object sender, RoutedEventArgs e)
        {
            if (birthCity.Text.Equals(birthCityEmpty))
            {
                birthCity.Text = "";
            }
            else if (birthCity.Text.Equals(cityWrong))
            {
                birthCity.Text = "";
            }
        }

        private void tel_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tel.Text.Equals(telEmpty))
            {
                tel.Text = "";
            }
            else if (tel.Text.Equals(telWrong))
            {
                tel.Text = "";
            }
        }

        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text.Equals(emailEmpty))
            {
                email.Text = "";
            }
            else if (email.Text.Equals(emailWrong))
            {
                email.Text = "";
            }
        }
        private void exitClick_Click(object sender, RoutedEventArgs e)
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
    }
}