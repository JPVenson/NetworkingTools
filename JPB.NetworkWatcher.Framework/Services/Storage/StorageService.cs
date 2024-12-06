using System.Threading.Tasks;
using JPB.NetworkWatcher.Framework.PingTest.Model;

namespace JPB.NetworkWatcher.Framework.Services.Storage
{
	public interface IStorageService : IAccessLayer
	{
		IPingAccessLayer PingAccessLayer { get; set; }
	}

	public interface IAccessLayer
	{
		
	}

	public abstract class AccessLayerBase : IAccessLayer
	{
		public virtual IStorageService StorageService { get; }

		public AccessLayerBase(IStorageService storageService)
		{
			StorageService = storageService;
		}
	}

	public interface IPingAccessLayer
	{
		Task<PingInfo[]> GetPingInfos();
	}
}
