using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class FordMustang : Cabriolet
    {
        public FordMustang(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.Ford;
            ModelCar = "Mustang";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
