using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;
using Module2HW6.Providers.Abstract;

namespace Module2HW6.Providers
{
    public class TaxiStationProvider : ITaxiStationProvider
    {
        private readonly ITaxiStationProvider _taxiStation;
        private Car[] _cars;

        public TaxiStationProvider(ITaxiStationProvider taxiStation)
        {
            _taxiStation = taxiStation;
            InitCars();
        }

        public Car[] GetCars()
        {
            return _cars;
        }

        public void InitCars()
        {
        }
    }
}
