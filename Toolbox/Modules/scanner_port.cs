using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Toolbox.Modules
{
    public class Scanner_port
    {
        /// <summary>
        /// Scans a range of ports on the specified host to determine which ones are open.
        /// </summary>
        /// <param name="host">The target IP address or hostname.</param>
        /// <param name="startPort">The starting port number of the range to scan.</param>
        /// <param name="endPort">The ending port number of the range to scan.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of open port numbers.</returns>
        public async Task<List<int>> ScanPortsAsync(string host, int startPort, int endPort)
        {
            List<int> openPorts = new List<int>();

            List<Task> tasks = new List<Task>();
            for (int port = startPort; port <= endPort; port++)
            {
                tasks.Add(Task.Run(async () =>
                {
                    if (await IsPortOpenAsync(host, port))
                    {
                        lock (openPorts)
                        {
                            openPorts.Add(port);
                        }
                    }
                }));
            }

            await Task.WhenAll(tasks);

            return openPorts;
        }

        /// <summary>
        /// Checks asynchronously if a specific port on the given host is open.
        /// </summary>
        /// <param name="host">The target IP address or hostname.</param>
        /// <param name="port">The port number to check.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a boolean indicating whether the port is open.</returns>
        private async Task<bool> IsPortOpenAsync(string host, int port)
        {
            try
            {
                using (TcpClient tcpClient = new TcpClient())
                {
                    var connectTask = tcpClient.ConnectAsync(host, port);
                    if (await Task.WhenAny(connectTask, Task.Delay(1000)) == connectTask)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
