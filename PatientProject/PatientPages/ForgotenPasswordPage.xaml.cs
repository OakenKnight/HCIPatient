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

namespace HCZdravo.PatientPages
{
    /// <summary>
    /// Interaction logic for ForgotenPasswordPage.xaml
    /// </summary>
    public partial class ForgotenPasswordPage : Page
    {
        public ForgotenPasswordPage()
        {
            InitializeComponent();
        }


        private void ResetPassowrd_Button_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text.Length != 0 && jmbg.Text.Length != 0 && pwd1.Password.Length != 0 && pwd2.Password.Length != 0 && pwd1.Password.Equals(pwd2.Password))
            {
                MessageBoxResult succesMessage = MessageBox.Show("Uspešno ste resetovali lozinku!", "Uspešno!", MessageBoxButton.OKCancel);
                errormessage.Text = "";
                switch (succesMessage)
                {
                    case MessageBoxResult.OK:
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientSignInPage.xaml", UriKind.Relative));
                            break;
                        }
                }
            }
            else
            {
                if (username.Text.Length == 0)
                {
                    username.Text = "Unesite korisnicko ime...";
                }
                else if (username.Text.Equals("Unesite korisnicko ime..."))
                {
                    errormessage.Text = "Niste uneli korisnicko ime!";
                }

                if (jmbg.Text.Length == 0)
                {
                    jmbg.Text = "Unesite jmbg...";
                }
                else if (jmbg.Text.Equals("Unesite jmbg..."))
                {
                    errormessage.Text = "Niste uneli lozinku!";
                }

                if (pwd1.Password.Length == 0)
                {
                    errormessage1.Text = "Unesite lozinku...";
                    errormessage.Text = "";
                    pwd1.Focus();
                }
                else if (pwd2.Password.Length == 0)
                {
                    errormessage1.Text = "Ponovite unos lozinke...";
                    errormessage.Text = "";
                    pwd2.Focus();
                }
                else if (!pwd1.Password.Equals(pwd2.Password))
                {
                    errormessage1.Text = "";
                    errormessage.Text = "Lozinke se ne poklapaju! Pokušajte ponovo.";
                    pwd2.Focus();
                }
            }

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientSignInPage.xaml", UriKind.Relative));
        }
    }
}
