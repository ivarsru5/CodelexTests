using System;
namespace Person
{
	public class Student: Person
	{
		public double Gpa;

		public Student(int id, string firstName, string lastName, string address, double gpa) : base(id, firstName, lastName, address)
		{
			Gpa = gpa;
		}

		public override void Display()
		{
			Console.WriteLine("Students ID: {0}, name: {1}, last name: {2}, address: {3}, gpa: {4}", Id, FirstName, LastName, Address, Gpa);
		}
    }
}