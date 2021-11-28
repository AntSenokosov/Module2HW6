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
        private Car[] _cars;

        public TaxiStationProvider()
        {
            InitCars();
        }

        public Car[] GetCars()
        {
            return _cars;
        }

        public void InitCars()
        {
            int count = 0;
            Car bmw = new BMWZ4("VT4324AA", 2006, 50000, 12.5);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = bmw;
            count++;

            Car mercedes = new MercedesSLC43("AA9643AX", 2003, 6000, 9.2);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = mercedes;
            count++;

            Car skoda = new SkodaOctavia("KK5932NB", 2003, 3000, 7.8);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = skoda;
            count++;

            Car audi = new AudiA6("AX2245VT", 2008, 3700, 8.0);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = audi;
            count++;

            Car ford = new FordMustang("KK3423AA", 2015, 9400, 10.3);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = ford;
            count++;

            Car peugeot = new Peugeot206CC("AA5321VT", 2009, 10500, 14.5);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = peugeot;
            count++;

            Car renault = new RenaultMegane("KT4924AA", 2005, 3050, 12.0);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = renault;
            count++;

            Car volvo = new VolvoS40("KK4923VT", 2009, 5000, 11.6);
            Array.Resize(ref _cars, count + 1);
            _cars[count] = volvo;
        }
    }
}
