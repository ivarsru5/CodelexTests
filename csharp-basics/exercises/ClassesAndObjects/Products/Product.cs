using System;
namespace Products
{
	public class Product
	{
		public string name;
		public double price;
		public int amount;

		public Product(string name, double price, int amount)
		{
			this.name = name;
			this.price = price;
			this.amount = amount;
		}

		public void PrintProduct()
		{
			Console.WriteLine($"{this.name}, {this.price}, {this.amount}");
		}

		public void ChangePrice(double newPrice)
		{
			this.price = newPrice;
		}

		public void ChangeQuantity(int newAmount)
		{
			this.amount = newAmount;
		}
	}
}