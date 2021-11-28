using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;
using Module2HW6.Providers.Abstract;
using Module2HW6.Services.Abstract;
using Module2HW6.Services;

namespace Module2HW6.Services
{
    public class TaxiStationService : ITaxiStationService
    {
        private readonly ITaxiStationProvider _stationProvider;
        private Car[] _cars;
        public TaxiStationService(ITaxiStationProvider stationProvider)
        {
            _stationProvider = stationProvider;
            _cars = _stationProvider.GetCars();
        }

        public Car[] GetCars()
        {
            return _cars;
        }

        public void InfoCars(Car[] cars)
        {
            foreach (var car in cars)
            {
                InfoCar(car);
            }
        }

        public void InfoCar(Car car)
        {
            Console.WriteLine(car.NumberCar + " " + car.Manufacturer + " " + car.ModelCar + " " + car.Year + " " + car.TypeBody + car.CategoryCar + " " + car.ConsumptionFuel);
        }

        public Car SearchCar(Car[] cars, Manufacturer manufacturer, TypeBody typeBody)
        {
            var car = cars.SearchCar(manufacturer, typeBody);

            return car;
        }

        public Car[] SortCarByFuel(Car[] cars)
        {
            Array.Sort(cars, new CompareService());

            return cars;
        }

        public double SumCars(Car[] cars)
        {
            double sum = 0;

            foreach (var car in cars)
            {
                sum += car.Price;
            }

            return sum;
        }
    }
}
