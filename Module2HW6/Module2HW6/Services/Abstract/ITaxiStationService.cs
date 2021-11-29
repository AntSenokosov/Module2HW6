﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW6.Models;

namespace Module2HW6.Services.Abstract
{
    public interface ITaxiStationService
    {
        Car[] GetCars();
        Car SearchCar(Car[] cars, Manufacturer manufacturer, TypeBody typeBody);
        Car[] SortCarByFuel(Car[] cars);

        double SumCars(Car[] car);

        void InfoCars(Car[] cars);

        void InfoCar(Car car);
    }
}
