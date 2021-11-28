using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;
using Module2HW6.Providers.Abstract;
using Module2HW6.Services.Abstract;

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

        public Car SearchCar()
        {
            throw new NotImplementedException();
        }

        public Car[] SortCarByFuel()
        {
            throw new NotImplementedException();
        }
    }
}
