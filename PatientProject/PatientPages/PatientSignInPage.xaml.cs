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
    /// Interaction logic for PatientSignInPage.xaml
    /// </summary>
    public partial class PatientSignInPage : Page
    {




        public PatientSignInPage()
        {
            InitializeComponent();


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
                    errormessage.Text = "Unesite korisnicko ime i sifru.";

                    pwd.Focus();
                    user.Focus();

                }

                else if (password.Length == 0)
                {
                    errormessage.Text = "Unesite sifru.";
                    pwd.Focus();
                }
                else if (username.Length == 0)
                {
                    errormessage.Text = "Unesite korisnicko ime.";
                    user.Focus();
                }

            }
            else
            {
                errormessage.Text = "";


                if (!MainWindow.proveriPostojanje(user.Text))
                {

                    errorWrongInput.Text = "Pogresno korisnicko ime.";

                }
                else if (!MainWindow.ispravanaKorisnik(user.Text, pwd.Password))
                {

                    errorWrongInput.Text = "Pogresna lozinka";

                }
                else
                {
                    NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));
                    errorWrongInput.Text = "";
                    errormessage.Text = "";
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
