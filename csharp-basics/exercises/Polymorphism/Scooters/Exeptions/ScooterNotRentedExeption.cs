using System;
namespace Scooters.Exeptions
{
	public class ScooterNotRentedExeption : Exception
	{
		public ScooterNotRentedExeption() : base("Cannot close rent as it is already rented.")
		{
		}
	}
}

