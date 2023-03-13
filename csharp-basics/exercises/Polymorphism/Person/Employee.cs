using System;
namespace Person
{
	public class Employee: Person
	{
		public string JobTitle;

		public Employee(int id, string firstName, string lastName, string address, string title) : base(id, firstName, lastName, address)
        {
			JobTitle = title;
		}

        public override void Display()
        {
            Console.WriteLine("Employee ID: {0}, name: {1}, last name: {2}, address: {3}, job title: {4}", Id, FirstName, LastName, Address, JobTitle);
        }
    }
}

