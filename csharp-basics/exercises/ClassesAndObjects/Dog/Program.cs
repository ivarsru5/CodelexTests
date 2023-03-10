namespace Dog;
class Program
{
    static void Main(string[] args)
    {
        List<Dog> dogs = new List<Dog>();
        dogs.Add(new Dog("Max", "male", null, null));
        dogs.Add(new Dog("Rocky", "male", null, null));
        dogs.Add(new Dog("Sparky", "male", null, null));
        dogs.Add(new Dog("Buster", "male", null, null));
        dogs.Add(new Dog("Sam", "male", null, null));
        dogs.Add(new Dog("Lady", "female", null, null));
        dogs.Add(new Dog("Molly", "female", null, null));
        dogs.Add(new Dog("Coco", "female", null, null));
        dogs.Add(new Dog("Max", null, "Lady", "Rocky"));
        dogs.Add(new Dog("Coco", null, "Molly", "Buster"));
        dogs.Add(new Dog("Rocky", null, "Molly", "Sam"));
        dogs.Add(new Dog("Coco", null, "Lady", "Sparky"));

        var chekForDog = dogs[9];
        var checkForMother = HasSameMotherAs(dogs, chekForDog);

        if (chekForDog != null)
        {
            Console.WriteLine("Dog {0} has the same mother as {1}", chekForDog.Name, checkForMother!.Name);
        }
        else
        {
            Console.WriteLine("There is no dog with the same mother name!");
        }
    }

    static public Dog? HasSameMotherAs(List<Dog> dogs, Dog selectedDog)
    {
        Dog? hasSameMother = null;
        foreach (var dog in dogs)
        {
            if (dog.Mother == selectedDog.Mother)
            {
                hasSameMother = dog;
                break;
            }
        }
        return hasSameMother;
    }
}

