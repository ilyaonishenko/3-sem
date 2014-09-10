using System;

namespace _1_99
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n=0;
			double x = 0;
			double sum = 0;
			double sum2 = 0;
			Console.WriteLine ("n=");
			n = int.Parse (Console.ReadLine ());
			Console.WriteLine ("x=  (|x|<1)");
			x = Math.Abs(double.Parse (Console.ReadLine ()));
			for (int i = 1; i <= n; i++) {
				sum2 += Math.Pow (-1, i) * (((2 * i - 1) * Math.Pow (x, (2 * i + 1))) / ((2 * i + 1) * (2 * i)));
				Console.WriteLine ("x= {0}_______sum2= {1}",x,sum2);
			}
			sum = Math.Round( x + sum2,4);
			Console.WriteLine ("sum = "+sum);
			double asx =Math.;
			Console.WriteLine ("Arcsh(x)= "+asx);
			Console.WriteLine ("Разность: "+(asx - sum).ToString());
		}
	}
}
