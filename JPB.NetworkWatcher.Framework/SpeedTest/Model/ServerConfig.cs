using System.Xml.Serialization;

namespace JPB.NetworkWatcher.Framework.SpeedTest.Model
{
    [XmlRoot("server-config")]
    public class ServerConfig
    {
        [XmlAttribute("ignoreids")]
        public string IgnoreIds { get; set; }
    }
}