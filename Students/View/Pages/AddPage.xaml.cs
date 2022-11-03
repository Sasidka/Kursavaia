using Microsoft.Win32;
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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public static NiggaTable user { get; set; }
        
        public OpenFileDialog file = new OpenFileDialog();
        public AddPage(NiggaTable cUser)
        {
            InitializeComponent();
            user= cUser;
            this.DataContext = this;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CountryCmb.ItemsSource = ConnectClass.db.Country.ToList();
            if (user.ID != 0)
            {
                addBtn.Content = "Изменить";
            }
            else if (user.ID == 0)
            {
                addBtn.Content = "Добавить";
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (user.ID == 0)
            {
                user.Image = file.FileName;
                ConnectClass.db.NiggaTable.Add(user);
                ConnectClass.db.SaveChanges();
                CountryCmb.SelectedItem = user;
                MessageBox.Show("Данные были успешно добавлены!");
                NavigationService.GoBack();
            }
            else if (user.ID != 0)
            {
                user.Image = file.FileName;
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
                NavigationService.GoBack();
            }
        }

        private void SaveImageBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (file.ShowDialog() == true)
                {
                    ProductImage.Source = new BitmapImage(new Uri(file.FileName));
                }
                //if (user.ID == 0)
                //{
                //    ConnectClass.db.NiggaTable.Add(user);
                //}
                //ConnectClass.db.SaveChanges();
                //MessageBox.Show("Изменения успешно сохранены", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так!", "Упсм", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
