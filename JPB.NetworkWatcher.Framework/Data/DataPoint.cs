using System;

namespace JPB.NetworkWatcher.Framework.Data
{
	public class DataPoint
	{
		public DataPoint()
		{
			
		}

		public DataPoint(DateTime dateTime, decimal value)
		{
			DateTime = dateTime;
			Value = value;
		}

		public DateTime DateTime { get; set; }
		public decimal Value { get; set; }
	}
}