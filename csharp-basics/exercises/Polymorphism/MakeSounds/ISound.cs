using System;

namespace MakeSounds
{
    interface ISound
    {
        public void PlaySound(string sound)
        {
            Console.WriteLine(sound);
        }
    }   
}