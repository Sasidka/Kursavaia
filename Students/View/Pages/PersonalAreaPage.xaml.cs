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
    /// Логика взаимодействия для PersonalAreaPage.xaml
    /// </summary>
    public partial class PersonalAreaPage : Page
    {
        public PersonalAreaPage()
        {
            InitializeComponent();

            filtrCmb.ItemsSource = ConnectClass.db.Role.ToList();

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataUserLV.ItemsSource = ConnectClass.db.User.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataUserLV.ItemsSource = ConnectClass.db.User.Where(item => item.Name.Contains(searchTxb.Text) || item.Surname.Contains(searchTxb.Text) || item.Patronymic.Contains(searchTxb.Text)
           || item.Role.TItle.Contains(searchTxb.Text)).ToList();
        }

        private void filtrCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var CurrentRole = filtrCmb.SelectedItem as Role;
            DataUserLV.ItemsSource = ConnectClass.db.User.Where(item => item.RoleID == CurrentRole.ID).ToList();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentUser = DataUserLV.SelectedItem as User;
            NavigationService.Navigate(new ChangePage(CurrentUser));
        }
    }
}
