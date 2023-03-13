using System;

namespace MakeSounds
{
    public class Firework: ISound
    {
        private string _fireworksType;

        public Firework(string fireworks)
        {
            _fireworksType = fireworks;
        }

        public string GetFireworkType()
        {
            return _fireworksType;
        }
    }
}