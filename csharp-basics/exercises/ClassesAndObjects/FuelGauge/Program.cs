namespace FuelGauge;
class Program
{
    static void Main(string[] args)
    {
        var odometer = new Odometer(0);
        var fuelGauge = new FuelGauge(50);

        while (fuelGauge.Liters != 0)
        {
            odometer.AddToOdo();
            if (odometer.OdometerKm % 10 == 0)
            {
                fuelGauge.RemoveFuelByOne();
            }
        }
        Console.WriteLine("Distance traveled: {0} with {1} liters of fuel remaining", odometer.OdometerKm, fuelGauge.Liters);
    }
}

