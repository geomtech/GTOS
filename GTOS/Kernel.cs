using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace GTOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("GTOS v0.1.2");
            GTOS.HAL.Network.NetworkInterfaces.Init();
            foreach (Cosmos.HAL.NetworkDevice device in Cosmos.HAL.NetworkDevice.Devices)
            {
                Console.WriteLine(device.MACAddress.ToString());
            }
        }

        protected override void Run()
        {
            Console.Write("Command > DONE");
            var input = Console.ReadLine();
        }
    }
}
