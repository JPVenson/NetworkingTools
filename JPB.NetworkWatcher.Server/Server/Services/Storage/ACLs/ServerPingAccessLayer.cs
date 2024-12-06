using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JPB.NetworkWatcher.Framework.PingTest.Model;
using JPB.NetworkWatcher.Framework.Services.Storage;

namespace JPB.NetworkWatcher.Server.Server.Services.Storage.ACLs
{
	public class ServerAccessLayerBase : AccessLayerBase
	{
		public ServerAccessLayerBase(ServerStorageService storageService) : base(storageService)
		{
		}

		public new ServerStorageService StorageService
		{
			get
			{
				return base.StorageService as ServerStorageService;
			}
		}
	}

	public class ServerPingAccessLayer : ServerAccessLayerBase
	{
		public ServerPingAccessLayer(ServerStorageService storageService) : base(storageService)
		{
		}

		public async Task<PingInfo[]> GetPingInfos()
		{
			return StorageService.GetAccessLayer().Select<>()
		}
	}
}
