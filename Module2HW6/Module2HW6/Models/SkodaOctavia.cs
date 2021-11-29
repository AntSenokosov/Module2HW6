using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class SkodaOctavia : Universal
    {
        public SkodaOctavia(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.Skoda;
            ModelCar = "Octavia A5 Elegance Maximal";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
