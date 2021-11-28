using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class RenaultMegane : Universal
    {
        public RenaultMegane(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.Renault;
            ModelCar = "Megane ZEN 110 dCi";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
