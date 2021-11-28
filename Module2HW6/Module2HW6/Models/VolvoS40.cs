using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class VolvoS40 : Sedan
    {
        public VolvoS40(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.Volvo;
            ModelCar = "S40 Limited Edition D2";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
