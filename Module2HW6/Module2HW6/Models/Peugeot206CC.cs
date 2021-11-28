using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class Peugeot206CC : Cabriolet
    {
        public Peugeot206CC(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.Peugeot;
            ModelCar = "206CC";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
