using System;
namespace Scooters.Interfaces
{
	public interface IRentalRecord
	{
		public string Id { get; }

		public DateTime StartRent { get; }

		public DateTime EndRent { get; set; }

		public decimal Cost { get; set; }

		public decimal PricePerMinute { get;  }

		public int CauculateCost(TimeSpan used);
	}
}

