using System;

namespace _9_1
{
	public class ColoredLine:Line
	{
		public ColoredLine ()
		{
		}
		public ColoredLine (int x1,int x2, int y1,int y2, int color1):base(Start,End)
		{
			this.color = color;
		}
		public ColoredLine (int x1,int x2, int y1,int y2, int color1):this(new Point(x1,y1),new Point(x2,y2))
		{
		}
		private int color;
		public int Color {
			get { return color; }
			set { color = value; }
		}
	}
}

