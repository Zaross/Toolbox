using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Modules
{
    public class Rechner_subnetz
    {
        public string IP { get; set; }
        public string SubnetMask { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rechner_subnetz"/> class with the specified IP address and subnet mask.
        /// </summary>
        /// <param name="ip">The IP address.</param>
        /// <param name="subnetMask">The subnet mask.</param>
        public Rechner_subnetz(string ip, string subnetMask)
        {
            IP = ip;
            SubnetMask = subnetMask;
        }

        /// <summary>
        /// Calculates the network address by performing a bitwise AND operation between the IP address and the subnet mask.
        /// </summary>
        /// <returns>The network address as a string.</returns>
        public string CalculateNetworkAddress()
        {
            return PerformBitwiseOperation(IP, SubnetMask);
        }
        /// <summary>
        /// Calculates the broadcast address for the subnet.
        /// </summary>
        /// <returns>The broadcast address as a string.</returns>
        public string CalculateBroadcastAddress()
        {
            var networkAddress = CalculateNetworkAddress();
            var networkBytes = IPToBytes(networkAddress);
            var subnetMaskBytes = IPToBytes(SubnetMask);

            for (int i = 0; i < 4; i++)
            {
                networkBytes[i] |= (byte)(~subnetMaskBytes[i]);
            }

            return BytesToIP(networkBytes);
        }

        /// <summary>
        /// Calculates the first host address in the subnet.
        /// </summary>
        /// <returns>The first host address in the subnet as a string.</returns>
        public string CalculateFirstHostAddress()
        {
            var networkAddress = CalculateNetworkAddress();
            var networkBytes = IPToBytes(networkAddress);
            networkBytes[3] += 1;
            return BytesToIP(networkBytes);
        }

        /// <summary>
        /// Calculates the last host address in the subnet.
        /// </summary>
        /// <returns>The last host address in the subnet as a string.</returns>
        public string CalculateLastHostAddress()
        {
            var broadcastAddress = CalculateBroadcastAddress();
            var broadcastBytes = IPToBytes(broadcastAddress);
            broadcastBytes[3] -= 1;
            return BytesToIP(broadcastBytes);
        }


        /// <summary>
        /// Calculates the number of hosts available in the subnet.
        /// </summary>
        /// <returns>The number of hosts available in the subnet.</returns>
        public int CalculateNumberOfHosts()
        {
            var subnetMaskBytes = IPToBytes(SubnetMask);
            int numberOfHostBits = 0;
            for (int i = 0; i < 4; i++)
            {
                byte mask = subnetMaskBytes[i];
                while (mask > 0)
                {
                    if ((mask & 1) == 0)
                        numberOfHostBits++;
                    mask >>= 1;
                }
            }
            return (int)Math.Pow(2, numberOfHostBits) - 2;
        }

        /// <summary>
        /// Converts an IP address string to a byte array.
        /// </summary>
        /// <param name="ip">The IP address in string format.</param>
        /// <returns>A byte array representing the IP address.</returns>
        private byte[] IPToBytes(string ip)
        {
            var parts = ip.Split('.');
            byte[] bytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                bytes[i] = Convert.ToByte(parts[i]);
            }
            return bytes;
        }

        /// <summary>
        /// Converts a byte array to its corresponding IP address string.
        /// </summary>
        /// <param name="bytes">The byte array representing the IP address.</param>
        /// <returns>A string representation of the IP address.</returns>
        private string BytesToIP(byte[] bytes)
        {
            return string.Join(".", bytes);
        }

        /// <summary>
        /// Performs a bitwise AND operation between the given IP address and subnet mask.
        /// </summary>
        /// <param name="ip">The IP address.</param>
        /// <param name="subnetMask">The subnet mask.</param>
        /// <returns>The resulting network address after the bitwise operation.</returns>
        private string PerformBitwiseOperation(string ip, string subnetMask)
        {
            var ipBytes = IPToBytes(ip);
            var subnetMaskBytes = IPToBytes(subnetMask);
            byte[] networkBytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                networkBytes[i] = (byte)(ipBytes[i] & subnetMaskBytes[i]);
            }

            return BytesToIP(networkBytes);
        }

        /// <summary>
        /// Converts the subnet mask to CIDR notation.
        /// </summary>
        /// <returns>A string representing the CIDR notation of the subnet mask.</returns>
        public string GetCIDRNotation()
        {
            var subnetMaskBytes = IPToBytes(SubnetMask);
            int cidr = 0;
            foreach (var byteValue in subnetMaskBytes)
            {
                cidr += CountBits(byteValue);
            }
            return $"/{cidr}";
        }

        /// <summary>
        /// Counts the number of set bits (1s) in the given byte.
        /// </summary>
        /// <param name="byteValue">The byte value to count bits in.</param>
        /// <returns>The number of set bits in the byte.</returns>
        private int CountBits(byte byteValue)
        {
            int count = 0;
            while (byteValue > 0)
            {
                if ((byteValue & 1) == 1)
                    count++;
                byteValue >>= 1;
            }
            return count;
        }
    }
}

