using System;
namespace Movies
{
	public class Move
	{
		public string Title;
		public string Studio;
		public string Rating;

		public Move(string title, string studio, string rating)
		{
			this.Title = title;
			this.Studio = studio;
			this.Rating = rating;
		}

		public Move(string title, string studio)
		{
			this.Title = title;
			this.Studio = studio;
			this.Rating = "PG";
		}
	}
}

