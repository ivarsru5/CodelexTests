using System;
namespace DragRace
{
	public interface ICar
	{
		public int CurrentSpeed { get; set; }

        public void SpeedUp(int byAmount);

        public void SlowDown(int byAmount);

        public string ShowCurrentSpeed();

        public void StartEngine(string input)
        {
            Console.WriteLine("");
        }
    }
}

