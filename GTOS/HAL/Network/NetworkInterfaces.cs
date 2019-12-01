using Cosmos.HAL;
using System.Collections.Generic;

namespace GTOS.HAL.Network
{
    class NetworkInterfaces
    {
        private static List<string> PCIName = new List<string>();
        private static List<string> CustomName = new List<string>();

        public static void Init()
        {
            int ID = 0;
            foreach (NetworkDevice networkDevice in NetworkDevice.Devices)
            {
                PCIName.Add(networkDevice.Name);
                if (networkDevice.CardType == CardType.Ethernet)
                {
                    CustomName.Add("eth" + ID);
                }
                else if (networkDevice.CardType == CardType.Wireless)
                {
                    CustomName.Add("wls" + ID);
                }
                else
                {
                    CustomName.Add("unk" + ID);
                }
                ID++;
            }
        }
    }
}