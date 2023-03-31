using System;
using Scooters.Interfaces;

namespace Scooters.Classes
{
	public class RentalRecord : IRentalRecord
    {
        public string Id { get; }
        public DateTime StartRent { get; }
        public DateTime EndRent { get; set; }
        public decimal Cost { get; set; }
        public decimal PricePerMinute { get; }

        public RentalRecord(string id, decimal pricePerMinute, DateTime startRent)
		{
            this.Id = id;
            this.StartRent = startRent;
            this.PricePerMinute = pricePerMinute;
		}

        public int CauculateCost(TimeSpan used)
        {
            throw new NotImplementedException();
        }
    }
}

