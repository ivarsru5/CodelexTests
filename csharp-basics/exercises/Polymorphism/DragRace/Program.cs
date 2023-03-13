using System;
using System.Linq;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            List<ICar> allCars = new List<ICar>();
            allCars.Add(new Audi(30));
            allCars.Add(new Bmw(40));
            allCars.Add(new Lexus(60));
            allCars.Add(new Tesla(100));
            allCars.Add(new VW(10));
            allCars.Add(new Mercedes(110));

            for (var index = 0; index <= 10; index++)
            {
                if(index == 3 && allCars[index] is IBoost)
                {
                    var car = allCars[index];
                    IBoost boost = (IBoost)car;
                    boost.UseNitrousOxideEngine(50);
                }
            }
            allCars = (List<ICar>)allCars.OrderByDescending(x => x.CurrentSpeed).FirstOrDefault();
            var fastest = allCars.First();
            Console.WriteLine(fastest);
            Console.WriteLine(fastest.CurrentSpeed);
        }
    }
}