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
    /// Логика взаимодействия для ChangePage.xaml
    /// </summary>
    public partial class ChangePage : Page
    {
        public User getUser { get; set; }
        public ChangePage(User user)
        {
            InitializeComponent();
            getUser = user;
            this.DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RoleCmb.ItemsSource = ConnectClass.db.Role.ToArray();
            try
            {
            if (getUser.RoleID == 2)
            {
                PersonalDataPanel.Visibility = Visibility.Collapsed;

            }else 
            {
                PersonalDataPanel.Visibility = Visibility.Visible;
            }
            }
            catch (Exception)
            {

                MessageBox.Show("выберите пользователя","Сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == "" || SurnameTb.Text == "")
            {
            MessageBox.Show("Введите данные", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
            ConnectClass.db.SaveChanges();
            MessageBox.Show("Данные сохранены","Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
