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
    /// Логика взаимодействия для MainViewPage.xaml
    /// </summary>
    public partial class MainViewPage : Page
    {
        public static User user { get; set; }
        public MainViewPage(User getUser)
        {
            InitializeComponent();
            user = getUser;
            this.DataContext = this;
            //filtrCmb.ItemsSource = ConnectClass.db.Country.Select(item => item.Title).ToList();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e) 
        {
            try
            {
                NiggaTable deleteCheck = (NiggaTable)listVieww.SelectedItem;

                if (deleteCheck == null)
                {
                    MessageBox.Show("Вы не выбрали товар", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Error);


                }else if (MessageBox.Show("Вы действительно хотите удалить выбранный элемент? Данные будут удалены навсегда", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (deleteCheck != null)
                    {
                        ConnectClass.db.NiggaTable.Remove(deleteCheck);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                    else
                    {
                        throw new Exception("Для удаления выберите элемент из спика");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           

            filtrCmb.ItemsSource = ConnectClass.db.Country.ToList();
    

            listVieww.ItemsSource = ConnectClass.db.NiggaTable.ToList();
            if (user.RoleID == 1)
            {
                PersonalAreaBtn.Content = "Пользователи";
            }
            else
            {
                PersonalAreaBtn.Content = "Личный кабинет";
                AdminPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {   
            NavigationService.Navigate(new AddPage(new NiggaTable()));
        }

        private void editBtn_Click(object sender, RoutedEventArgs e) 
        {
                try
            {
                if (listVieww.SelectedItem != null)
                {
                    NavigationService.Navigate(new AddPage(listVieww.SelectedItem as NiggaTable));
                }
                else
                {
                    throw new Exception("Выберите элемент для редактирования!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listVieww.ItemsSource = ConnectClass.db.NiggaTable.Where(item => item.Name.Contains(searchTxb.Text) || item.SIze.Contains(searchTxb.Text) || item.Speed.Contains(searchTxb.Text)
            || item.Country.Title.Contains(searchTxb.Text)).ToList();
        }

        private void filtrCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
            var CurrentRole = filtrCmb.SelectedItem as Country;
            if (CurrentRole != null)
            {
                listVieww.ItemsSource = ConnectClass.db.NiggaTable.Where(item => item.CountryCode == CurrentRole.ID).ToList();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?","Выход", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                NavigationService.GoBack();
            }
        }

        private void PersonalAreaBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (PersonalAreaBtn.Content == "Личный кабинет")
            {
                NavigationService.Navigate(new DataUserPage());
            }
            else
            {
            NavigationService.Navigate(new PersonalAreaPage());
            }
        }

        private void clear_cmb_Click(object sender, RoutedEventArgs e)
        {
            listVieww.ItemsSource = ConnectClass.db.NiggaTable.ToList();
            filtrCmb.ItemsSource = null;
            filtrCmb.ItemsSource = ConnectClass.db.Country.ToList();
          
        }
    }
}
