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
    /// Логика взаимодействия для DataUserPage.xaml
    /// </summary>
    public partial class DataUserPage : Page
    {
        public User user { get; set; }
        public DataUserPage()
        {
            InitializeComponent();
            user = SignInPage.user;
            this.DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChangePage(user));
        }
    }
}
