using System;
namespace FuelGauge
{
	public class FuelGauge
	{
		public double Liters { get; set; }

		public FuelGauge(double liters)
		{
			this.Liters = liters;
		}

		public void AddFuelByOne()
		{
			if (Liters >= 70)
			{
				this.Liters += 1;
			}
		}

		public void RemoveFuelByOne()
		{
			if (Liters > 0)
			{
				this.Liters -= 1;
			}
		}
	}
}

