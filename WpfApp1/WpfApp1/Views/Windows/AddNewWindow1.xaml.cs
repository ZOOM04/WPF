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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddNewWindow1.xaml
    /// </summary>
    public partial class AddNewWindow1 : Window
    {
        public AddNewWindow1()
        {
            InitializeComponent();
        }

        private void BtnDob_Click(object sender, RoutedEventArgs e)
        {
            var current = AppData.db.User.FirstOrDefault(item => item.TypeOfInsurancePolicy == item.TOP.ID);

            User NewUser = new User()
            {
                FullName = TBox.Text,
                DateOfBirth = DPicker.SelectedDate.Value,
                Gendercod = TBox8.Text,
                Telephone = Convert.ToInt32(TBox4.Text),
                PassportSeries = Convert.ToInt32(TBox2.Text),
                PassportNumber = Convert.ToInt32(TBox3.Text),
                Email = TBox5.Text,
                InsurancePolicyNumber = Convert.ToInt32(TBox6.Text),
                Post = TBox7.Text,
            };
            AppData.db.User.Add(NewUser);
            AppData.db.SaveChanges();

            this.Hide();
        }

        private void TBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnDob2_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CBox.ItemsSource = AppData.db.TOP.Select(Item => Item.TypeOfInsurancePolicy).ToList();

        }
    }
}
