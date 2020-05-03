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
            int k = 0;
            if (username.Text.Length == 0)
            {
                username.Text = "Unesite korisničko ime...";
                username.Focus();
                k = 1;
            }

            if (pwd1.Password.Length == 0 && pwd2.Password.Length == 0)
            {
                errormessage.Text = "Unesite lozinku i ponovite je!";
            }
            else if (pwd1.Password.Length == 0)
            {
                errormessage.Text = "Unesite lozinku...";
                pwd1.Focus();
            }
            else if (pwd2.Password.Length == 0)
            {
                errormessage.Text = "Ponovite lozinku...";
                pwd2.Focus();
            }
            else if (!pwd1.Password.Equals(pwd2.Password))
            {
                errormessage.Text = "Lozinke se ne poklapaju! Ponovite opet!";
                pwd2.Focus();
            }
            else
            {
                if (k == 0 && username.Text != "Unesite korisničko ime...")
                {
                    errormessage.Text = "";

                    NavigationService.Navigate(new Uri("/PatientPages/PatientInfoInputPage.xaml", UriKind.Relative));

                }
                else if (username.Text == "Unesite korisničko ime...")
                {
                    errormessage.Text = "Unesite korisničko ime...";
                    username.Text = "";
                    username.Focus();
                }
            }
        }
    }
}
