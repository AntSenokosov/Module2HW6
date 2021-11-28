using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Services.Abstract;
using Module2HW6.Models;

namespace Module2HW6
{
    public class Startup
    {
        private readonly ITaxiStationService _taxiStation;

        public Startup(ITaxiStationService taxiStation)
        {
            _taxiStation = taxiStation;
        }

        public void Run()
        {
            var cars = _taxiStation.GetCars();
            Console.WriteLine("Авто в таксопарке");
            _taxiStation.InfoCars(cars);
            Console.WriteLine();

            Console.WriteLine("Поиск авто");
            var car = _taxiStation.SearchCar(cars, Manufacturer.Audi, TypeBody.Closed);
            _taxiStation.InfoCar(car);
            Console.WriteLine();

            Console.WriteLine("Сортировка авто по расходу топлива");
            cars = _taxiStation.SortCarByFuel(cars);
            _taxiStation.InfoCars(cars);
            Console.WriteLine();

            Console.WriteLine("Стоимость таксопарка: " + _taxiStation.SumCars(cars));
        }
    }
}
