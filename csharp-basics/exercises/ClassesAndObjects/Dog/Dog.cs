using System;
namespace Dog
{
	public class Dog
	{
		public string Name { get; set; }
		public string? Sex { get; set; }
		public string? Mother { get; set; }
		public string? Father { get; set; }

		public Dog(string name, string? sex, string? mother, string? father)
		{
			this.Name = name;
			this.Sex = sex;
			this.Mother = mother;
			this.Father = father;
		}

		public string GetFathersName(Dog fromDog)
		{
			if (fromDog.Father != null)
			{
				return fromDog.Father;
			}
			else
			{
				return "Unknown";
			}
		}
	}
}

