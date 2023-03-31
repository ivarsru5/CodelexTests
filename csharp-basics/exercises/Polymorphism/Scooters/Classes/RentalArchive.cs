using System;
using Scooters.Interfaces;

namespace Scooters.Classes
{
	public class RentalArchive : IRentalArchive
    {
        public List<IRentalRecord> AllRecords { get; }
        public List<IRentalRecord> ActiveRecords { get; }

        public RentalArchive()
		{
            AllRecords = new List<IRentalRecord>();
            ActiveRecords = new List<IRentalRecord>();

        }

        public void AddToArchive(IRentalRecord record)
        {
            AllRecords.Add(record);
        }

        public void AddToActive(IRentalRecord record)
        {
            ActiveRecords.Add(record);
        }
    }
}

