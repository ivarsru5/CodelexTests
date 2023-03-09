using System;
namespace FuelGauge
{
	public class Odometer
	{
		public double OdometerKm { get; set; }

		public Odometer(double odometer)
		{
			this.OdometerKm = odometer;
		}

		public void AddToOdo()
		{
			if (OdometerKm < 999.999)
			{
				OdometerKm += 1;
			}
			else
			{
				OdometerKm = 0;
			}
		}
	}
}

