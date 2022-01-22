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
    /// Logika interakcji dla klasy CarCreationWindow.xaml
    /// </summary>
    public partial class CarCreationWindow : Window
    {
        public Car CarModel { get; private set; }
        public CarCreationWindow()
        {
            InitializeComponent();
            CarModel = new Car() { Description = String.Empty};
        }

        private void CloseWindow()
        {
            this.Close();
        }

        private void txt_Brand_LostFocus(object sender, RoutedEventArgs e)
        {
            CarModel.Brand = txt_Brand.Text;
        }

        private void txt_Model_LostFocus(object sender, RoutedEventArgs e)
        {
            CarModel.Name = txt_Model.Text;
        }

        private void btn_CreateCar_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }
    }
}
