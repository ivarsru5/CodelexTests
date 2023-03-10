using System;
namespace Points
{
	public class Points
	{
		public int x { get; set; }
		public int y { get; set; }

		public Points(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

        public static void SwitchPoints(ref Points p1, ref Points p2)
        {
            Points temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}

