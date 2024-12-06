using System;
using System.Collections.Generic;
using JPB.NetworkWatcher.Framework.Data;
using JPB.NetworkWatcher.Framework.Data.SpeedTest;

namespace JPB.NetworkWatcher.Framework.SpeedTest
{
	public interface ISpeedTestProcessor
	{
		IEnumerable<SpeedTestResult> Measure(Action<string> output);
		IEnumerable<DataPoint> ParseData(string line);
	}
}