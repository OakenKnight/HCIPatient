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
    /// Interaction logic for PatientSignInPage.xaml
    /// </summary>
    public partial class PatientSignInPage : Page
    {




        private Dictionary<string, string> patients;
        public PatientSignInPage()
        {
            InitializeComponent();

            patients = new Dictionary<string, string>();

            patients.Add("pera", "pera");
        }

        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            string username = user.Text;
            string password = pwd.Password;

            //Console.WriteLine(username+password);

            if (password.Length == 0 || username.Length == 0)
            {
                if (password.Length == 0 && username.Length == 0)
                {
                    errormessage.Text = "Enter an username and password.";

                    pwd.Focus();
                    user.Focus();

                }

                else if (password.Length == 0)
                {
                    errormessage.Text = "Enter a password.";
                    pwd.Focus();
                }
                else if (username.Length == 0)
                {
                    errormessage.Text = "Enter an username.";
                    user.Focus();
                }

            }
            else
            {
                errormessage.Text = "";
                int k = 0;
                foreach (string username1 in patients.Values)
                {
                    if (username1.Equals(username))
                    {
                        k = 1;
                        Console.WriteLine(username);
                    }
                }

                if (k == 0)
                {
                    errorWrongInput.Text = "Wrong username.";
                    user.Focus();
                }
                else
                {
                    if (patients.ContainsKey(password))
                    {
                        if (patients[password].Equals(username))
                        {
                            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                            errorWrongInput.Text = "";
                            errormessage.Text = "";
                        }

                    }
                    else
                    {
                        errorWrongInput.Text = "Wrong password";
                        pwd.Focus();
                    }
                }


            }

        }

        private void forgotenPassword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientForgotenPasswordPage.xaml", UriKind.Relative));

        }

        private void Register_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientRegistrationPage.xaml", UriKind.Relative));
        }
    }
}
