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

        public Car SearchCar(Manufacturer manufacturer, TypeBody typeBody)
        {
            var car = _cars.SearchCar(manufacturer, typeBody);

            return car;
        }

        public Car[] SortCarByFuel()
        {
            Array.Sort(_cars, new CompareService());

            return _cars;
        }

        public double SumCars()
        {
            double sum = 0;

            foreach (var car in _cars)
            {
                sum += car.Price;
            }

            return sum;
        }
    }
}
