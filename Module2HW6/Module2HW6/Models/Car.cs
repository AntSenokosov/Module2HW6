using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW6.Models
{
    public abstract class Car
    {
        public int NumberCar { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string ModelCar { get; set; }
        public TypeBody TypeBody { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public double ConsumptionFuel { get; set; }
    }
}
