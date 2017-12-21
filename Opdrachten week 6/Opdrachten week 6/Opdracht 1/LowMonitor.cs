using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class LowMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("is very low res....");
        }
    }
}
