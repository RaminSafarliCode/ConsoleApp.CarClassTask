
using System;
using System.Text;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Car car1 = new Car();

            car1.city = "Baku";
            car1.name = "Lexus";
            car1.model = "LX 570";
            car1.year = 2013;
            car1.type = "Offroader";
            car1.color = "White";
            car1.engine = 5.7;
            car1.horsePower = 383;
            car1.fuelType = "Gasoline";
            car1.distance = 70000;
            car1.gearbox = "Automatic";
            car1.transmission = "Front";
            car1.price = 58000;

            Car car2 = new Car();

            car2.city = "Baku";
            car2.name = "Chevrolet";
            car2.model = "Cruze";
            car2.year = 2017;
            car2.type = "Sedan";
            car2.color = "Silver";
            car2.engine = 1.4;
            car2.horsePower = 153;
            car2.fuelType = "Gasoline";
            car2.distance = 215000;
            car2.gearbox = "Automatic";
            car2.transmission = "Front";
            car2.price = 17700;

            Car car3 = new Car();

            car3.city = "Gandja";
            car3.name = "LADA (VAZ)";
            car3.model = "2106";
            car3.year = 1987;
            car3.type = "Sedan";
            car3.color = "Cyan";
            car3.engine = 1.6;
            car3.horsePower = 75;
            car3.fuelType = "Gasoline";
            car3.distance = 470000;
            car3.gearbox = "Manual";
            car3.transmission = "Back";
            car3.price = 3500;

            Car[] cars = new Car[3];

            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;

            foreach (Car car in cars)
            {
                Console.WriteLine(car.GetInfo());
                Console.WriteLine("--------------------------");
            }



        }
    }
}
