using System;
namespace VendingMachine.Exceptions
{
	public class ProductAddingException : Exception
	{
		public ProductAddingException() : base("Failed to add product, please check if all fields are correct")
		{
		}
	}
}

