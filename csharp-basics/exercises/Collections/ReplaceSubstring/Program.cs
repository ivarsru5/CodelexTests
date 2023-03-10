﻿using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };
            //ToDo: Write a query that replaces 'ea' substring with astersik (*) in given list of words.
            //ToDo: "learn", "current", "deal" →  "l*rn", "current", "d*l"
            words = words.Select(x => x.Replace("ea", "*")).ToArray();
            foreach (var word in words)
                Console.WriteLine(word);
        }
    }
}
