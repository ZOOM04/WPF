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
using WpfApp1.Model;

namespace WpfApp1.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для dbViewPage.xaml
    /// </summary>
    public partial class dbViewPage : Page
    {
        public dbViewPage()
        {
            InitializeComponent();
            s.ItemsSource = AppData.db.User.ToList();
        }

        private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnE_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
