using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class BMWZ4 : Roadster
    {
        public BMWZ4(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.BMW;
            ModelCar = "Z4";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
