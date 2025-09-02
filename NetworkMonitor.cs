using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace WinSecSentinel
{
    public class NetworkMonitor
    {
        public List<string> GetActiveConnections()
        {
            var connections = new List<string>();
            var properties = IPGlobalProperties.GetIPGlobalProperties();

            connections.Add("--- Active TCP Connections ---");
            foreach (var conn in properties.GetActiveTcpConnections())
            {
                connections.Add($"{conn.LocalEndPoint.Address}:{conn.LocalEndPoint.Port} -> {conn.RemoteEndPoint.Address}:{conn.RemoteEndPoint.Port} ({conn.State})");
            }

            connections.Add("\n--- Active TCP Listeners ---");
            foreach (var listener in properties.GetActiveTcpListeners())
            {
                connections.Add($"{listener.Address}:{listener.Port}");
            }

            return connections;
        }
    }
}