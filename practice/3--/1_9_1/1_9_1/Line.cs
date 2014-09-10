using System;

namespace _9_1
{
	public class Line:Point
	{
		public Line ()
		{
		}
		public Line (Point start,Point end)
		{
			this.start = start;
			this.end = end;
		}
		public Line (int x1,int x2, int y1, int y2):this(new Point(x1,y1), new Point(x2,y2))
		{
		}
		private Point start,end;
		private double angle;
		public double Angle {
			get { return angle; }
			set { angle = value; }
		}
		public Point Start {
			get { return start; }
			set { start = value; }
		}
		public Point End {
			get {return end; }
			set { end = value; }
		}
		public void showAngle(Point p1, Point p2)
		{
			Angle = Math.Round ((Math.Atan((Math.Abs(p2.Y-p1.Y))/(Math.Abs(p2.X-p1.X)))*180)/Math.PI,1);
			Console.WriteLine ("Угол поворота: "+Angle);
		}
	}
}

