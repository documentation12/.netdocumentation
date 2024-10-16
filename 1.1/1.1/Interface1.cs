using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    public interface Interface1
    {
        void Activate();
    }

    public class Device : Interface1
    {
        public void Activate()
        {
            Console.WriteLine("Device Activated");
        }
    }
}
