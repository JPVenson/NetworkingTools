using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JPB.DataAccess.Manager;
using JPB.NetworkWatcher.Framework.Services.Storage;
using Microsoft.Extensions.Configuration;

namespace JPB.NetworkWatcher.Server.Server.Services.Storage
{
	public class ServerStorageService : IStorageService
	{
		private readonly IConfiguration _config;

		public ServerStorageService(IConfiguration config)
		{
			_config = config;
		}

		public string DbConnectionString { get; set; }

		public async Task Init()
		{
			DbConnectionString = _config["AppSettings.Database.ConnectionString"];
			var types = GetType().Assembly.GetTypes();
			foreach (var propertyInfo in GetType().GetProperties().Where(e => typeof(IAccessLayer).IsAssignableFrom(e.PropertyType)))
			{
				var impls = types
					.FirstOrDefault(e => propertyInfo.PropertyType.IsAssignableFrom(e));
				propertyInfo.SetValue(this, Activator.CreateInstance(impls), new object[] { this });
			}
		}

		public DbAccessLayer GetAccessLayer()
		{
			return new DbAccessLayer(DbAccessType.MsSql, "");
		}

		public IPingAccessLayer PingAccessLayer { get; set; }
	}
}
