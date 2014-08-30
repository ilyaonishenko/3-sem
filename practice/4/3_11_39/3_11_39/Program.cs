using System;
using System.Collections.Generic;

namespace _11_39
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 0;
			Console.WriteLine ("length:");
			n = int.Parse (Console.ReadLine ());
			Random r = new Random ();
			int[] arr = new int[n];
			Console.WriteLine ("min");
			int min = int.Parse (Console.ReadLine ());
			Console.WriteLine ("max");
			int max = int.Parse (Console.ReadLine ());
			for (int i = 0; i < n; i++) {
				arr [i] = r.Next (min,max);
				Console.Write (arr [i] + " ");
			}
			int count = 0;
			for (int i = 1; i < n - 1; i++) {
				if (arr [i - 1] < arr [i] && arr [i] < arr [i + 1])
					count++;
				else if (arr [i - 1] > arr [i] && arr [i] > arr [i + 1])
					count++;
			}
			Console.WriteLine ("");
			Console.WriteLine (""+count);
		}
	}
}
