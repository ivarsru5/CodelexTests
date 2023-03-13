using System;
using System.Net;

namespace Person
{
	public class Person
	{
        public int Id;
        public string FirstName;
        public string LastName;
        public string Address;

        public Person(int id, string firstName, string lastName, string address)
		{
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public virtual void Display()
        {
            Console.WriteLine("Person id: {0}, first name: {1} last name: {2}, address {3}");
        }
    }
}

