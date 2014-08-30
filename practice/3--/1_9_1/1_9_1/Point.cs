using System;

namespace _9_1
{
	public class Point
	{
		public Point ()
		{
		}
		private int x=0,y=0;
		public Point(int x,int y)
		{
			this.x = x;
			this.y = y;
		}
		public int X
		{
			get { return this.x; }
			set { this.x = value; }
		}
		public int Y {
			get { return this.y; }
			set { this.y = value; }
		}
	}
}

