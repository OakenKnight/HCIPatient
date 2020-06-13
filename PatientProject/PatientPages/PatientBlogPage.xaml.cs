using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PatientBlogPage.xaml
    /// </summary>
    public partial class PatientBlogPage : Page
    {
        public ObservableCollection<Notification> notifications
        {
            get;
            set;
        }
        public ObservableCollection<ExpandersItem> comments
        {
            get;
            set;
        }
        public ObservableCollection<ExpandersItem> comments2
        {
            get;
            set;
        }
        public ObservableCollection<BlogArticle> blogArticles
        {
            get;
            set;
        }
        
        public ObservableCollection<QuestionAnswer> pitanjaOdgovori
        {
            get;
            set;
        }
        public PatientBlogPage()
        {
            InitializeComponent();
            this.DataContext = this;

            Notifications notifi = new Notifications();
            notifications = notifi.notifications;
            blogStackPanel.Visibility = Visibility.Visible;
            questionsStackPanel.Visibility = Visibility.Hidden;
            askStackPanel.Visibility = Visibility.Hidden;
            pitanjaOdgovori = new ObservableCollection<QuestionAnswer>();

            pitanjaOdgovori.Add(new QuestionAnswer("Da li imam koronu?", "Ne"));
            pitanjaOdgovori.Add(new QuestionAnswer("Da li imam sidu?", "Ne"));
            pitanjaOdgovori.Add(new QuestionAnswer("Da li mogu da se ubijem od 12 bromazepama?", "Da"));
            pitanjaOdgovori.Add(new QuestionAnswer("Da li mogu da slomim nogu kad skocim sa zgrade?", "Zavisi"));

            comments = new ObservableCollection<ExpandersItem>();
            comments2 = new ObservableCollection<ExpandersItem>();
            blogArticles = new ObservableCollection<BlogArticle>();

            comments.Add(new ExpandersItem("Pera","kom1", "APUJIOBFSIPASFBIASUOHFBHIOASFVIASFGVB"));
            comments.Add(new ExpandersItem("Perica", "kom1", "APUJIOBFSIPASFBIASUOHFBHIOASFVIASFGVB"));
            comments.Add(new ExpandersItem("Stevica", "kom1", "APUJIOBFSIPASFBIASUOHFBHIOASFVIASFGVB"));
            comments2.Add(new ExpandersItem("Stevandza", "kom1", "NIP[NIOP[NIO[HNIOHIONIO"));
            comments2.Add(new ExpandersItem("Jovandza", "kom1", "[ASHNIOFBUIPASPFVYIOASIOPVYBUFVBI0PSA"));
            comments2.Add(new ExpandersItem("SergejTrifunovic123", "kom1", "[ASJOFB9PASG7R9-ASGHRF-[D90"));


            blogArticles.Add(new BlogArticle("Blog clanak 1", "B1", "Size matters not. Look at me. Judge me by my size do you? And well you should not. For my ally is the force, and a powerful ally it is. Life creates it. Makes it grow. It's energy surrounds us, and binds us. Luminous beings are we, not this crude matter. You must feel the force around you. Here. Between you, and me. The tree. The rock. Everywhere. Even between the land and the ship",comments));
            blogArticles.Add(new BlogArticle("Blog clanak2", "B2", "I- I killed them... I killed them all... They're dead, every single one of them. And not just the men, but the women and the children, too. They're like animals, and I slaughtered them like animals. I HATE THEM.",comments));
            blogArticles.Add(new BlogArticle("Blog clanak 3", "B3", "Have you ever had a SINGLE MOMENT'S THOUGHT about my responsibilities? Have you ever thought, for a single solitary moment about my responsibilities to my employers? Has it ever occurred to you that I have agreed to look after the OVERLOOK Hotel until May the FIRST. Does it MATTER TO YOU AT ALL that the OWNERS have placed their COMPLETE CONFIDENCE and TRUST in me, and that I have signed a letter of agreement, a CONTRACT, in which I have accepted that RESPONSIBILITY? Do you have the SLIGHTEST IDEA, what a MORAL AND ETHICAL PRINCIPLE IS, DO YOU? Has it ever occurred to you what would happen to my future, if I were to fail to live up to my responsibilities? Has it ever occurred to you? HAS IT?",comments));
            blogArticles.Add(new BlogArticle("Blog clanak 4", "B4", " I like you, Lloyd. I always liked you. You were always the best of them...Best goddamned bartender from Timbuktu to Portland, Maine...or Portland, Oregon, for that matter. I like you, Lloyd.I always liked you.You were always the best of them.Best goddamned bartender from Timbuktu to Portland, Maine, or Portland, Oregon, for that matter.",comments2));
            blogArticles.Add(new BlogArticle("Blog clanak 5", "B5", "Ezekiel 25:17 “The path of the righteous man is beset on all sides by the inequities of the selfish and the tyranny of evil men. Blessed is he who, in the name of charity and good will, shepherds the weak through the valley of the darkness, for he is truly his brother's keeper and the finder of lost children. And I will strike down upon thee with great vengeance and furious anger those who attempt to poison and destroy My brothers. And you will know I am the Lord when I lay My vengeance upon you.",comments2));
            blogArticles.Add(new BlogArticle("Blog clanak 6", "B6", "I told you I would tell you my names. This is what they call me. I'm called Glad-of-War, Grim, Raider, and Third. I am One-Eyed. I am called Highest, and True-Guesser. I am Grimnir, and I am the Hooded One. I am All-Father, and I am Gondlir Wand-Bearer. I have as many names as there are winds, as many titles as there are ways to die. My ravens are Huginn and Muninn, Thought and Memory; my wolves are Freki and Geri; my horse is the gallows.",comments2));
            




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
            NavigationService.Navigate(new Uri("/PatientPages/PatientScheduleEmergencyExamPage.xaml", UriKind.Relative));

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

        private void EditInfoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage",UriKind.Relative));

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PatientPages/PatientMainPage.xaml", UriKind.Relative));

            
        }

        private void ask_Click(object sender, RoutedEventArgs e)
        {
            blogStackPanel.Visibility = Visibility.Hidden;
            questionsStackPanel.Visibility = Visibility.Hidden;
            askStackPanel.Visibility = Visibility.Visible;
        }

        private void qanda_Click(object sender, RoutedEventArgs e)
        {
            blogStackPanel.Visibility = Visibility.Hidden;
            questionsStackPanel.Visibility = Visibility.Visible;
            askStackPanel.Visibility = Visibility.Hidden;

        }

        private void blog_Click(object sender, RoutedEventArgs e)
        {
            blogStackPanel.Visibility = Visibility.Visible;
            questionsStackPanel.Visibility = Visibility.Hidden;
            askStackPanel.Visibility = Visibility.Hidden;

        }

        private void submitQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (!askDoctor.Text.Equals(""))
            {
                QuestionAnswer qa = new QuestionAnswer(askDoctor.Text, "");

                MessageBoxResult succesMessage = MessageBox.Show("Da li ste sigurni da zelite da postavite pitanje?", "Postavljate pitanje?", MessageBoxButton.YesNo);
                switch (succesMessage)
                {
                    case MessageBoxResult.Yes:
                        {
                            this.pitanjaOdgovori.Add(qa);
                            blogStackPanel.Visibility = Visibility.Hidden;
                            askStackPanel.Visibility = Visibility.Hidden;
                            questionsStackPanel.Visibility = Visibility.Visible;

                            break;
                        }

                }


            }

        }

        private void pera_Click(object sender, RoutedEventArgs e)
        {
            Button a = (Button)sender;
            Console.WriteLine(a.Content.ToString());
        }
    }
}
