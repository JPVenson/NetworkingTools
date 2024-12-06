using System.Collections.Generic;
using System.Xml.Serialization;

namespace JPB.NetworkWatcher.Framework.SpeedTest.Model
{
    [XmlRoot("settings")]
    public class ServersList
    {
        [XmlArray("servers")]
        [XmlArrayItem("server")]
        public List<Server> Servers { get; set; }

        public ServersList()
        {
            Servers = new List<Server>();
        }

        public void CalculateDistances(Coordinate clientCoordinate)
        {
            foreach (var server in Servers)
            {
                server.Distance = clientCoordinate.GetDistanceTo(server.GeoCoordinate);
            }
        }
    }
}