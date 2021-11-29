using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public class CompareService : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.ConsumptionFuel > y.ConsumptionFuel)
            {
                return 1;
            }
            else if (x.ConsumptionFuel < y.ConsumptionFuel)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
