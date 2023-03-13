using System;
namespace MakeSounds
{
	public class Parrot: ISound
	{
		private string _parrotOrigin;

		public Parrot(string origin)
		{
			_parrotOrigin = origin;
		}

		public string GetOrigin()
		{
			return _parrotOrigin;
		}
	}
}

