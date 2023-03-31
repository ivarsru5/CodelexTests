using System;
namespace Scooters.Exeptions
{
	public class ScooterExistsExeption: Exception
	{
		public ScooterExistsExeption() : base("Scooter already exists")
		{
		}
	}
}

