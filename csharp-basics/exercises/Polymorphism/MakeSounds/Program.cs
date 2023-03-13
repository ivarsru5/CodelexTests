using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> sounds = new List<ISound>();
            sounds.Add(new Firework("Blaster"));
            sounds.Add(new Parrot("Africa"));
            sounds.Add(new Radio(96.2));

            foreach (var obj in sounds)
            {
                ISound sound = obj;

                if (obj is Firework)
                {
                    var type = ((Firework)obj).GetFireworkType();
                    Console.WriteLine("Firework {0} sound: ", type);
                    sound.PlaySound("Whoosh....");
                }
                else if (obj is Parrot)
                {
                    var origin = ((Parrot)obj).GetOrigin();
                    Console.WriteLine("Parrot from {0} makes sound: ", origin);
                    sound.PlaySound("Praap...");
                }
                else
                {
                    var freq = ((Radio)obj).GetFrequency();
                    Console.WriteLine("Raio freq {0} makes sound: ", freq);
                    sound.PlaySound("Shhhhhhh....");
                }
            }
        }
    }
}