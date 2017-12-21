using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class HighHardDrive : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing all the data");
        }
    }
}
