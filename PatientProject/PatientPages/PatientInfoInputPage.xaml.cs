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
        string livingCityEmpty = "Unesite grad stanovanja...";
        string birthCityEmpty = "Unesite grad rodjenja...";
        string telEmpty = "Unesite telefon...";
        string emailEmpty = "Unesite e-mail...";

        string nameWrong = "Ime mora sadrzati samo slova!";
        string parentWrong = "Ime mora sadrzati samo slova!";
        string lastnameWrong = "Prezime mora sadrzati samo slova!";
        string pinShort = "Jmbg mora sadrzati 13 brojeva...";
        string pinWrong = "Jmbg mora sadrzati samo cifre!";
        string cityWrong = "Grad ne sme sadrzati cifre u nazivu!";
        string emailWrong = "Email mora sadrzati @!";
        string telWrong = "Telefon mora sadrzati samo cifre!";
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
        public PatientInfoInputPage()
        {
            InitializeComponent();
            this.DataContext = this;

            doctors = new ObservableCollection<string>();
            genders = new ObservableCollection<string>();
            days = new ObservableCollection<int>();
            years = new ObservableCollection<int>();
            months = new ObservableCollection<String>();

            genders.Add("Ženski");
            genders.Add("Muški");
            genders.Add("Drugi");

            doctors.Add("dr Goran Stevanovic");
            doctors.Add("dr Jovan Prodanov");
            doctors.Add("dr Jelena Klašnjar");
            doctors.Add("dr Miodrag Đukić");
            doctors.Add("dr Petar Petrović");



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
            validateCB();
            validatePin();

            if (validateName() && validateParentName() && validateLastname() && validateLCity() && validateBCity() && validateTel() && validateEmail() && validateCB() && validatePin())
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






        }
        public bool validateCB()
        {

            if (doctor.SelectedItem == null && gender.SelectedItem != null && dtp.SelectedDate != null)
            {
                errorWrongInput.Text = "Oznacite doktora!";
                return false;
            }
            else if (doctor.SelectedItem != null && gender.SelectedItem == null && dtp.SelectedDate != null)
            {
                errorWrongInput.Text = "Oznacite pol!";
                return false;
            }
            else if (doctor.SelectedItem != null && gender.SelectedItem != null && dtp.SelectedDate == null)
            {
                errorWrongInput.Text = "Oznacite datum!";
                return false;

            }
            else if (doctor.SelectedItem == null && gender.SelectedItem == null && dtp.SelectedDate != null)
            {
                errorWrongInput.Text = "Oznacite doktora i pol!";
                return false;

            }
            else if (doctor.SelectedItem == null && gender.SelectedItem != null && dtp.SelectedDate == null)
            {
                errorWrongInput.Text = "Oznacite doktora i godinu!";
                return false;
            }
            else if (doctor.SelectedItem != null && gender.SelectedItem == null && dtp.SelectedDate == null)
            {
                errorWrongInput.Text = "Oznacite pol i godinu!";
                return false;

            }
            else if (doctor.SelectedItem == null && gender.SelectedItem == null && dtp.SelectedDate == null)
            {
                errorWrongInput.Text = "Oznacite doktora, pol i datum rodjenja!";
                return false;
            }
            else
            {
                errorWrongInput.Text = "";
                return true;
            }
        }
        public bool validateEmail()
        {
            if (email.Text.Equals(""))
            {
                email.Text = emailEmpty;
                email.Foreground = Brushes.Red;
                return false;
            }
            else if (email.Text.Equals(emailEmpty))
            {
                return false;
            }
            else if (email.Text.Equals(emailWrong))
            {
                return false;
            }
            else if (!emailIsValid(email.Text))
            {
                email.Text = emailWrong;
                email.Foreground = Brushes.Red;
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool validateTel()
        {
            if (tel.Text.Equals(""))
            {
                tel.Text = telEmpty;
                tel.Foreground = Brushes.Red;
                return false;
            }
            else if (tel.Text.Equals(telEmpty))
            {
                return false;
            }
            else if (tel.Text.Equals(telWrong))
            {
                return false;
            }
            else if (!tel.Text.All(char.IsDigit))
            {
                tel.Text = telWrong;
                tel.Foreground = Brushes.Red;
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validateLCity()
        {
            if (livingCity.Text.Equals(""))
            {
                livingCity.Text = livingCityEmpty;
                livingCity.Foreground = Brushes.Red;
                return false;
            }
            else if (livingCity.Text.Equals(livingCityEmpty))
            {
                return false;
            }
            else if (!livingCity.Text.Equals(cityWrong) && !Regex.IsMatch(livingCity.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                livingCity.Text = cityWrong;
                livingCity.Foreground = Brushes.Red;
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validateBCity()
        {
            if (birthCity.Text.Equals(""))
            {
                birthCity.Text = birthCityEmpty;
                birthCity.Foreground = Brushes.Red;

                return false;
            }
            else if (birthCity.Text.Equals(birthCityEmpty))
            {
                return false;
            }
            else if (!birthCity.Text.Equals(cityWrong) && !Regex.IsMatch(birthCity.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                birthCity.Text = cityWrong;
                birthCity.Foreground = Brushes.Red;

                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validatePin()
        {
            if (pin.Text.Equals(""))
            {
                pin.Text = pinEmpty;
                pin.Foreground = Brushes.Red;
                return false;
            }
            else if (pin.Text.Equals(pinEmpty))
            {
                return false;
            }
            else if (pin.Text.Equals(pinWrong))
            {
                return false;
            }
            else if (pin.Text.Equals(pinShort))
            {
                return false;
            }
            else if (!pin.Text.All(char.IsDigit))
            {
                pin.Text = pinWrong;
                pin.Foreground = Brushes.Red;

                return false;
            }
            else
            {
                if (pin.Text.Length != 13)
                {
                    pin.Text = pinShort;
                    pin.Foreground = Brushes.Red;

                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool validateLastname()
        {
            if (lastname.Text.Equals(""))
            {
                lastname.Text = lastnameEmpty;
                lastname.Foreground = Brushes.Red;

                return false;
            }
            else if (lastname.Text.Equals(lastnameEmpty))
            {
                return false;
            }
            else if (!lastname.Text.Equals(lastnameWrong) && !Regex.IsMatch(lastname.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                lastname.Text = lastnameWrong;
                lastname.Foreground = Brushes.Red;

                return false;
            }
            else
            {
                return true;
            }

        }
        public bool validateParentName()
        {


            if (parentName.Text.Equals(""))
            {
                parentName.Text = parentEmpty;
                parentName.Foreground = Brushes.Red;

                return false;
            }
            else if (parentName.Text.Equals(parentEmpty))
            {
                return false;
            }
            else if (!parentName.Text.Equals(parentWrong) && !Regex.IsMatch(parentName.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                parentName.Text = parentWrong;
                parentName.Foreground = Brushes.Red;

                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validateName()
        {
            if (name.Text.Equals(""))
            {
                name.Text = nameEmpty;
                name.Foreground = Brushes.Red;
                return false;
            }
            else if (name.Text.Equals(nameEmpty))
            {
                return false;
            }
            else if (!name.Text.Equals(nameEmpty) && !Regex.IsMatch(name.Text, @"^[\p{L}\p{M}' \.\-]+$"))
            {
                name.Text = nameWrong;
                name.Foreground = Brushes.Red;

                return false;
            }
            else
            {
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
    }
}