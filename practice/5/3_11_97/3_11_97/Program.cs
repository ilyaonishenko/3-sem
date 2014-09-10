using System;
using System.Collections.Generic;
namespace _11_97
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 0;
			Console.WriteLine ("lenght");
			n = int.Parse (Console.ReadLine ());
			Console.WriteLine ("min");
			int min = int.Parse (Console.ReadLine ());
			Console.WriteLine ("max:");
			int max = int.Parse (Console.ReadLine ());
			int[] array = new int[n];
			Random r = new Random ();
			for (int i = 0; i < n; i++) {
				array [i] = r.Next (min, max);
				Console.Write (array [i] + " ");
			}
			Console.WriteLine ("");
			List<int> list = new List<int> ();
			int count = 0;
			for (int i = 0; i < n; i++) {
				count = 0;
				for (int j = i + 1; j < n; j++)
					if (array [i] == array [j])
						count++;
				if (count < 1)
					list.Add (array [i]);
			}
			for (int i = 0; i < list.Count; i++)
				Console.Write (list [i] + " ");
		}
	}
}
