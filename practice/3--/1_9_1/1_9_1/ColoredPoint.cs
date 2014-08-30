using System;

namespace _9_1
{
	public class ColoredPoint:Point
	{
		public ColoredPoint ()
		{
		}
		public ColoredPoint(int x,int y, int color):base(x,y)
		{
			this.color = color;
		}
		private int color;
		public int Color {
			get { return this.color; }
			set { this.color = value; }
		}
	}
}

