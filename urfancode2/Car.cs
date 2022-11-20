using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urfancode2
{
    //2.2. Car class (Car classi Vehicle-den miras alir)
    //- Brand
    //- Model
    //- FuelCapacity
    //- FuelFor1Km
    //- CurrentFuel



    internal class Car : Vehicle
    {
        public string brand;
        public string model;
        public double fuelcapacty;
        public double fuelfor1km;
        public double currentfuel;

        public Car(string brand, string model, double fuelcapacty, double fuelfor1km, double currentfuel, string color, int year) : base(color, year)
        {
            this.brand = brand;
            this.model = model;
            this.fuelcapacty = fuelcapacty;
            this.fuelfor1km = fuelfor1km;
            this.currentfuel = currentfuel;
        }
        //Showinfo method:

        public void Showinfo()
        {
            Console.WriteLine($"brand={this.brand} <=> model={this.model};\nfuelcapty={this.fuelcapacty} <=> fuelfor1km={this.fuelfor1km};\n currentfuel={this.currentfuel} <=> color={this.color};\nyear={this.year};\n");

        }
        // Drive method=> parametr distance:
        public double Drive(double distance)
        {
            if (currentfuel >= distance * fuelfor1km)
            {


                return currentfuel - (distance * fuelfor1km);
            }
            return -1;
        }
    }
}
