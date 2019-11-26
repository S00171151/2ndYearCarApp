using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1CarApplication
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public string Mileage { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public string Engine { get; set; }


        public Vehicle()
        {

        }

        public Vehicle(string make, string model, string price, string mileage, string year, string description, string engine)
        {
            Make = make;
            Model = model;
            Price = price;
            Mileage = mileage;
            Year = year;
            Description = description;
            Engine = engine;
        }

        public override string ToString()
        {
            return string.Format(Make, Model,  Price, Mileage, Year, Description, Engine);
        }
    }
}
