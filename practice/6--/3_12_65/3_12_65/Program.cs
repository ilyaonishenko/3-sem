using System;

namespace _12_65
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//i - stroki
			//j- stolby
			Console.WriteLine ("stroki");
			int m = int.Parse (Console.ReadLine ());
			Console.WriteLine ("stolbi");
			int n = int.Parse (Console.ReadLine ());
			Console.WriteLine ("min");
			int min = int.Parse (Console.ReadLine ());
			Console.WriteLine ("max");
			int max = int.Parse (Console.ReadLine ());
			int[,] array = new int[m, n];
			Random r = new Random ();
			for (int i = 0; i < m; i++)
				for (int j = 0; j < n; j++)
					array [i, j] = r.Next (min, max);
			for (int i = 0; i < m; i++) {
				for (int j = 0; j < n; j++)
					Console.Write (array [i, j] + "     ");
				Console.WriteLine ("");
			}
			int[,] arr = new int[m, n - 1];
			int count = 0;
			int z = 0;
			for (int j = 0; j < n; j++) {
				count = 0;
				for (int i = 0; i < m; i++) {
					if (array [i, j] > 0) {
						count++;
						z = j;
					}
				}
				if (count == m) {
					for (int q = 0; q < m; q++)
						for (int k = 0; k < n - 1; k++) {
							if (k == z)
								k += 1;
							arr [q, k] = array [q, k];
						}

				}
			}
		}
	}
}

