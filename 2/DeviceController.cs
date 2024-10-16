using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    public class DeviceController : IDevice
    {
        private string Device;

        public DeviceController(string device)
        {
            Device = device;
        }

        public void Activate()
        {
            Console.WriteLine($"The {Device} is now active.");
        }
    }
}
