using System;
using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Providers.Abstract;
using Module2HW6.Services.Abstract;
using Module2HW6.Providers;
using Module2HW6.Services;

namespace Module2HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new ServiceCollection()
                .AddTransient<ITaxiStationProvider, TaxiStationProvider>()
                .AddSingleton<ITaxiStationService, TaxiStationService>()
                .AddTransient<Startup>()
                .BuildServiceProvider();

            var start = res.GetService<Startup>();
            start.Run();

            Console.ReadKey();
        }
    }
}
