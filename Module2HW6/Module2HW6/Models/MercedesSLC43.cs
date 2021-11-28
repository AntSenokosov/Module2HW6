using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class MercedesSLC43 : Roadster
    {
        public MercedesSLC43(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.MercedesBenz;
            ModelCar = "SLC 43 AMG Redline";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
