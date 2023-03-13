using System;

namespace DragRace
{
    public class Audi : ICar
    {
        public int CurrentSpeed { get; set; }

        public Audi(int speed)
        {
            this.CurrentSpeed = speed;
        }

        public void SpeedUp(int byAmount)
        {
            CurrentSpeed += byAmount;
        }

        public void SlowDown(int byAmount)
        {
            CurrentSpeed -= byAmount;
        }

        public string ShowCurrentSpeed()
        {
            return CurrentSpeed.ToString();
        }
    }
}