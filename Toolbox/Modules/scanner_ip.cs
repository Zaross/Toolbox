using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Modules
{
    public class Scanner_ip
    {
        private DataGridView dataGridView;

        public Scanner_ip(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }

        /// <summary>
        /// Scans a range of IP addresses to find active IPs within the specified range.
        /// </summary>
        /// <param name="startIP">The starting IP address of the range.</param>
        /// <param name="endIP">The ending IP address of the range.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of active IP addresses.</returns>
        public async Task<List<string>> ScanNetworkRangeAsync(string startIP, string endIP)
        {
            List<string> activeIPs = new List<string>();
            int start = IPToInt(startIP);
            int end = IPToInt(endIP);

            var tasks = new List<Task>();
            for (int ip = start; ip <= end; ip++)
            {
                string currentIP = IntToIP(ip);
                tasks.Add(Task.Run(async () =>
                {
                    if (await PingIPAddressAsync(currentIP))
                    {
                        lock (activeIPs)
                        {
                            activeIPs.Add(currentIP);
                            AddToDataGridView(currentIP);
                        }
                    }
                }));
            }

            await Task.WhenAll(tasks);
            return activeIPs;
        }

        /// <summary>
        /// Converts an IP address from its string representation to an integer.
        /// </summary>
        /// <param name="ip">The IP address in string format.</param>
        /// <returns>An integer representation of the IP address.</returns>
        private int IPToInt(string ip)
        {
            string[] parts = ip.Split('.');
            return (int.Parse(parts[0]) << 24) | (int.Parse(parts[1]) << 16) | (int.Parse(parts[2]) << 8) | int.Parse(parts[3]);
        }

        /// <summary>
        /// Converts an IP address from its integer representation to a string.
        /// </summary>
        /// <param name="ipInt">The IP address in integer format.</param>
        /// <returns>A string representation of the IP address.</returns>
        private string IntToIP(int ipInt)
        {
            return string.Format("{0}.{1}.{2}.{3}",
                (ipInt >> 24) & 0xFF,
                (ipInt >> 16) & 0xFF,
                (ipInt >> 8) & 0xFF,
                ipInt & 0xFF);
        }

        /// <summary>
        /// Pings the specified IP address asynchronously.
        /// </summary>
        /// <param name="ip">The IP address to ping.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean value indicating whether the ping was successful.</returns>
        private async Task<bool> PingIPAddressAsync(string ip)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    var reply = await ping.SendPingAsync(ip, 1000);
                    return reply.Status == IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Adds the specified IP address to the DataGridView.
        /// </summary>
        /// <param name="ip">The IP address to add.</param>
        private void AddToDataGridView(string ipAddress)
        {
            if (dataGridView.InvokeRequired)
            {
                dataGridView.Invoke(new Action(() => dataGridView.Rows.Add(new object[] { null, null, ipAddress })));
            }
            else
            {
                dataGridView.Rows.Add(new object[] { null, null, ipAddress });
            }
        }
        /// <summary>
        /// Resolves the hostname for a given IP address.
        /// </summary>
        /// <param name="ipAddress">The IP address to resolve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the hostname.</returns>
        private async Task<string> GetHostNameAsync(string ipAddress)
        {
            try
            {
                var hostEntry = await Dns.GetHostEntryAsync(ipAddress);
                return hostEntry.HostName;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
