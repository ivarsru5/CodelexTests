using System;
namespace Scooters
{
	public class NoScooterIdExeption: Exception
	{
		public NoScooterIdExeption() : base("Scooter id not provided")
		{
		}
	}
}

