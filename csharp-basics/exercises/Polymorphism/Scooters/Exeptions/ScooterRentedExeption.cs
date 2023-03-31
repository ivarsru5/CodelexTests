using System;
namespace Scooters
{
	public class ScooterRentedExeption: Exception
	{
		public ScooterRentedExeption() : base("To delete scooter, the scooter should not be rented.")
		{
		}
	}
}

