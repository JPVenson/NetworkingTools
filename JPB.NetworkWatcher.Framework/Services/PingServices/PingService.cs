using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JPB.NetworkWatcher.Framework.PingTest.Model;
using JPB.NetworkWatcher.Framework.Services.Storage;

namespace JPB.NetworkWatcher.Framework.Services.PingServices
{
	public class PingService
	{
		public PingService()
		{
			
		}

		public List<PingInfo> PingInfos { get; set; }

		public async ValueTask Refresh(IStorageService storage)
		{
			PingInfos = (await storage.PingAccessLayer.GetPingInfos()).ToList();
		}
	}
}
