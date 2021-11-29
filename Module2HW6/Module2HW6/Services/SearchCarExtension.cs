using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;

namespace Module2HW6.Services
{
    public static class SearchCarExtension
    {
        static SearchCarExtension()
        {
        }

        public static Car SearchCar(this Car[] cars, Manufacturer manufacturer, TypeBody typeBody)
        {
            Car searchcar = null;

            foreach (var car in cars)
            {
                if ((car.Manufacturer == manufacturer) && (car.TypeBody == typeBody))
                {
                    searchcar = car;
                }
            }

            return searchcar;
        }
    }
}
