using PatientProject;
using System;
using System.Collections.Generic;
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

namespace HCZdravo
{
    /// <summary>
    /// Interaction logic for PatientRegistrationPage.xaml
    /// </summary>
    public partial class PatientRegistrationPage : Page
    {
        String usernameWrong = "Korisnicko ime je vec zauzeto";
        String usernameEmpty = "Unesite korisnicko ime";
        String passWrong = "Lozinka nema dovoljno karaktera";
        int minPassChars = 6;
        public PatientRegistrationPage()
        {
            InitializeComponent();
            
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientSignInPage.xaml", UriKind.Relative));
        }

        private void Nastavi_Button_Click(object sender, RoutedEventArgs e)
        {
            validateUsername();
            validatePasswordFirst();
            validatePasswordSecond();
            if (validateUsername() && validatePasswordFirst() && validatePasswordSecond())
            {
                if (!pwd1.Password.Equals(pwd2.Password)) 
                {
                    errormessage.Text = "Lozinke se ne poklapaju! Ponovite opet!";

                }
                else 
                {

                    MainWindow.korisnici[pwd1.Password] = username.Text;
                    foreach(string key in MainWindow.korisnici.Keys)
                    {
                        Console.WriteLine(MainWindow.korisnici[key]);
                    }

                    NavigationService.Navigate(new Uri("/PatientPages/PatientInfoInputPage.xaml", UriKind.Relative));

                }
            }
            
        }




        public bool validateUsername()
        {
            if (username.Text.Equals(""))
            {
                username.Text = usernameEmpty;
                username.Foreground = Brushes.Red;
                return false;
            }
            else if (username.Text.Equals(usernameEmpty))
            {
                return false;
            }
            else if (username.Text.Equals(usernameWrong))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validatePasswordFirst()
        {
            if (pwd1.Password.Equals(""))
            {
                errormessage.Text = "Unesite lozinku i ponovite je!";

                return false;
            }
            else if (pwd1.Password.Length < minPassChars) {
                
                errormessage.Text = passWrong;
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool validatePasswordSecond()
        {
            if (pwd2.Password.Equals(""))
            {
                errormessage.Text = "Unesite lozinku i ponovite je!";

                return false;
            }
            else if (pwd2.Password.Length < minPassChars)
            {
                errormessage.Text = passWrong;
                return false;
            }
            else
            {
                return true;
            }
        }

        private void username_GotFocus(object sender, RoutedEventArgs e)
        {
            username.Foreground = Brushes.Black;
            if (username.Text.Equals(usernameEmpty))
            {
                username.Text = "";
            }
            else if (username.Text.Equals(usernameWrong))
            {
                username.Text = "";
            }
        }
        
        private void pwd1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (errormessage.Text.Equals("Unesite lozinku i ponovite je!") || errormessage.Text.Equals(passWrong))
            {
                errormessage.Text = "";
            }
            
        }

        private void pwd2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (errormessage.Text.Equals("Unesite lozinku i ponovite je!") || errormessage.Text.Equals(passWrong))
            {
                errormessage.Text = "";
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
