using EntityFramework_Mapper.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using EntityFramework_Mapper.Windows;
using EntityFramework_Mapper.Models;
using System;

namespace EntityFramework_Mapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public readonly ApplicationDbContext dbContext;
        public MainWindow()
        {
            InitializeComponent();
            dbContext = new ApplicationDbContext();

        }

        private void btn_LoadData_Click(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void btn_CreateCar_Click(object sender, RoutedEventArgs e)
        {
            CarCreationWindow carWindow = new CarCreationWindow();
            carWindow.ShowDialog();
            Car newCar = carWindow.CarModel;
            if (newCar is not null)
            {
                dbContext.Cars.Add(newCar);
                dbContext.SaveChanges();
                MessageBox.Show("Dodano pojazd");
                RefreshData();
            }
        }

        private async void RefreshData()
        {
            List<Models.People>? users = await Task.Run(() => dbContext.Peoples.Include(x => x.CarModel).ToList());

            datagrid1.ItemsSource = users;
        }

        private void btn_CreateUser_Click(object sender, RoutedEventArgs e)
        {
            UserCreationWindow userWindow = new UserCreationWindow(dbContext.Cars.Include(x => x.Peoples).ToList());
            userWindow.ShowDialog();
            People people = userWindow.NewPeople;
            if (people is not null)
            {
                dbContext.Peoples.Add(people);
                dbContext.SaveChanges();
                MessageBox.Show("Dodano użytkownika");
                RefreshData();
            }
        }

    }
}
