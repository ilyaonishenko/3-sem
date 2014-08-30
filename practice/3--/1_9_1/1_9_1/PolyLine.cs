using System;
using System.Collections.Generic;

namespace _9_1
{
	public class PolyLine:Line
	{
		public PolyLine ()
		{
		}
		public PolyLine(List<Line> frieng)
		{
			this.Frieng = frieng;
		}

		private List<Line> _Frieng;
		public List<Line> Frieng
		{
			get { return _Frieng; }
			set { _Frieng = value; }
		}
	}
}

