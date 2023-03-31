using System;
namespace Scooters
{
	public class InvalidPriceExeption: Exception
	{
		public InvalidPriceExeption(): base("Provided price not valid. Please enter positive price.")
		{
		}
	}
}

