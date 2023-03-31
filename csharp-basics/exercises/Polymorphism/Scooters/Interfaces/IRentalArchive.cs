using System;
namespace Scooters.Interfaces
{
	public interface IRentalArchive
	{
		public List<IRentalRecord> AllRecords { get; }

		public List<IRentalRecord> ActiveRecords { get; }

		public void AddToArchive(IRentalRecord record);

		public void AddToActive(IRentalRecord record);
	}
}

