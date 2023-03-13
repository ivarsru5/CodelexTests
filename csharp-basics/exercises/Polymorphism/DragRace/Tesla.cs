using System;

namespace DragRace
{
    public class Tesla: ICar
    {
        public int CurrentSpeed { get; set; }

        public Tesla(int speed)
        {
            this.CurrentSpeed = speed;
        }

        public void SpeedUp(int byAmount) 
        {
            CurrentSpeed += byAmount;
        }

        public void SlowDown(int byAmount) 
        {
            CurrentSpeed += byAmount;
        }

        public string ShowCurrentSpeed() 
        {
            return CurrentSpeed.ToString();
        }
    }
}