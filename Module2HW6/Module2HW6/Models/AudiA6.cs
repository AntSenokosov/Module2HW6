using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public class AudiA6 : Sedan
    {
        public AudiA6(string numberCar, int year, double price, double consumptionFuel)
        {
            NumberCar = numberCar;
            Manufacturer = Manufacturer.Audi;
            ModelCar = "A6 Matrix Led S Line";
            Year = year;
            Price = price;
            ConsumptionFuel = consumptionFuel;
        }
    }
}
