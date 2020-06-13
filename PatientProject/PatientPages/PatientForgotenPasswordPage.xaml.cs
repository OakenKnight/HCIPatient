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

            if (username.Text.Length != 0 && jmbg.Text.Length != 0 && jmbg.Text.All(char.IsDigit) && pwd1.Password.Length != 0 && pwd2.Password.Length != 0 && pwd1.Password.Equals(pwd2.Password))
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
                    errorWrongName.Text = "Unesite korisnicko ime...";
                }
                else {
                    errorWrongName.Text = "";
                }


                if (jmbg.Text.Length == 0)
                {
                    errorWrongPin.Text = "Unesite jmbg...";
                }
                else if(!jmbg.Text.All(char.IsDigit))
                {
                    errorWrongPin.Text = "JMBG mora imati samo cifre..";
                }
                else
                {
                    errorWrongPin.Text="";
                }


                if (pwd1.Password.Length == 0 || pwd2.Password.Length == 0 || !pwd1.Password.Equals(pwd2.Password)) {


                    if (pwd1.Password.Length == 0)
                    {
                        errorWrongPass1.Text = "Unesite lozinku...";

                    }
                    else
                    {
                        errorWrongPass1.Text = "";
                    }

                    if (pwd2.Password.Length == 0)
                    {
                        errorWrongPass2.Text = "Unesite lozinku...";

                    }
                    else
                    {
                        errorWrongPass2.Text = "";
                    }


                    if (!pwd2.Password.Equals(pwd1.Password))
                    {
                        errormessage.Text = "Lozinke se ne poklapaju! Pokušajte ponovo.";

                    }
                }
                
            }

            

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientSignInPage.xaml", UriKind.Relative));
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
