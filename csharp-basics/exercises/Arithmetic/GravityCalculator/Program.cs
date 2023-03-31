
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //To be fair, I didnt know the formula to cauculate gravitys volacity, so I used what I found on that.
            //And had a help for correct cauculations.
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.5 * gravity * Math.Pow(fallingTime, 2) + initialVelocity * fallingTime + initialPosition;
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
