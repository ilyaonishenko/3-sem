using System;

namespace _2_2_1
{
	class MainClass
	{
		public static double x=0,y=0,r=0;
		public static void Main (string[] args)
		{
			//int x0 = 0, y0 = 0;
			double k;
			Console.WriteLine ("Введите радиус");
			r = double.Parse (Console.ReadLine ());
			Console.WriteLine ("окружность построена");
			Console.WriteLine ("Введите координату по x");
			x = double.Parse (Console.ReadLine ());
			Console.WriteLine ("Введите координату по у");
			y = double.Parse (Console.ReadLine ());
			if (x < r && y < r) {
				k = Math.Round(((Math.Atan(y / x)*180)/Math.PI),1);
				Console.WriteLine ("Угол " + k+" градусов");
				if (k > 45.0 && k < 90.0)
					Console.WriteLine ("Попадает в нужный диапазон.");
				else if (k > 225.0 && k < 270.0)
					Console.WriteLine ("Попадает в нужный диапазон.");
				else
					Console.WriteLine ("Не попадает в нужный диапазон.");
			} else
				Console.WriteLine ("Радиус меньше значения ");
		}
	}
}
