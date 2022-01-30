using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {
        /*members*/

        //fields
        public string city;
        public string name;
        public string model;
        public int year;
        public string type;
        public string color;
        public double engine;
        public int horsePower;
        public string fuelType;
        public double distance;
        public string gearbox;
        public string transmission;
        public double price;


        //methods

        public string GetInfo()
        {
            string output = $"City: {this.city}\n" +
                $"Brand: {this.name}\n" +
                $"Model: {this.model}\n" +
                $"Release year: {this.year}\n" +
                $"Ban type: {this.type}\n" +
                $"Color: {this.color}\n" +
                $"Engine: {this.engine} L\n" +
                $"Engine power: {this.horsePower} h.p.\n" +
                $"Fuel type: {this.fuelType}\n" +
                $"Distance: {this.distance}km\n" +
                $"Gearbox type: {this.gearbox}\n" +
                $"Transmission: {this.transmission}\n" +
                $"Price: {this.price} ₼";
            return output;  
        }
    }
}
