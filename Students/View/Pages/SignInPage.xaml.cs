using Students.Classes;
using Students.Model;
using Students.View.Pages;
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

namespace Students.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public static User user { get;set; }
        public SignInPage()
        {
            InitializeComponent();
        }


        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpPage(new User()));
        }


        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var DataUser = ConnectClass.db.User.FirstOrDefault(x => x.Login == LoginTB.Text && x.Password == PasswordTB.Password);

            if (DataUser != null)
            {
                NavigationService.Navigate(new MainViewPage(DataUser));
                user = DataUser;
            }
            else
            {
                Message("Вы ввели неверныке данные");
            }
        }
        public void Message(string text)
        {
            MessageBox.Show(text, "вход", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }
    }
}
