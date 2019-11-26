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

using System.Collections.ObjectModel;

namespace CA1CarApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Vehicle> vehicles = new ObservableCollection<Vehicle>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //create object
            Vehicle v1 = new Vehicle() { Make = "Ford", Model = "Focus", Price = "£3000", Mileage = "5000 miles", Description = "Lovely car. Hatchback", Engine = "2 litre"};
            Vehicle v2 = new Vehicle() { Make = "Volkswagen", Model = "Jetta", Price = "£7000", Mileage = "9700 miles", Description = "Very nice, very comfortable", Engine = "1.8 litre" };
            Vehicle v3 = new Vehicle() { Make = "Ford", Model = "Fiesta", Price = "£8000", Mileage = "200 miles", Description = "Very comnfortable", Engine = "2 litre" };
            Vehicle v4 = new Vehicle() { Make = "Toyota", Model = "Corolla", Price = "£2500", Mileage = "83000 miles", Description = "Great car", Engine = "1.2 litre" };
            Vehicle v5 = new Vehicle() { Make = "Opel", Model = "Astra", Price = "£3000", Mileage = "3200 miles", Description = "Great condition, Reliable", Engine = "1.5 litre" };

            //add to collection
            vehicles.Add(v1);
            vehicles.Add(v2);
            vehicles.Add(v3);
            vehicles.Add(v4);
            vehicles.Add(v5);


            //display
            lbxVehicle.ItemsSource = vehicles;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //create a new window
            AddVehicle av = new AddVehicle();

            //set the owner of the new window
            av.Owner = this;

            //display the second window
            av.ShowDialog();
        }
    }
}
