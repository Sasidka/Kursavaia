using Students.Classes;
using Students.Model;
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
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        public static User user { get; set; }
        public SignUpPage(User cUser)
        {
            InitializeComponent();
            user = cUser;
            this.DataContext = this;
        }
       

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PasswordTb.Text.Length < 4)
                {
                    throw new Exception("Пароль должен содержать не менее 4-х символов");
                }
                else
                {
                    ConnectClass.db.User.Add(user);
                    MessageBox.Show("Вы успешно зарегестрировались!");
                    NavigationService.GoBack();
            
                    if (user.RoleID == null)
                    {
                        user.RoleID = 2;
                    }
                    ConnectClass.db.SaveChanges();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ReturnPasswordTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ReturnPasswordTb.Text!= PasswordTb.Text)
            {
                PasswordTb.Background = Brushes.Red;
                ReturnPasswordTb.Background = Brushes.Red;
                addBtn.IsEnabled = false;
            }
            else
            {
                PasswordTb.Background = Brushes.Green;
                ReturnPasswordTb.Background = Brushes.Green;
                addBtn.IsEnabled = true;
            }
        }
    }
}
