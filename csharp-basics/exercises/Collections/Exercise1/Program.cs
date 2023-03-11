using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            //todo - replace array with an List and print out the results
            List<string> arrayList = new List<string>();
            foreach (var car in array)
                arrayList.Add(car);

            Console.WriteLine("Array List: {0}", arrayList.Count);

            //todo - replace array with a HashSet and print out the results
            HashSet<string> hasArray = new HashSet<string>();
            foreach (var car in array)
                hasArray.Add(car);

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
            Dictionary<string, string> dicArray = new Dictionary<string, string>();
            dicArray.Add("Audi", "Germany");
            dicArray.Add("BMW", "Germany");
            dicArray.Add("Honda", "Japan");
            dicArray.Add("Mercedes", "Germany");
            dicArray.Add("VolksWagen", "Germany");
            dicArray.Add("Mercedes", "Germany");
            dicArray.Add("Tesla", "USA");
        }
    }
}
