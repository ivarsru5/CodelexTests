using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            int endKilometers;
            
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter end reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());

                var car = new Car(startKilometers, endKilometers, liters);

                Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            }
            Console.ReadKey();
        }
    }
}
