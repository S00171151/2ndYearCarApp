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

namespace CA1CarApplication
{
    /// <summary>
    /// Interaction logic for AddVehicle.xaml
    /// </summary>
    public partial class AddVehicle : Window
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //read text
            string make = tbxMake.Text;
            string model = tbxModel.Text;
            string price = tbxPrice.Text;
            string year = tbxYear.Text;
            string mileage = tbxMileage.Text;

            //create object
            Vehicle newV1 = new Vehicle() { Make = make };
            Vehicle newV2 = new Vehicle() { Model = model };
            Vehicle newV3 = new Vehicle() { Price = price };
            Vehicle newV4 = new Vehicle() { Year = year };
            Vehicle newV5 = new Vehicle() { Mileage = mileage };
            
            //add to list of vehicles
            MainWindow mw = Owner as MainWindow;
            mw.vehicles.Add(newV1);
            mw.vehicles.Add(newV2);
            mw.vehicles.Add(newV3);
            mw.vehicles.Add(newV4);
            mw.vehicles.Add(newV5);
            //close the window
            this.Close();
        }
    }
}
