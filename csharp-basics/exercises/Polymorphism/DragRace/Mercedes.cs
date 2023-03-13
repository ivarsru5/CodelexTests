using System;
namespace DragRace
{
	public class Mercedes: ICar, IBoost
	{
        public int CurrentSpeed { get; set; }

        public Mercedes(int speed)
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

        public void UseNitrousOxideEngine(int boostRate)
        {
            CurrentSpeed = (boostRate / 100) * CurrentSpeed;
        }
    }
}

