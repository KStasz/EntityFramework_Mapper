using EntityFramework_Mapper.Models;
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
using System.Windows.Shapes;

namespace EntityFramework_Mapper.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy UserCreationWindow.xaml
    /// </summary>
    public partial class UserCreationWindow : Window
    {
        public IEnumerable<Car> Cars { get; }
        public People NewPeople { get; private set; }
        public UserCreationWindow(IEnumerable<Car> cars)
        {
            InitializeComponent();
            Cars = cars;
            cmb_Cars.ItemsSource = Cars;
            NewPeople = new People();
        }


        private void btn_CreateUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmb_Cars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Car? car = (e.AddedItems[0] as Car);
            NewPeople.CarModel = car;
        }

        private void txt_Name_LostFocus(object sender, RoutedEventArgs e)
        {
            NewPeople.Name = txt_Name.Text;
        }

        private void txt_Surname_LostFocus(object sender, RoutedEventArgs e)
        {
            NewPeople.Surname = txt_Surname.Text;
        }
    }
}
