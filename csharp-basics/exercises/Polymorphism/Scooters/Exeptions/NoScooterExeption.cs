using System;
namespace Scooters.Exeptions
{
	public class NoScooterExeption : Exception
	{
		public NoScooterExeption() : base("There is no such scooter")
		{
		}
	}
}

