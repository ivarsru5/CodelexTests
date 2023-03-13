using System;
namespace MakeSounds
{
	public class Radio: ISound
	{
		private double _frequency;

		public Radio(double freq)
		{
			_frequency = freq;
		}

		public double GetFrequency()
		{
			return _frequency;
		}
    }
}

