using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class LowHardDrive : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("moving slow.....");
        }
    }
}
