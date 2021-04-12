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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "1" && PBPassword.Password == "1s")
            {
                NavigationService.Navigate(new MainPage());
            }
            else if (TBLogin.Text == "" || PBPassword.Password == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Уведомление",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Вы ввели неверные данные!", "Уведомление",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            TBLogin.Text = "";
            PBPassword.Password = "";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (PBPassword.Visibility == Visibility.Visible)
            {
                Parol.Text = PBPassword.Password;
                PBPassword.Visibility = Visibility.Collapsed;
                Parol.Visibility = Visibility.Visible;
            }
            else
            { 
                PBPassword.Visibility = Visibility.Visible;
                Parol.Visibility = Visibility.Collapsed;
            }
        }

        private void BtnB2_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult Result = MessageBox.Show("Закрыть приложение?", "Уведомление", MessageBoxButton.YesNo,MessageBoxImage.Question );
            Application.Current.Shutdown();
        }
    }
}
